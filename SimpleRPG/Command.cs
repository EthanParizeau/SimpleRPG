using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace SimpleRPG
{
	/// <summary>
	/// Class for the commands
	/// </summary>
	public class Command //Class for all commands
	{
		
		public static void getCommand(string cmd) //Method to get command before sorting
		{
			//Check if command is a debug command
			if(cmd.StartsWith("dbug.")) //Debug command
			{
				switch(cmd) //Switch to select the right debug command to use
				{
					case "dbug.dump.items.all": //Dump all items in items databases
						Items.dumpAllItems();
						break;
						
					case "dbug.color.test": //Test the colors
						foreach(Color color in new ColorConverter().GetStandardValues())
						{
							MainForm.mainform.outputBox.SelectionColor = color;
							MainForm.mainform.outputBox.AppendText(color.ToString() + "\n");
							MainForm.mainform.outputBox.ScrollToCaret();
						}
						break;
						
					default:
						MainForm.mainform.outputBox.SelectionColor = Color.Red;
						MainForm.mainform.outputBox.AppendText("Error! Unknown command " + cmd + "\n");
						MainForm.mainform.outputBox.SelectionColor = Color.White;
						MainForm.mainform.outputBox.AppendText("Type \"Help\" for a list of commands.");
						break;
				}
			}
			else //Normal command
			{
				switch(cmd.ToLower()) //Switch to select the right command to use
				{
					
					case "game.exit": //Exit the application with exit code 0
						Environment.Exit(0);
						break;
					case "cmdhelp": //Prints the list of commands
						MainForm.mainform.outputBox.AppendText("\n");
						try
						{
							using (StreamReader sr = new StreamReader("cmdlist.txt"))
							{
								string cmdlist = sr.ReadToEnd();
								MainForm.mainform.outputBox.AppendText(cmdlist + "\n");
							}
						}
						catch (Exception e)
						{
							MainForm.mainform.outputBox.SelectionColor = Color.Red;
							MainForm.mainform.outputBox.AppendText("Error > " + e.ToString());
							MainForm.mainform.outputBox.SelectionColor = Color.White;
						}
						break;
						
					case "help": //Print the help
						MainForm.mainform.outputBox.AppendText("\n");
						try
						{
							using (StreamReader sr = new StreamReader("help.txt"))
							{
								string line = sr.ReadToEnd();
								MainForm.mainform.outputBox.AppendText(line + "\n");
							}
						}
						catch (Exception e)
						{
							MainForm.mainform.outputBox.SelectionColor = Color.Red;
							MainForm.mainform.outputBox.AppendText("Error > " + e.ToString());
							MainForm.mainform.outputBox.SelectionColor = Color.White;
						}
						break;
						
					case "clear": //Clears the screen
						MainForm.mainform.outputBox.Clear();
						break;
						
					default:
						MainForm.mainform.outputBox.SelectionColor = Color.Red;
						MainForm.mainform.outputBox.AppendText("Error! Unknown command " + cmd + "\n");
						MainForm.mainform.outputBox.SelectionColor = Color.White;
						MainForm.mainform.outputBox.AppendText("Type \"help\" for a list of commands.\n");
						break;
				}
			}
		}
	}
	
}
