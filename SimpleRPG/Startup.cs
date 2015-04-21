using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SimpleRPG
{
	/// <summary>
	/// Startup
	/// </summary>
	public class Startup
	{
		public static string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); //Appdata folder
		public static string appdataGamePath = Path.Combine(appdataPath, "SimpleRPG");
		public static string globalDatabasePath = Startup.appdataGamePath + "\\Database.sqlite"; //Global database path
		public static string helptxtdir = Startup.appdataGamePath + "cmdhelp.txt"; //Global helpfile
		
		public static void Check()
		{
			//Check if appdata folder exist
			if(!Directory.Exists(appdataGamePath))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SimpleRPG");
			}
			
			//Setup database
			if(!File.Exists(Startup.appdataGamePath + "\\Database.sqlite")) //Exist
			{
				SQLiteConnection.CreateFile(Startup.appdataGamePath + "\\Database.sqlite"); //Create database
				
				//Setup Characters table
				using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + globalDatabasePath + ";Version=3;")) //Sqlite connection
				{
					conn.Open(); //Open connection
					
					string sql = ("CREATE TABLE Characters (" +
					              "Name TEXT, " +
					              "Race TEXT, " +
					              "Class TEXT, " +
					              "Level INT, " +
					              "XP INT, " +
					              "Gold INT, " +
					              "Health INT, " +
					              "Mana INT, " +
					              "Strength INT, " +
					              "Intellect INT, " +
					              "Defence INT, " +
					              "Agility INT, " +
					              "Inventory TEXT)");
					
					using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
					{
						cmd.ExecuteNonQuery(); //Execute command
					}
					conn.Close(); //Close connection
				}
			}
		}
	}
}
