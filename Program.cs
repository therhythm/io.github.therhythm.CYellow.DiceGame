using System;

namespace DiceGame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DiceGame game = new DiceGame ();
			Console.WriteLine ("Rolling");
			game.play ();
			if (game.Result == 7) {
				Console.WriteLine ("You win (" + game.Result + ")");
			} else {
				Console.WriteLine ("You lose (" + game.Result + ")");
			}
		}
	}
}
