using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeuge_Projekt
{
	abstract class Landfahrzeug : Fahrzeug
	{
		private int amountWheel;
		private string fuelType; 

		protected int GetSetWheel {
			get => amountWheel;
			set => amountWheel = value;
		}
		protected string GetSetFuelType
		{
			get => fuelType;
			set => fuelType = value;
		}

		// Methods of Class "Landfahrzeug"

		public virtual void SetFuelType(string x) {
			GetSetFuelType = x;
		}
		public virtual void SetWheelAmount(int x) {
			if (x > 10) {
				x = 10;
			}
			GetSetWheel = x;
		}
	}
}
