using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using DevelopAuxiliaryTool.AddDatabase.MySql.BLL;
using DevelopAuxiliaryTool.AddDatabase.MySql;

namespace DevelopAuxiliaryTool
{
    public partial class GenerateEntityClassForm : Form
    {
        public GenerateEntityClassForm()
        {
            InitializeComponent();
        }

        private void GenerateEntityClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = Form1.GetInstance();
            form.Show();
        }
        /// <summary>
        /// 输出文件夹路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = folderBrowserDialog1.SelectedPath;

                label_outPut.Text = directory;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if(!IsValid()) return;
            //数据库连接语句 "Database=sys;Data Source=localhost;UserID=wanghui;Password=wanghui04.14;allowPublicKeyRetrieval=true;SslMode=None"
            string connectionString = txt_DataBaseStr.Text;
            //文件创建保存地址
            string path = folderBrowserDialog1.SelectedPath;

            var entityBuilder = new CreateEntityModelBuilder.CreateDefaultBuilder();
            switch (cmb_Language.Text)
            {
                case "C#":
                    var panel = (MysqlConfigUC)panel_Lanuage.Controls[0];
                    var option = panel.GetData();
                    option.CustomClassName = fileName => text_RuleStart.Text + fileName + text_RuleEnd.Text;
                    entityBuilder.AddMySql(connectionString).EntityBuild(option).Create(path);
                    break;
                default:
                    break;
            }
            MessageBox.Show("生成成功！");
        }

        private void cmb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_Lanuage.Controls.Clear();
            switch (cmb_Language.Text)
            {
                case "C#":
                    panel_Lanuage.Controls.Add(new MysqlConfigUC());
                    break;
                default:
                    break;
            }
        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txt_DataBaseStr.Text))
            {
                MessageBox.Show("数据库字符串为空！");
                return false;
            }
            if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                MessageBox.Show("生成文件路径为空！");
                return false;
            }
            if (string.IsNullOrEmpty(cmb_Language.Text))
            {
                MessageBox.Show("生成文件类型为空！");
                return false;
            }
            return true;
        }
    }
}
