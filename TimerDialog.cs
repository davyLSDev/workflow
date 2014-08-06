using System;
using Gtk;
using GLib;

namespace workflow
{
	public partial class TimerDialog : Gtk.Dialog
	{
		static string timerMessage;
		static bool theTimerIsStopwatch;
		static bool timerPause;
		static bool timesUp;
		static int timerSeconds;
		static int timerTargetSeconds;
		
		public TimerDialog ()
		{
			this.Build ();
			InitializeTimer ();
		}
		
		public void InitializeTimer ()
		{
			GLib.Timeout.Add(1000, new GLib.TimeoutHandler(update_timer));
			timerSeconds = 0;
			timesUp = false;
			timerPause = true;
			theTimerIsStopwatch = true;
			getTimerDigits ();
			Pango.FontDescription fontDescription = Pango.FontDescription.FromString("Roman 48");
			TimerEntry.ModifyFont ( fontDescription );
			UpdateTimerDisplay ();
		}
		
		bool update_timer ()
		{
		// entryStatusBarLeft.Text=DateTime.Now.ToString ();
		
		if (timerPause == false) {
		
			if (theTimerIsStopwatch == true) {
				timerSeconds++;
			
				if (timerSeconds == timerTargetSeconds) {
					timesUp = true;
				}
			}
			else { 
				timerSeconds--;
				if (timerSeconds == 0) {
					timesUp = true;
				}
			}
				
			if (timesUp == true) {
				stopTimer();
				timerMessage = "Time's up!";
	
				TimerDialog timeDone = new TimerDialog ();
				timeDone.Run ();
				timeDone.Destroy ();
			
			}
			else {
				timerMessage = string.Format("{0:00}:{1:00}:{2:00}",timerSeconds/3600,
		                             (timerSeconds/60)%60,
		                             timerSeconds%60);		
			}
			UpdateTimerDisplay ();				
		}		
		return true;
		}

		protected void UpdateTimerDisplay ()
		{
		TimerEntry.Text = timerMessage;
		}	
		
		protected void resetTimer (object sender, System.EventArgs e)
		{
			timerSeconds = 0;
			timesUp = false;
			getTimerDigits ();
		}
		
		
		protected void stopwatchSelected (object sender, System.EventArgs e)
		{
			timerSeconds = 0;
			theTimerIsStopwatch = true;
		}
		
		
		protected void countdownSelected (object sender, System.EventArgs e)
		{
			timerSeconds = timerTargetSeconds;
			theTimerIsStopwatch = false;
		}
		
		protected void getTimerDigits()
		{
		timerTargetSeconds = (int)spinbuttonHours.Value * 3600 +
			(int)spinbuttonMinutes.Value * 60 +
			(int)spinbuttonSeconds.Value;
		timerMessage = string.Format("{0:00}:{1:00}:{2:00}",timerTargetSeconds/3600,
		                             (timerTargetSeconds/60)%60,
		                             timerTargetSeconds%60);
		
		if (theTimerIsStopwatch == true) {
			timerSeconds = 0;
		}
		else {
			timerSeconds = timerTargetSeconds;
		}
		UpdateTimerDisplay ();
		}	

		protected void PauseToggle (object sender, System.EventArgs e)
		{
			if (timerPause == true)
				timerPause = false;
			else {
				timerPause = true;
			}
		}
				
		protected void setTimer (object sender, System.EventArgs e)
		{
			timesUp = false;
			getTimerDigits ();
		}
		
		protected void stopTimer ()
		{
			timerSeconds = 0;
			timerPause = true;
		}
		
	}
}

