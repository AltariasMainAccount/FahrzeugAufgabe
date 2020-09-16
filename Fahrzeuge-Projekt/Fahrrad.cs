namespace Fahrzeuge_Projekt
{
    class Fahrrad : Landfahrzeug
	{
		public override void SetMaxSpeed(int x)
		{
			if (x > 70) {
				x = 70;
			}
			GetSetMaxSpeed = x;
		}
		public override void SetWheelAmount(int x)
		{
			if (x > 2)
            {
				x = 2;
			}
			GetSetWheel = x;
		}
	}
}
