using System;
using System.Collections;
using System.Windows.Forms;
using System.Text;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace SimpleRPG
{
	/// <summary>
	/// Create a character
	/// </summary>
	public class CreateCharacter
	{
		public static Player newPlayer = new Player(); //Make new instance of player
		
		//Get params for character to create then create it
		public static void Create(string playerName, string playerRace, string playerClass)
		{
			MainForm.mainform.inputBox.Enabled = false; //Disable inputbox on mainform while createing character just incase
			MainForm.mainform.outputBox.AppendText("Please wait... creating character!\n"); //Let user know that the character is being created
			
			Debug.WriteLine("Name: " + playerName); //Write name to debug
			Debug.WriteLine("Race: " + playerRace); //Write race to debug
			Debug.WriteLine("Class: " + playerClass); //Write class to debug
			
			//Setup character
			newPlayer.Name = playerName; //Player name
			newPlayer.Race = playerRace; //Player race
			newPlayer.Class = playerClass; //Player class
			newPlayer.Health = 100; //Player health
			newPlayer.Level = 1; //Player level
			newPlayer.XP = 0; //Player xp
			newPlayer.Mana = 100; //Player mana
			newPlayer.Gold = 0; //Player gold
			
			switch(playerRace) //Give racial bonuses
			{
				case "Human": //+2 Defence and Strength
					newPlayer.Defence = 2;
					newPlayer.Strength = 2;
					newPlayer.Intellect = 0;
					newPlayer.Agility = 0;
					break; //break
					
					
				case "Dwarf": //+2 Intellect
					newPlayer.Intellect = 2;
					newPlayer.Defence = 0;
					newPlayer.Strength = 0;
					newPlayer.Agility = 0;
					break; //break
					
				case "Elf": //+2 Agility and Intellect
					newPlayer.Agility = 2;
					newPlayer.Intellect = 2;
					newPlayer.Defence = 0;
					newPlayer.Strength = 0;
					break; //break
					
				default:
					MessageBox.Show("You shouldn't be here and I don't know how you got here...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break; //break
			}
			
			using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Startup.globalDatabasePath + ";Version=3;"))
			{
				conn.Open(); //Open connection
				
				using (SQLiteCommand insertPlayer = new SQLiteCommand("INSERT INTO Characters(Name, Race, Class, Level, XP, Gold, Health, Mana, Strength, Intellect, Defence, Agility, Inventory) VALUES (@Name, @Race, @Class, @Level, @XP, @Gold, @Health, @Mana, @Strength, @Intellect, @Defence, @Agility, @Inventory)", conn))
				{
					insertPlayer.Parameters.AddWithValue("@Name", newPlayer.Name); 		 	 //Add Name value
					insertPlayer.Parameters.AddWithValue("@Race", newPlayer.Race); 			 //Add Race value
					insertPlayer.Parameters.AddWithValue("@Class", newPlayer.Class); 		 //Add Class value
					insertPlayer.Parameters.AddWithValue("@Level", newPlayer.Level); 		 //Add Level value
					insertPlayer.Parameters.AddWithValue("@XP", newPlayer.XP); 				 //Add XP value
					insertPlayer.Parameters.AddWithValue("@Gold", newPlayer.Gold);		     //Add Gold value
					insertPlayer.Parameters.AddWithValue("@Health", newPlayer.Health); 		 //Add Health value
					insertPlayer.Parameters.AddWithValue("@Mana", newPlayer.Mana); 		     //Add Mana value
					insertPlayer.Parameters.AddWithValue("@Strength", newPlayer.Strength);   //Add Strength value
					insertPlayer.Parameters.AddWithValue("@Intellect", newPlayer.Intellect); //Add Intellect value
					insertPlayer.Parameters.AddWithValue("@Defence", newPlayer.Defence);     //Add Defence value
					insertPlayer.Parameters.AddWithValue("@Agility", newPlayer.Agility);     //Add Agility value
					insertPlayer.Parameters.AddWithValue("@Inventory", newPlayer.Inventory); //Add Inventory value
					
					insertPlayer.ExecuteNonQuery(); //Execute command
				}
				conn.Close(); //Close connection
			}
			//Fill in Mainform.mainPlayer class with player info
			
			MainForm.mainPlayer.Name = newPlayer.Name;
			MainForm.mainPlayer.Race = newPlayer.Race;
			MainForm.mainPlayer.Class = newPlayer.Class;
			MainForm.mainPlayer.Level = newPlayer.Level;
			MainForm.mainPlayer.XP = newPlayer.XP;
			MainForm.mainPlayer.Gold = newPlayer.Gold;
			MainForm.mainPlayer.Health = newPlayer.Health;
			MainForm.mainPlayer.Mana = newPlayer.Mana;
			MainForm.mainPlayer.Strength = newPlayer.Strength;
			MainForm.mainPlayer.Intellect = newPlayer.Intellect;
			MainForm.mainPlayer.Defence = newPlayer.Defence;
			MainForm.mainPlayer.Agility = newPlayer.Agility;
			MainForm.mainPlayer.Inventory = newPlayer.Inventory;
			
			//Fill in the statbox in mainform
			MainForm.mainform.playerStatsgroupbox.Text = MainForm.mainPlayer.Name;
			MainForm.mainform.playerRacelbl.Text = "Race: " + MainForm.mainPlayer.Race;
			MainForm.mainform.playerClasslbl.Text = "Class: " + MainForm.mainPlayer.Class;
			MainForm.mainform.playerHealthlbl.Text = "Health: " + Convert.ToInt32(MainForm.mainPlayer.Health).ToString();
			MainForm.mainform.playerManalbl.Text = "Mana: " + Convert.ToInt32(MainForm.mainPlayer.Mana).ToString();
			MainForm.mainform.playerLevellbl.Text = "Level: " + Convert.ToInt32(MainForm.mainPlayer.Level).ToString();
			MainForm.mainform.playerXPlbl.Text = "XP: " + Convert.ToInt32(MainForm.mainPlayer.XP).ToString();
			MainForm.mainform.playerStrengthlbl.Text = "Strength: " + Convert.ToInt32(MainForm.mainPlayer.Strength).ToString();
			MainForm.mainform.playerIntellectlbl.Text = "Intellect: " + Convert.ToInt32(MainForm.mainPlayer.Intellect).ToString();
			MainForm.mainform.playerDefencelbl.Text = "Defence: " + Convert.ToInt32(MainForm.mainPlayer.Defence).ToString();
			MainForm.mainform.playerAgilitylbl.Text = "Agility: " + Convert.ToInt32(MainForm.mainPlayer.Agility).ToString();
			MainForm.mainform.playerGoldlbl.Text = "Gold: " + Convert.ToInt32(MainForm.mainPlayer.Gold).ToString();
			
			MainForm.characterLoaded = true; //Set characterloaded to true
			
		}
	}
}
