using System;
using Gtk;

namespace workflow
{
	public partial class LexiconDialog : Gtk.Dialog
	{
		public LexiconDialog ()
		{
			this.Build ();
		}

		protected void LexiconItemSelected (object sender, System.EventArgs e)
		{
			Gtk.TextBuffer buffer;
			buffer = textviewLexiconDialog.Buffer;
			
			buffer.Text = workflow.MainClass.lexiconData[comboboxLexiconDialog.Active];

		}
		
	}
}

