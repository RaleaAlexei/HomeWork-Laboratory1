namespace Aplicatie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "SALUTARE!";
        }
    }
}