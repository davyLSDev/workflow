using System;
using Gtk;
using workflow;

public partial class MainWindow: Gtk.Window
{	
	
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		MainClass.Initialize();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void showWorkTimer (object sender, System.EventArgs e)
	{
		/// Think about ways to keep the value of the timer
		
		entryStatusBarRight.Text = "Get to work!";
		TimerDialog WorkTimer = new TimerDialog ();
		WorkTimer.Title = "Work Timer";
		WorkTimer.Run ();
		WorkTimer.Destroy ();
	}
	
	protected void showBreakTimer (object sender, System.EventArgs e)
	{
		entryStatusBarRight.Text = "Start your break!";
		TimerDialog BreakTimer = new TimerDialog ();
		BreakTimer.Title = "Break Timer";
		BreakTimer.Run ();
		BreakTimer.Destroy ();
	}

	protected void showHelpAboutDialog (object sender, System.EventArgs e)
	{
		AboutDialog about = new AboutDialog();
     	about.ProgramName = "workflow";
		about.Title = "About workflow";
		about.Comments = "This program is intended to help you manage your" +
			" projects in the short, medium, and long term.";
		about.Version = "0.0";  
		about.Copyright = "(c) Dawson Tennant, 2012";
     	about.License = "Copyright (c) <2012>, <Dawson Tennant>\n" +
		"All rights reserved.\n\n" +
		"Redistribution and use in source and binary forms, with or without modification, are permitted provided \n" +
		"that the following conditions are met:\n\n" +
		"	Redistributions of source code must retain the above copyright notice, this list of conditions \n" + 
    	"		and the following disclaimer.\n\n" +
    	"	Redistributions in binary form must reproduce the above copyright notice, this list of conditions \n" +
    	"		and the following disclaimer in the documentation and/or other materials provided with the \n" +
    	"		distribution.\n\n" +
		"THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS \"AS IS\" AND ANY EXPRESS OR \n" + 
		"IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND \n" + 
		"FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR \n" +
		"CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL \n" + 
		"DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, \n" + 
		"DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER \n" + 
		"IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT \n" +
		"OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.";
		about.Website = "https://github.com/abuexegesis/workflow";
		about.Run ();
     	about.Destroy();
	}
	
	protected void displayLexicon (object sender, System.EventArgs e)
	{
		LexiconDialog RBMLexicon = new LexiconDialog ();
		RBMLexicon.Run ();
		RBMLexicon.Destroy ();
	}
	
/*	protected void InitializeWorkflow ()
	{
		 set up (whatever)
		 * 		program configuration file(s)
		 * 		the project(s)
		 * 		the last known window states
		 * 		the Lexicon definitions
		 */ 
		
/*		// pull definitions from a text file ...	
		const string lexiconFile = "../../files/lexicon.txt";
		string lexiconItems;
			
		MainClass. = File.ReadAllLines (lexiconFile);
		
		Gtk.TextBuffer mainBuffer;
		mainBuffer = textviewMain.Buffer;
		
		lexiconItems = "";
	 	foreach (string lexiconEntry in lexiconData)
			{
				lexiconItems = lexiconItems + lexiconEntry + "\n";
			}
		mainBuffer.Text = lexiconItems;
	} */
	
	protected void gettingStartedDialogShow (object sender, System.EventArgs e)
	{
		GetStartedDialog GetStarted = new GetStartedDialog ();
		GetStarted.Run ();
		GetStarted.Destroy ();
	}

	 protected void showConfigDialog (object sender, System.EventArgs e)
	{
		ConfigurationDialog Configure = new ConfigurationDialog ();
		Configure.Run ();
		Configure.Destroy ();
	}

	protected void showLogicalModeller (object sender, System.EventArgs e)
	{
		LogicalModellerDialog LogicalModeller = new LogicalModellerDialog ();
		LogicalModeller.Run ();
		LogicalModeller.Destroy ();
	}
	
}