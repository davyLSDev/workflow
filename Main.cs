using System;
using System.IO;
using Gtk;

namespace workflow
{
	class MainClass
	{	
		public static string[] lexiconData;
		
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
		
		public static void Initialize ()
	{
		/* set up (whatever)
		 * 		program configuration file(s)
		 * 		the project(s)
		 * 		the last known window states
		 * 		the Lexicon definitions
		 */ 
		
		// pull definitions from a text file ...	
		const string lexiconFile = "../../files/lexicon.txt";			
		lexiconData = File.ReadAllLines (lexiconFile);
	}
		
	}
}
