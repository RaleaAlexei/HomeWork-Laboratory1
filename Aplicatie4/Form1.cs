namespace Aplicatie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = "A fost apasat mouse-ul!";
        }
        private void Form1_KeyEvent(object sender, KeyEventArgs e)
        {
            this.Text = $"Caracterul {e.KeyData} a fost activat!";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Iti vad mouse-ul pe pozitia ({e.X} {e.Y})";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Ai iesit de pe suprafat mea.";

        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Ai intrat pe suprafat mea.";
        }
    }
}