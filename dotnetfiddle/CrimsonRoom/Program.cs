using System;
using System.Collections;
using System.Runtime.CompilerServices;

// --- MAIN CLASS ---
public enum GameState
{
	Intro,          // The part where we introduce the game and get the player's name.
	Center,   // The part where the player chooses the necklace or ruby.
	eBed,  // The part where the player decides to investigate the bed.
	eDrawer,  // The part where the player investigates the drawer.
	eExitDoor,  // The part where the player investigates the exit door.
	eWindow,  // The part where the player investigates the window.
	eCloset,  // The part where the player investigates the closet.
	eMirror,  // The part where the player investigates the mirror.
	eClock,  // The part where the player investigates the clock.
	Quit            // The state that signals the game to end.
}
public class Program
{

	public static void Main()
	{

		// Room specific variables
		string roomName = "The Crimson Room";
		
		// Player variables
		Player thePlayer;
		string ?playerName = null;
		
		// INTRO SEQUENCE
		GameState currentMode = GameState.Intro;

		Console.WriteLine("\"You're inside an eerily dark, red room.\nA rancid smell makes you nauseous.\"");
				Console.WriteLine("\n\"Your head is thumping as your eyes try to adjust. After a while you hear an ethereal and creepy voice.");
				Console.WriteLine("Welcome... to the " + roomName +".");
				
		// Simplified name input loop
			while (string.IsNullOrEmpty(playerName))
			{
				Console.WriteLine("\n\"Hey deadbeat. What's yer name?\"");
				playerName = Console.ReadLine();
				if (string.IsNullOrEmpty(playerName))
				{
					Console.WriteLine("\"I didn't quite get that, my ears must be going bad. Try again.\"");
				}
			}
					
					
			thePlayer = new Player(playerName, 100);
			Console.WriteLine("Well then... welcome" + thePlayer.Name + ".");
			currentMode = GameState.Center;

			while (currentMode != GameState.Quit)
			{	
				switch(currentMode)
				{
					case GameState.Center:
						Console.WriteLine("\nAs you eventually come to your senses, though faint, you can see you're standing in the middle of the room.\nAs you look around, you notice there are an array of things around the room. You see a bed, a drawer, a window, a closet, a mirror, and a clock. There's also a door.");
						currentMode = ChoiceHelper.GetNextState(currentMode);
						break;

					case GameState.eBed:
						invBed.bedInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.eDrawer:
						invDrawer.drawerInvestigate(thePlayer);
						currentMode = GameState.Center;
						break;

					case GameState.eWindow:
						invWindow.windowInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.eCloset:
						invCloset.closetInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.eMirror:
						invMirror.mirrorInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.eClock:
						invClock.clockInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.eExitDoor:
						invExitDoor.exitDoorInvestigate();
						currentMode = GameState.Center;
						break;

					case GameState.Quit:
						gameQuit.QuitGame();
						break;

					default:
						Console.WriteLine("Uhm. Nope. Maybe try using another synapse.");
						break;
				}
			}
	}
}