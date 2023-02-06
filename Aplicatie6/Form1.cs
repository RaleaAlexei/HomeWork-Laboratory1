namespace Aplicatie6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyData)
            {
                case Keys.Up:
                    this.Location = new Point(this.Location.X, this.Location.Y - this.Height / 2);
                    break;
                case Keys.Down:
                    this.Location = new Point(this.Location.X, this.Location.Y + this.Height / 2);
                    break;
                case Keys.Left:
                    this.Location = new Point(this.Location.X - this.Width / 2, this.Location.Y);
                    break;
                case Keys.Right:
                    this.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y);
                    break;
                default:
                    break;
            }
        }
    }
}