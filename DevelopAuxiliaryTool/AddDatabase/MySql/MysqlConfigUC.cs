using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopAuxiliaryTool.AddDatabase.MySql
{
    public partial class MysqlConfigUC : UserControl
    {
        public MysqlConfigUC()
        {
            InitializeComponent();
        }
        public EntityBuildModel GetData()
        {
            string nameSpace = text_NameSpace.Text;
            List<string> usingList = text_Using.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList(); 
            return new EntityBuildModel() { NamespaceName = nameSpace, Using = usingList };
        }
    }
   
}
