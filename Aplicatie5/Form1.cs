using System.Diagnostics;

namespace Aplicatie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    goto case '-';
                case '-':
                    {
                        var TenthSize = new Size(
                            (int)(this.Width * 0.1), 
                            (int)(this.Height * 0.1)
                        );
                        if(e.KeyChar == '+')
                        {
                            this.Size += TenthSize;
                        }
                        else
                        {
                            this.Size -= TenthSize;
                        }
                        break;
                    }
                case 'c':
                    this.CenterToScreen();
                    break;
                #region HeightControl
                case 'H':
                    goto case 'h';
                case 'h':
                    {
                        int TenthHeight = (int)(this.Width * 0.1);
                        this.Height += 'H' == e.KeyChar ? TenthHeight : -TenthHeight;
                        break;
                    }
                #endregion
                #region WidthControl
                case 'L':
                    goto case 'l';
                case 'l':
                    {
                        int TenthWidth = (int)(this.Width * 0.1);
                        this.Width += 'L' == e.KeyChar ? TenthWidth : -TenthWidth;
                        break;
                    }
                #endregion
                case 'x':
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}