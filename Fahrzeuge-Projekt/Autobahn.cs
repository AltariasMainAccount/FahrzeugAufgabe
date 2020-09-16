using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrzeuge_Projekt
{
	public partial class Autobahn : Form
	{
		AutoImage car1;
		AutoImage car2;

		public Autobahn()
		{
			InitializeComponent();

			car1 = new AutoImage(this, 'l', Lane.Upper);
			car2 = new AutoImage(this, 'r', Lane.Lower);

			timer1.Interval = 16;
			timer1.Enabled = true;
			timer1.Tick += Timer1_Tick;

		}

		System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
		private void Timer1_Tick(object sender, EventArgs e)
		{
			car1.moveCar();
			car2.moveCar();
		}
		private void CloseWindow(object sender, EventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

    }
}
