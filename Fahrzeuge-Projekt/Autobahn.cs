using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Fahrzeuge_Projekt
{
    public partial class Autobahn : Form
	{
		public Autobahn()
		{
			InitializeComponent();
		}

		private void CloseWindow(object sender, EventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		private void StartThreads()
        {
			Thread thr1 = new Thread(BlackCar.StartProcess());
			Thread thr2 = new Thread(BlueCar.StartProcess());
			bool running = true;

			while(running)
            {
				System.Random random = new System.Random();
				int randomThreadStart = random.Next(10);
                if(randomThreadStart < 5)
                {
					thr1.Start();
				}
				else
                {
					thr2.Start();
				}
			}
        }
	}
}
