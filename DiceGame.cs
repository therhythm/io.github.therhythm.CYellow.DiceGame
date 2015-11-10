using System;

namespace DiceGame
{
	public class DiceGame
	{
		private Die dieOne;
		private Die dieTwo;
		private int result;

		public DiceGame ()
		{
			dieOne = new Die ();
			dieTwo = new Die ();
		}

		public int Result {
			get {
				return this.result;
			}
		}

		public void play ()
		{
			int fv1, fv2;
			dieOne.roll ();
			fv1 = dieOne.Face;
			dieTwo.roll ();
			fv2 = dieTwo.Face;
			result = fv1 + fv2;
		}
	}
}

