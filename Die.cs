using System;

namespace DiceGame
{
	public class Die
	{
		private int faceValue;

		public int Face {
			get {
				return this.faceValue;
			}
		}

		public void roll ()
		{
			Random rdn = new Random ();
			this.faceValue = rdn.Next (1, 6);
		}
	}
}

