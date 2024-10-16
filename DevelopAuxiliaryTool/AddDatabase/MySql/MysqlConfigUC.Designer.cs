namespace DevelopAuxiliaryTool.AddDatabase.MySql
{
    partial class MysqlConfigUC
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NameSpace = new System.Windows.Forms.Label();
            this.text_NameSpace = new System.Windows.Forms.TextBox();
            this.label_Using = new System.Windows.Forms.Label();
            this.text_Using = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_NameSpace
            // 
            this.label_NameSpace.AutoSize = true;
            this.label_NameSpace.Location = new System.Drawing.Point(16, 25);
            this.label_NameSpace.Name = "label_NameSpace";
            this.label_NameSpace.Size = new System.Drawing.Size(90, 17);
            this.label_NameSpace.TabIndex = 0;
            this.label_NameSpace.Text = "NameSpace：";
            // 
            // text_NameSpace
            // 
            this.text_NameSpace.Location = new System.Drawing.Point(112, 22);
            this.text_NameSpace.Name = "text_NameSpace";
            this.text_NameSpace.Size = new System.Drawing.Size(350, 23);
            this.text_NameSpace.TabIndex = 1;
            this.text_NameSpace.Text = "Entity";
            // 
            // label_Using
            // 
            this.label_Using.AutoSize = true;
            this.label_Using.Location = new System.Drawing.Point(53, 60);
            this.label_Using.Name = "label_Using";
            this.label_Using.Size = new System.Drawing.Size(53, 17);
            this.label_Using.TabIndex = 2;
            this.label_Using.Text = "Using：";
            // 
            // text_Using
            // 
            this.text_Using.Location = new System.Drawing.Point(112, 60);
            this.text_Using.Multiline = true;
            this.text_Using.Name = "text_Using";
            this.text_Using.Size = new System.Drawing.Size(350, 117);
            this.text_Using.TabIndex = 3;
            this.text_Using.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;";
            // 
            // MysqlConfigUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.text_Using);
            this.Controls.Add(this.label_Using);
            this.Controls.Add(this.text_NameSpace);
            this.Controls.Add(this.label_NameSpace);
            this.Name = "MysqlConfigUC";
            this.Size = new System.Drawing.Size(888, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_NameSpace;
        private TextBox text_NameSpace;
        private Label label_Using;
        private TextBox text_Using;
    }
}
