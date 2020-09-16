using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrzeuge_Projekt
{
	public partial class Autobahn : Form
	{
		public Autobahn()
		{
			InitializeComponent();
			timer1.Interval = 16;
			timer1.Enabled = true;
			timer1.Tick += Timer1_Tick;
		}

		System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
		private void Timer1_Tick(object sender, EventArgs e)
		{
			moveCar(BlueCar, "right");
			moveCar(BlackCar, "left");
		}
		private void CloseWindow(object sender, EventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		private bool moveCar(PictureBox e, string x)
        {
			if(x == "right")
            {
				e.Location = new Point(e.Location.X + 3, e.Location.Y);
            }
			else if(x == "left")
            {
				e.Location = new Point(e.Location.X - 3, e.Location.Y);
			}
			else
            {
				Console.WriteLine("Parameter Error -> Direction is invalid or missing");
            }
			return true;
        }

    }
}
