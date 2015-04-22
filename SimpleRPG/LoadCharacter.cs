using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;

namespace SimpleRPG
{
	/// <summary>
	/// Load a character
	/// </summary>
	public partial class LoadCharacter : Form
	{
		public static BindingList<string> charactersNames = new BindingList<string>(); //List of characters found
		
		public LoadCharacter()
		{
			InitializeComponent();
		}
		
		void LoadCharacterLoad(object sender, EventArgs e)
		{
			selectCharacter(); //Start selectCharacte method
			charactersListBox.DataSource = charactersNames; //Set listbox datasource to charactersNames list
		}
		
		//Select character to load
		public static void selectCharacter()
		{
			using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Startup.globalDatabasePath + ";Version=3;"))
			{
				conn.Open(); //Open the connection
				
				using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Characters", conn))
				{
					using (SQLiteDataReader rdr = cmd.ExecuteReader())
					{
						while(rdr.Read())
						{
							if(!charactersNames.Contains(rdr["Name"].ToString())) //If name isn't already in listbox
							{
								charactersNames.Add(rdr["Name"].ToString()); //Add Names found to textbox
							}
						}
					}
				}
				conn.Close(); //Close connection
			}
		}
		
		void CharacterLoadbtnClick(object sender, EventArgs e)
		{
			string characterName = charactersListBox.SelectedItem.ToString(); //Make character to load's name string
			if(characterName == "") //Check character isn't null
			{
				MessageBox.Show("No character selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Startup.globalDatabasePath + ";Version=3;"))
			{
				conn.Open(); //Open connection
				
				using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Characters WHERE Name=@Name", conn))
				{
					cmd.Parameters.AddWithValue("@Name", characterName); //Add name value
					
					using (SQLiteDataReader rdr = cmd.ExecuteReader())
					{
						while(rdr.Read())
						{
							//Fill in Mainform.mainPlayer class with player info
							MainForm.mainPlayer.Name = rdr["Name"].ToString();
							MainForm.mainPlayer.Race = rdr["Race"].ToString();
							MainForm.mainPlayer.Class = rdr["Class"].ToString();
							MainForm.mainPlayer.Level = Convert.ToInt32(rdr["Level"]);
							MainForm.mainPlayer.XP = Convert.ToInt32(rdr["XP"]);
							MainForm.mainPlayer.Gold = Convert.ToInt32(rdr["Gold"]);
							MainForm.mainPlayer.Health = Convert.ToInt32(rdr["Health"]);
							MainForm.mainPlayer.Mana = Convert.ToInt32(rdr["Mana"]);
							MainForm.mainPlayer.Strength = Convert.ToInt32(rdr["Strength"]);
							MainForm.mainPlayer.Intellect = Convert.ToInt32(rdr["Intellect"]);
							MainForm.mainPlayer.Defence = Convert.ToInt32(rdr["Defence"]);
							MainForm.mainPlayer.Agility = Convert.ToInt32(rdr["Agility"]);
							MainForm.mainPlayer.Inventory = rdr["Inventory"].ToString();
							
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
							
							string playerInv = rdr["Inventory"].ToString(); //Player inventory in string
							string[] playerInvItems = playerInv.Split(';'); //Split into easier to deal with bits
							foreach(string item in playerInvItems) //Put every item into player inventory list
							{
								if(!string.IsNullOrEmpty(item) && !string.IsNullOrWhiteSpace(item))
								{
									MainForm.playerInventory.Add(item);
								}
							}
							MainForm.mainform.playerInventorylistbox.DataSource = MainForm.playerInventory;
							
							MainForm.characterLoaded = true; //Set characterloaded to true
						}
					}
				}
			}
			
			//Everything is set, ask if player wants to load selected character
			DialogResult loadcharactercheck = MessageBox.Show("Are you sure you want to load this character?", "Load this character?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (loadcharactercheck == DialogResult.Yes) //If they want to load the selected character
			{
				this.Close(); //We won't need it again, so close it
			}
		}
		
		void DelbtnClick(object sender, EventArgs e)
		{
			string charactertodelete = charactersListBox.SelectedItem.ToString();
			
			if(charactertodelete == "") //Check character isn't null
			{
				MessageBox.Show("No character selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			DialogResult result = MessageBox.Show("Do you really want to delete " + charactertodelete + " ?", "Are your sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes) //Check that they really want to delete the character
			{
				using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Startup.globalDatabasePath + ";Version=3;"))
				{
					conn.Open(); //Open the connection
					using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Characters WHERE Name=@Name", conn))
					{
						cmd.Parameters.AddWithValue("@Name", charactertodelete); //Add name value to command
						cmd.ExecuteNonQuery(); //Execute command
					}
					conn.Close(); //Close the connection
				}
				//Refresh list
				charactersNames.Remove(charactertodelete); //Delete selected character
				selectCharacter(); //Get the names
			}
		}
		
		void BackbtnClick(object sender, EventArgs e)
		{
			this.Close(); //Hide this form
		}
	}
}
