namespace DevelopAuxiliaryTool
{
    public partial class Form1 : Form
    {
        private static Form1 instance; // 单例实例
        public Form1()
        {
            InitializeComponent();
        }

        // 获取单例实例的静态方法
        public static Form1 GetInstance()
        {
            if (instance == null)
                instance = new Form1();
            return instance;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            instance.Visible = false;
            GenerateEntityClassForm form = new GenerateEntityClassForm();
            form.ShowDialog();
            
        }
    }
}