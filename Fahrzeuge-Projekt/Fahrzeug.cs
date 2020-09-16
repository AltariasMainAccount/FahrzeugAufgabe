namespace Fahrzeuge_Projekt
{
    abstract class Fahrzeug
	{
		private int maxSpeed;
		private bool active;

		protected int GetSetMaxSpeed {
			get => maxSpeed;
			set => maxSpeed = value;
		}

		protected bool GetSetActive {
			get => active;
			set => active = value;
		}

		public virtual void SetActive() { }
		public virtual void SetMaxSpeed(int x) { }
	}
}
