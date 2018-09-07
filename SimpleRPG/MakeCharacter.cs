using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.Collections.Generic;

namespace SimpleRPG
{
	/// <summary>
	/// Setup character
	/// </summary>
	public partial class MakeCharacter : Form
	{
		bool nameok, raceok, classok = false;
		
		public MakeCharacter()
		{
			InitializeComponent();
		}
		
		//On load
		void MakeCharacterLoad(object sender, EventArgs e)
		{
			
		}
		
		//When selection changed show information about the race in the racedesctextbox
		void RaceComboboxSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (raceCombobox.Text) //Switch for the race selected
			{
				case "Human":
					//If Human is selected
					raceDesctxtbox.Clear(); //Clear default text
					raceDesctxtbox.AppendText("Description: The Humans are a noble race they fight for honor and to protect there kingdom.\n\n"); //Append Human description
					raceDesctxtbox.AppendText("Racial Bonus: +2 Strength and Defence.\n\n"); //Append Human racials
					raceDesctxtbox.AppendText("Classes: Warrior, Rogue\n\n"); // Append Human classes
					
					break; //Break
					
				case "Dwarf":
					//If Dwarf is selected
					raceDesctxtbox.Clear(); //Clear default text
					raceDesctxtbox.AppendText("Description: The Dwarfs are a hard working and dependant race, they never back down from a fight.\n\n"); //Append Dwarf description
					raceDesctxtbox.AppendText("Racial Bonus: +2 Intellect.\n\n"); //Append Dwarf racials
					raceDesctxtbox.AppendText("Classes: Warrior, Mage\n\n"); //Append Dwarf classess
					
					break; //Break
					
				case "Elf":
					//If Elf is selected
					raceDesctxtbox.Clear(); //Clear default text
					raceDesctxtbox.AppendText("Description: The Elfs are a hidden race, they live in the shadows.\n\n"); //Append Elf description
					raceDesctxtbox.AppendText("Racial Bonus: +2 Agility and Intellect.\n\n"); //Append Elf racials
					raceDesctxtbox.AppendText("Classes: Mage, Rogue\n\n"); //Append Elf classes
					
					break; //Break
					
				default:
					//If somehow you got default
					MessageBox.Show("Not even sure how you got here but close the game of the world might explode!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}
		}
		//When selection changed show information about the class in classdesctextbox
		void ClassComboboxSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (classCombobox.Text) //Switch for the class selected
			{
				case "Warrior":
					//If Warrior selected
					classDesctxtbox.Clear(); // Clear default text
					classDesctxtbox.AppendText("Description: Melee class, highest defence.\n\n"); //Append Warrior description
					classDesctxtbox.AppendText("Armor: Heavy Armor\n"); //Append Warrior armor
					classDesctxtbox.AppendText("Weapon: Sword\n"); //Append Warrior weapon
					classDesctxtbox.AppendText("Skills: Slash, Stab, Knockback\n"); //Append Warrior skills
					
					break; //Break
					
				case "Mage":
					//If Mage selected
					classDesctxtbox.Clear(); //Clear default text
					classDesctxtbox.AppendText("Description: Ranged class, highest intellect.\n\n"); //Append Mage description
					classDesctxtbox.AppendText("Armor: Light Armor\n"); //Append Mage armor
					classDesctxtbox.AppendText("Weapon: Staff or Dagger\n"); //Append Mage weapon
					classDesctxtbox.AppendText("Skills: Firebolt, Arcane Peirce\n"); //Append Mage skills
					
					break; //Break
					
				case "Rogue":
					//If Rogue selected
					classDesctxtbox.Clear(); //Clear default text
					classDesctxtbox.AppendText("Description: Assassian, unseen, highest agility.\n\n"); //Append Rogue description
					classDesctxtbox.AppendText("Armor: Light Armor\n"); //Append Rogue armor
					classDesctxtbox.AppendText("Weapon: Dagger\n"); //Append Rogue weapon
					classDesctxtbox.AppendText("Skills: Backstab, Trip"); // Append Rogue skills
					
					break; //Break

                case "Druid":
                    //If Druid selected
                    classDesctxtbox.Clear(); //clear default
                    classDesctxtbox.AppendText("Description: Earthern warrior that uses nature to deafeat their enemies or heal their friends on the battlefield.\n");
                    classDesctxtbox.AppendText("Armor:Medium Armor\n");
                    classDesctxtbox.AppendText("Weapon: Staff or Sword and Shield\n");
                    classDesctxtbox.AppendText("Skills: Healing Touch, Earth's Wrath\n");

                    break; //Break
                    


                default:
					//If somehow you got default
					MessageBox.Show("Not even sure how you got here but close the game or the world might explode!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}
		}
		
		//Button clicked
		void CreatebtnClick(object sender, EventArgs e)
		{
			//Check that everything is filled in correctly
			
			if(characterNametxtbox.Text == "") //Check that name is filled in
			{
				MessageBox.Show("Name is blank.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
			//Check that name isn't taken
			using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Startup.globalDatabasePath + ";Version=3;"))
			{
				conn.Open(); //Open connection
				using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Characters WHERE Name=@Name", conn))
				{
					cmd.Parameters.AddWithValue("@Name", characterNametxtbox.Text); //Add name value
					int usercount = Convert.ToInt32(cmd.ExecuteScalar()); //Count the names that match, should never be more than 1
					if(usercount == 0)
					{
						nameok = true; //nameok is true
					}
					else
					{
						MessageBox.Show("The name " + "\"" + characterNametxtbox.Text + "\" is taken, choose a different name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				conn.Close(); //Close the connection
			}

			if(raceCombobox.Text == "Human") //Human
			{
				if(classCombobox.Text != "Mage") //If not mage
				{
					raceok = true; //Race ok
					classok = true; //Class ok
				}
				else // If Mage
				{
					//Human can't be Nage, show error
					MessageBox.Show("Human can't be Mage, change your race or class.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show error messagebox
				}
			}
			
			if(raceCombobox.Text == "Dwarf") //Dwarf
			{
				if(classCombobox.Text != "Rogue") //If not Rogue
				{
					raceok = true; //Race ok
					classok = true; //Class ok
				}
				else //If Rogue
				{
					//Dwarf can't be Rogue, show error
					MessageBox.Show("Dwarf can't be Rogue, change your race or class.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show error message
				}
			}
			
			if(raceCombobox.Text == "Elf") //Elf
			{
				if(classCombobox.Text != "Warrior") //If not Warrior
				{
					raceok = true; //Race ok
					classok = true; //Class ok
				}
				else //If Warrior
				{
					//Elf can't be Warrior, show error
					MessageBox.Show("Elf can't be Warrior, change your race or class.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show error message
				}
			}
			
			Debug.WriteLine("----------\nNameok = " + nameok + "\nRaceok = " + raceok + "\nClassok = " + classok + "\n----------");
			
			//Everything is ok with the character, start to create it
			if( nameok == true && raceok == true && classok == true)
			{
				CreateCharacter.Create(characterNametxtbox.Text, raceCombobox.Text, classCombobox.Text); //Send character data to CreateCharacter to be created
				this.Close(); //Close this form, we wont need it again or at least anytime soon
				MessageBox.Show("Creating character!", "Creating character!", MessageBoxButtons.OK); //Show message
			}
		}
		
		void BackbtnClick(object sender, EventArgs e)
		{
			this.Close(); //Hide this form
		}
	}
}
