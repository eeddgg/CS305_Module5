using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Byte timeToShutdown = 60;
        public Form1()
        {
            InitializeComponent();
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseEnter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            shutdownTimer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point f = panel1.PointToClient(Cursor.Position);
            if(f.X-button1.Location.X >= -50&& f.X - button1.Location.X <= 50 && Math.Abs(button1.Location.Y-f.Y)<=50)
            {
                if ((button1.Location.X-20) - (button1.Width / 8.0) >= 0)
                {
                    button1.Location = new Point(button1.Location.X-20, button1.Location.Y);

                }
                else if ((button1.Location.X + 20) + (button1.Width / 8.0) <= panel1.Width)
                {
                    button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);

                }

                if ((button1.Location.Y-20)+(button1.Height/8)>=0)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 20);
                }
                else if ((button1.Location.Y-20)-(button1.Height/8.0)<=panel1.Height)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 20);
                }

            }
            panel1.Refresh();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point f = panel1.PointToClient(Cursor.Position);
            if (f.X - button1.Location.X >= -50 && f.X - button1.Location.X <= 50 && Math.Abs(button1.Location.Y - f.Y) <= 50)
            {
                if ((button1.Location.X - 20) - (button1.Width / 8.0) >= 0)
                {
                    button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);

                }
                else if ((button1.Location.X + 20) + (button1.Width / 8.0) <= panel1.Height)
                {
                    button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);

                }
                if ((button1.Location.Y - 20) + (button1.Height / 8) >= 0)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 20);
                }
                else if ((button1.Location.Y - 20) - (button1.Height / 8) <= panel1.Height)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 20);
                }
            }
            panel1.Refresh();
        }

        public void shutdownTimer()
        {
            label1.Text = $"Unless you can close the window in {timeToShutdown} seconds,\r\n the system will immediately shut down.";
            label1.Refresh();
            
            if (timeToShutdown <= 0)
            {
                //System.Diagnostics.Process.Start("Shutdown", "/s /t 0");
            }
            else
            {
                timeToShutdown--;
            }
        }

        

    }
}
