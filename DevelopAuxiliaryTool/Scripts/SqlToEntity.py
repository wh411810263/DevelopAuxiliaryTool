import re
import os
import zipfile
import sys


# 打印所有的命令行参数
print("命令行参数:", sys.argv)

if len(sys.argv) > 1:
    # SQL 文件路径
    sql_file_path = sys.argv[1]  # 请将其替换为实际 SQL 文件的路径
    entity_file_dir = sys.argv[2];
# 读取 SQL 文件内容
with open(sql_file_path, 'r', encoding='utf-8') as file:
    sql_content = file.read()

# 匹配 CREATE TABLE 语句的正则表达式
create_table_pattern = re.compile(
    r'CREATE TABLE `(?P<table_name>\w+)` \((?P<columns>.*?)\);',
    re.S
)

# 匹配列定义的正则表达式
column_pattern = re.compile(
    r'`(?P<column_name>\w+)` (?P<column_type>\w+)(?:\((?P<length>\d+)\))?(?P<attributes>.*?)(?:,|\n)',
    re.S
)

# SQL 类型到 C# 类型的映射
type_mapping = {
    'int': 'int',
    'bigint': 'long',
    'tinyint': 'byte',
    'varchar': 'string',
    'datetime': 'DateTime?',
    'text': 'string',
    'decimal': 'decimal',
    'char': 'string',
    'smallint': 'short',
    'mediumint': 'int'
}

entities = {}

# 提取表和列信息
for match in create_table_pattern.finditer(sql_content):
    table_name = match.group('table_name')
    columns = match.group('columns')
    entity_name = ''.join(word.capitalize() for word in table_name.split('_'))
    entity_class = f'using System;\nusing Chloe.Annotations;\n\nnamespace Entity\n{{\n    [Table("{table_name}")]\n    public class {entity_name}\n    {{\n'
    
    for column in column_pattern.finditer(columns):
        column_name = column.group('column_name')
        column_type = column.group('column_type')
        length = column.group('length')
        attributes = column.group('attributes')
        
        # 将 SQL 类型映射到 C# 类型
        csharp_type = type_mapping.get(column_type, 'string')
        
        # 处理主键和自增属性
        if 'PRIMARY KEY' in attributes:
            entity_class += f'        [Column(IsPrimaryKey = true'
            if 'AUTO_INCREMENT' in attributes:
                entity_class += ', IsAutoIncrement = true'
            entity_class += ')]\n'
        
        entity_class += f'        public {csharp_type} {column_name.capitalize()} {{ get; set; }}\n'
    
    entity_class += '    }\n}'
    entities[f'{entity_name}.cs'] = entity_class

# 定义生成的实体类文件的路径
entity_dir = 'path_to_output_directory/Entity'  # 请将其替换为实际输出目录
os.makedirs(entity_dir, exist_ok=True)

# 将每个实体类写入文件
for filename, content in entities.items():
    with open(os.path.join(entity_dir, filename), 'w', encoding='utf-8') as file:
        file.write(content)

# 创建一个包含所有实体类文件的压缩包
zip_path = 'path_to_output_directory/EntityClassesComplete.zip'  # 请将其替换为实际输出 zip 文件路径
with zipfile.ZipFile(zip_path, 'w') as zipf:
    for filename in entities.keys():
        zipf.write(os.path.join(entity_dir, filename), arcname=filename)

print(f'实体类文件已生成并打包到 {zip_path}')
