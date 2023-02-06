namespace Aplicatie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random Rand = new Random();
            this.BackColor = Color.FromArgb(Rand.Next(256), Rand.Next(256), Rand.Next(256));
        }
    }
}