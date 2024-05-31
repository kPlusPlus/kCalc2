namespace kCalc2
{
    public partial class Form1 : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HideColumn2();
        }

        private void ShowColumn2()
        {
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 10F;
        }

        private void HideColumn2()
        {
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 1F;
        }
    }
}
