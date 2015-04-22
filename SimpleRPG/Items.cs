using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace SimpleRPG
{
	/// <summary>
	/// Loading items into game
	/// </summary>
	public class Items
	{
		/*
		 * GUID System
		 * 4 numbers long
		 * 0000
		 * 1000 first number is a catagoery
		 * 1 = Armor_Helmet
		 * 2 = Armor_Chest
		 * 3 = Armor_Legs
		 * 4 = Weapons_Sword
		 * 5 = Weapons_Staff
		 * 6 = Weapons_Dagger
		 * 7 = Abilities_Warrior
		 * 8 = Abilities_Mage
		 * 9 = Abilities_Rogue
		 * the last 3 are the items in that category
		 * EX: 1000 First entry in Armor_Helmet
		 * EX: 5002 Second entry in Weapons_Staff
		 *
		 */
		
		public static DataTable Get_Armor_Helmet()
		{
			DataTable Armor_Helmet = new DataTable();
			
			Armor_Helmet.Columns.Add("ID", typeof(int));
			Armor_Helmet.Columns.Add("Name", typeof(string));
			Armor_Helmet.Columns.Add("Type", typeof(string));
			
			Armor_Helmet.Rows.Add(1001, "Helmet_1001", "Test_Armor_Helmet");
			Armor_Helmet.Rows.Add(1002, "Helmet_1002", "Test_Armor_Helmet2");
			
			return Armor_Helmet;
		}
		
		public static DataTable Get_Armor_Chest()
		{
			DataTable Armor_Chest = new DataTable();
			
			Armor_Chest.Columns.Add("ID", typeof(int));
			Armor_Chest.Columns.Add("Name", typeof(string));
			Armor_Chest.Columns.Add("Type", typeof(string));
			
			Armor_Chest.Rows.Add(2001, "Chest_2001", "Test_Armor_Chest");
			
			return Armor_Chest;
		}
		
		public static DataTable Get_Armor_Legs()
		{
			DataTable Armor_Legs = new DataTable();
			
			Armor_Legs.Columns.Add("ID", typeof(int));
			Armor_Legs.Columns.Add("Name", typeof(string));
			Armor_Legs.Columns.Add("Type", typeof(string));
			
			Armor_Legs.Rows.Add(3001, "Legs_3001", "Test_Armor_Legs");
			
			return Armor_Legs;
		}
		
		public static DataTable Get_Weapon_Sword()
		{
			DataTable Weapon_Sword = new DataTable();
			
			Weapon_Sword.Columns.Add("ID", typeof(int));
			Weapon_Sword.Columns.Add("Name", typeof(string));
			
			Weapon_Sword.Rows.Add(4001, "Test_Weapons_Sword");
			
			return Weapon_Sword;
		}
		
		public static DataTable Get_Weapon_Staff()
		{
			DataTable Weapon_Staff = new DataTable();
			
			Weapon_Staff.Columns.Add("ID", typeof(int));
			Weapon_Staff.Columns.Add("Name", typeof(string));
			
			Weapon_Staff.Rows.Add(5001, "Test_Weapons_Staff");
			
			return Weapon_Staff;
		}
		
		public static DataTable Get_Weapon_Dagger()
		{
			DataTable Weapon_Dagger = new DataTable();
			
			Weapon_Dagger.Columns.Add("ID", typeof(int));
			Weapon_Dagger.Columns.Add("Name", typeof(string));
			
			Weapon_Dagger.Rows.Add(6001, "Test_Weapons_Dagger");
			
			return Weapon_Dagger;
		}
		
		public static DataTable Get_Abilities_Warrior()
		{
			DataTable Abilities_Warrior = new DataTable();
			
			Abilities_Warrior.Columns.Add("ID", typeof(int));
			Abilities_Warrior.Columns.Add("Name", typeof(string));
			
			Abilities_Warrior.Rows.Add(7001, "Test_Abilities_Warrior");
			
			return Abilities_Warrior;
		}
		
		public static DataTable Get_Abilities_Mage()
		{
			DataTable Abilities_Mage = new DataTable();
			
			Abilities_Mage.Columns.Add("ID", typeof(int));
			Abilities_Mage.Columns.Add("Name", typeof(string));
			
			Abilities_Mage.Rows.Add(8001, "Test_Abilities_Mage");
			
			return Abilities_Mage;
		}
		
		public static DataTable Get_Abilities_Rogue()
		{
			DataTable Abilities_Rogue = new DataTable();
			
			Abilities_Rogue.Columns.Add("ID", typeof(int));
			Abilities_Rogue.Columns.Add("Name", typeof(string));
			
			Abilities_Rogue.Rows.Add(9001, "Test_Abilities_Rogue");
			
			return Abilities_Rogue;
		}
		
		//Output ALL items onto screen
		public static void dumpAllItems()
		{
			MainForm.mainform.outputBox.AppendText("Dumping all items...\n");
			MainForm.mainform.outputBox.AppendText("ID                     Name                     Type           \n");
			DataTable Armor_Helmet = Get_Armor_Helmet();
			DataTable Armor_Chest = Get_Armor_Chest();
			DataTable Armor_Legs = Get_Armor_Legs();
			DataTable Weapon_Sword = Get_Weapon_Sword();
			DataTable Weapon_Staff = Get_Weapon_Staff();
			DataTable Weapon_Dagger = Get_Weapon_Dagger();
			DataTable Abilities_Warrior = Get_Abilities_Warrior();
			DataTable Abilities_Mage = Get_Abilities_Mage();
			DataTable Abilities_Rogue = Get_Abilities_Rogue();
			
			//Armor_Helmet
			foreach(DataRow row in Armor_Helmet.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
			}
			
			//Armor_Chest
			foreach(DataRow row in Armor_Chest.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
			}
			
			//Armor_Legs
			foreach(DataRow row in Armor_Legs.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
			}
			
			//Weapon_Sword
			foreach(DataRow row in Weapon_Sword.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
			
			//Weapon_Staff
			foreach(DataRow row in Weapon_Staff.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
			
			//Weapon_Dagger
			foreach(DataRow row in Weapon_Dagger.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
			
			//Abilities_Warrior
			foreach(DataRow row in Abilities_Warrior.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
			
			//Abilities_Mage
			foreach(DataRow row in Abilities_Mage.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
			
			//Abilities_Rogue
			foreach(DataRow row in Abilities_Rogue.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
			}
		}
		
		//Output items from given datatable to screen
		public static void dumpItems(string str)
		{
			MainForm.mainform.outputBox.AppendText("ID                     Name                     Type           \n");
			switch(str) //Get which table to dump
			{
				case "Armor_Helmet":
					DataTable Armor_Helmet = Get_Armor_Helmet();
					foreach(DataRow row in Armor_Helmet.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
					}
					break;
					
				case "Armor_Chest":
					DataTable Armor_Chest = Get_Armor_Chest();
					foreach(DataRow row in Armor_Chest.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
					}
					break;
					
				case "Armor_Legs":
					DataTable Armor_Legs = Get_Armor_Legs();
					foreach(DataRow row in Armor_Legs.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Sword":
					DataTable Weapon_Sword = Get_Weapon_Sword();
					foreach(DataRow row in Weapon_Sword.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Staff":
					DataTable Weapon_Staff = Get_Weapon_Staff();
					foreach(DataRow row in Weapon_Staff.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Dagger":
					DataTable Weapon_Dagger = Get_Weapon_Dagger();
					foreach(DataRow row in Weapon_Dagger.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Warrior":
					DataTable Abilities_Warrior = Get_Abilities_Warrior();
					foreach(DataRow row in Abilities_Warrior.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Mage":
					DataTable Abilities_Mage = Get_Abilities_Mage();
					foreach(DataRow row in Abilities_Mage.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Rogue":
					DataTable Abilities_Rogue = Get_Abilities_Rogue();
					foreach(DataRow row in Abilities_Rogue.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\n");
					}
					break;
			}
		}
	}
}
