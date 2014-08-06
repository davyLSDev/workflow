using System;
using Gtk;
using GLib;

namespace workflow
{
	public partial class LogicalModellerDialog : Gtk.Dialog
	{
		public LogicalModellerDialog ()
		{
			this.Build ();
		// this next bit doesn't appear to do anything!
			Gdk.Color frameColour = new Gdk.Color (255, 0, 0);			
		//LogicalModeller.ModifyBg (StateType.Normal, frameColour);
			frame1.ModifyBg (StateType.Normal , frameColour);
			frame2.ModifyBg (StateType.Normal , frameColour);
			frame3.ModifyBg (StateType.Normal , frameColour);
		}

		protected void showPlanningCalendarDialog (object sender, System.EventArgs e)
		{
			PlanningCalendarDialog planningCalendar = new PlanningCalendarDialog ();
			planningCalendar.Run ();
			planningCalendar.Destroy ();
		}
	}
}

