using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRPG
{
	/// <summary>
	/// Settings
	/// </summary>
	public partial class Settings : Form
	{
		public Settings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ClosebtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
						
		}
	}
}
