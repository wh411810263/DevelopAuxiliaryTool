namespace DevelopAuxiliaryTool
{
    partial class GenerateEntityClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_InputFile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label_outPut = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txt_DataBaseStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_DataBaseType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_RuleStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_RuleEnd = new System.Windows.Forms.TextBox();
            this.panel_Lanuage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Sql文件|*.sql";
            this.openFileDialog1.Title = "选择文件";
            // 
            // label_InputFile
            // 
            this.label_InputFile.AutoSize = true;
            this.label_InputFile.Location = new System.Drawing.Point(15, 16);
            this.label_InputFile.Name = "label_InputFile";
            this.label_InputFile.Size = new System.Drawing.Size(116, 17);
            this.label_InputFile.TabIndex = 2;
            this.label_InputFile.Text = "数据库连接字符串：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "选择输出文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_outPut
            // 
            this.label_outPut.AutoSize = true;
            this.label_outPut.Location = new System.Drawing.Point(125, 554);
            this.label_outPut.Name = "label_outPut";
            this.label_outPut.Size = new System.Drawing.Size(92, 17);
            this.label_outPut.TabIndex = 6;
            this.label_outPut.Text = "输出文件夹路径";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(980, 551);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "生成";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // txt_DataBaseStr
            // 
            this.txt_DataBaseStr.Location = new System.Drawing.Point(125, 13);
            this.txt_DataBaseStr.Name = "txt_DataBaseStr";
            this.txt_DataBaseStr.Size = new System.Drawing.Size(928, 23);
            this.txt_DataBaseStr.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "数据库类型：";
            // 
            // cmb_DataBaseType
            // 
            this.cmb_DataBaseType.FormattingEnabled = true;
            this.cmb_DataBaseType.Items.AddRange(new object[] {
            "MySql"});
            this.cmb_DataBaseType.Location = new System.Drawing.Point(125, 42);
            this.cmb_DataBaseType.Name = "cmb_DataBaseType";
            this.cmb_DataBaseType.Size = new System.Drawing.Size(156, 25);
            this.cmb_DataBaseType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "生成文件类型：";
            // 
            // cmb_Language
            // 
            this.cmb_Language.FormattingEnabled = true;
            this.cmb_Language.Items.AddRange(new object[] {
            "C#",
            "JAVA"});
            this.cmb_Language.Location = new System.Drawing.Point(125, 75);
            this.cmb_Language.Name = "cmb_Language";
            this.cmb_Language.Size = new System.Drawing.Size(156, 25);
            this.cmb_Language.TabIndex = 14;
            this.cmb_Language.SelectedIndexChanged += new System.EventHandler(this.cmb_Language_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "生成文件名称规则：";
            // 
            // text_RuleStart
            // 
            this.text_RuleStart.Location = new System.Drawing.Point(164, 109);
            this.text_RuleStart.Name = "text_RuleStart";
            this.text_RuleStart.Size = new System.Drawing.Size(156, 23);
            this.text_RuleStart.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "前缀：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "后缀：";
            // 
            // text_RuleEnd
            // 
            this.text_RuleEnd.Location = new System.Drawing.Point(380, 112);
            this.text_RuleEnd.Name = "text_RuleEnd";
            this.text_RuleEnd.Size = new System.Drawing.Size(156, 23);
            this.text_RuleEnd.TabIndex = 18;
            this.text_RuleEnd.Text = "_Model";
            // 
            // panel_Lanuage
            // 
            this.panel_Lanuage.Location = new System.Drawing.Point(20, 146);
            this.panel_Lanuage.Name = "panel_Lanuage";
            this.panel_Lanuage.Size = new System.Drawing.Size(1035, 399);
            this.panel_Lanuage.TabIndex = 20;
            // 
            // GenerateEntityClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.panel_Lanuage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_RuleEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_RuleStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Language);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_DataBaseType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DataBaseStr);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label_outPut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_InputFile);
            this.Name = "GenerateEntityClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成实体类";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerateEntityClassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label_InputFile;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Label label_outPut;
        private Button btn_Confirm;
        private TextBox txt_DataBaseStr;
        private Label label1;
        private ComboBox cmb_DataBaseType;
        private Label label2;
        private ComboBox cmb_Language;
        private Label label3;
        private TextBox text_RuleStart;
        private Label label4;
        private Label label5;
        private TextBox text_RuleEnd;
        private Panel panel_Lanuage;
    }
}