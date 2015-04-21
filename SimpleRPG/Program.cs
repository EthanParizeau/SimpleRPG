/*
 * User: parizeau15881
 * Date: 4/13/2015
 * Time: 7:42 AM
 */
using System;
using System.Windows.Forms;

namespace SimpleRPG
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
