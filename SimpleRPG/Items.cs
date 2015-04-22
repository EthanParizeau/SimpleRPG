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
			Armor_Helmet.Columns.Add("Desc", typeof(string));
			Armor_Helmet.Columns.Add("PlayerEffect", typeof(string));
			Armor_Helmet.Columns.Add("EnemyEffect", typeof(string));
			
			Armor_Helmet.Rows.Add(1001, "Helmet_1001", "Test_Armor_Helmet", "Testing", "Testing", "Testing");
			Armor_Helmet.Rows.Add(1002, "Leather cowl", "Medium", "A leather cowl.", "", "");
			Armor_Helmet.Rows.Add(1003, "Cloth hood", "Light", "A cloth hood.", "", "");
			
			return Armor_Helmet;
		}
		
		public static DataTable Get_Armor_Chest()
		{
			DataTable Armor_Chest = new DataTable();
			
			Armor_Chest.Columns.Add("ID", typeof(int));
			Armor_Chest.Columns.Add("Name", typeof(string));
			Armor_Chest.Columns.Add("Type", typeof(string));
			Armor_Chest.Columns.Add("Desc", typeof(string));
			Armor_Chest.Columns.Add("PlayerEffect", typeof(string));
			Armor_Chest.Columns.Add("EnemyEffect", typeof(string));
			
			Armor_Chest.Rows.Add(2001, "Chest_2001", "Test_Armor_Chest", "Testing", "Testing", "Testing");
			Armor_Chest.Rows.Add(2002, "Leather shirt", "Medium", "A leather shirt.", "", "");
			Armor_Chest.Rows.Add(2003, "Cloth shirt", "Light", "A cloth shirt.", "", "");
			
			return Armor_Chest;
		}
		
		public static DataTable Get_Armor_Legs()
		{
			DataTable Armor_Legs = new DataTable();
			
			Armor_Legs.Columns.Add("ID", typeof(int));
			Armor_Legs.Columns.Add("Name", typeof(string));
			Armor_Legs.Columns.Add("Type", typeof(string));
			Armor_Legs.Columns.Add("Desc", typeof(string));
			Armor_Legs.Columns.Add("PlayerEffect", typeof(string));
			Armor_Legs.Columns.Add("EnemyEffect", typeof(string));
			
			Armor_Legs.Rows.Add(3001, "Legs_3001", "Test_Armor_Legs", "Testing", "Testing", "Testing");
			Armor_Legs.Rows.Add(3002, "Leather pants", "Medium", "A pair of leather pants.", "", "");
			Armor_Legs.Rows.Add(3003, "Cloth pants", "Light", "A pair of cloth pants.", "", "");
			
			return Armor_Legs;
		}
		
		public static DataTable Get_Weapon_Sword()
		{
			DataTable Weapon_Sword = new DataTable();
			
			Weapon_Sword.Columns.Add("ID", typeof(int));
			Weapon_Sword.Columns.Add("Name", typeof(string));
			Weapon_Sword.Columns.Add("Desc", typeof(string));
			Weapon_Sword.Columns.Add("PlayerEffect", typeof(string));
			Weapon_Sword.Columns.Add("EnemyEffect", typeof(string));
			
			Weapon_Sword.Rows.Add(4001, "Test_Weapons_Sword", "Testing", "Testing", "Testing");
			Weapon_Sword.Rows.Add(4002, "Training sword", "A wooden training sword.", "", "");
			
			return Weapon_Sword;
		}
		
		public static DataTable Get_Weapon_Staff()
		{
			DataTable Weapon_Staff = new DataTable();
			
			Weapon_Staff.Columns.Add("ID", typeof(int));
			Weapon_Staff.Columns.Add("Name", typeof(string));
			Weapon_Staff.Columns.Add("Desc", typeof(string));
			Weapon_Staff.Columns.Add("PlayerEffect", typeof(string));
			Weapon_Staff.Columns.Add("EnemyEffect", typeof(string));
			
			Weapon_Staff.Rows.Add(5001, "Test_Weapons_Staff", "Testing", "Testing", "Testing");
			Weapon_Staff.Rows.Add(5002, "Oak staff", "An old Oak staff.", "", "");
			
			return Weapon_Staff;
		}
		
		public static DataTable Get_Weapon_Dagger()
		{
			DataTable Weapon_Dagger = new DataTable();
			
			Weapon_Dagger.Columns.Add("ID", typeof(int));
			Weapon_Dagger.Columns.Add("Name", typeof(string));
			Weapon_Dagger.Columns.Add("Desc", typeof(string));
			Weapon_Dagger.Columns.Add("PlayerEffect", typeof(string));
			Weapon_Dagger.Columns.Add("EnemyEffect", typeof(string));
			
			Weapon_Dagger.Rows.Add(6001, "Test_Weapons_Dagger", "Testing", "Testing", "Testing");
			Weapon_Dagger.Rows.Add(6002, "Skinning knife", "A skinning knife.", "", "");
			
			return Weapon_Dagger;
		}
		
		public static DataTable Get_Abilities_Warrior()
		{
			DataTable Abilities_Warrior = new DataTable();
			
			Abilities_Warrior.Columns.Add("ID", typeof(int));
			Abilities_Warrior.Columns.Add("Name", typeof(string));
			Abilities_Warrior.Columns.Add("Desc", typeof(string));
			Abilities_Warrior.Columns.Add("PlayerEffect", typeof(string));
			Abilities_Warrior.Columns.Add("EnemyEffect", typeof(string));
			
			Abilities_Warrior.Rows.Add(7001, "Test_Abilities_Warrior", "Testing", "Testing", "Testing");
			Abilities_Warrior.Rows.Add(7002, "Slash", "Slash at the enemy.", "", "Health-2;");
			
			return Abilities_Warrior;
		}
		
		public static DataTable Get_Abilities_Mage()
		{
			DataTable Abilities_Mage = new DataTable();
			
			Abilities_Mage.Columns.Add("ID", typeof(int));
			Abilities_Mage.Columns.Add("Name", typeof(string));
			Abilities_Mage.Columns.Add("Desc", typeof(string));
			Abilities_Mage.Columns.Add("PlayerEffect", typeof(string));
			Abilities_Mage.Columns.Add("EnemyEffect", typeof(string));
			
			Abilities_Mage.Rows.Add(8001, "Test_Abilities_Mage", "Testing", "Testing", "Testing");
			Abilities_Mage.Rows.Add(8002, "FireBolt", "Shoot a ball of fire at the enemy.", "", "Health-2;");
			
			return Abilities_Mage;
		}
		
		public static DataTable Get_Abilities_Rogue()
		{
			DataTable Abilities_Rogue = new DataTable();
			
			Abilities_Rogue.Columns.Add("ID", typeof(int));
			Abilities_Rogue.Columns.Add("Name", typeof(string));
			Abilities_Rogue.Columns.Add("Desc", typeof(string));
			Abilities_Rogue.Columns.Add("PlayerEffect", typeof(string));
			Abilities_Rogue.Columns.Add("EnemyEffect", typeof(string));
			
			Abilities_Rogue.Rows.Add(9001, "Test_Abilities_Rogue", "Testing", "Testing","Testing");
			Abilities_Rogue.Rows.Add(9002, "Backstab", "Stab the enemy in the back.", "", "Health-2;");
			
			return Abilities_Rogue;
		}
		
		//Output ALL items onto screen
		public static void dumpAllItems()
		{
			MainForm.mainform.outputBox.AppendText("Dumping all items...\n");
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
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Armor_Chest
			foreach(DataRow row in Armor_Chest.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Armor_Legs
			foreach(DataRow row in Armor_Legs.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Weapon_Sword
			foreach(DataRow row in Weapon_Sword.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Weapon_Staff
			foreach(DataRow row in Weapon_Staff.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Weapon_Dagger
			foreach(DataRow row in Weapon_Dagger.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Abilities_Warrior
			foreach(DataRow row in Abilities_Warrior.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Abilities_Mage
			foreach(DataRow row in Abilities_Mage.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
			
			//Abilities_Rogue
			foreach(DataRow row in Abilities_Rogue.Rows)
			{
				MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
				MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
			}
		}
		
		//Output items from given datatable to screen
		public static void dumpItems(string str)
		{
			switch(str) //Get which table to dump
			{
				case "Armor_Helmet":
					DataTable Armor_Helmet = Get_Armor_Helmet();
					foreach(DataRow row in Armor_Helmet.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Armor_Chest":
					DataTable Armor_Chest = Get_Armor_Chest();
					foreach(DataRow row in Armor_Chest.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Armor_Legs":
					DataTable Armor_Legs = Get_Armor_Legs();
					foreach(DataRow row in Armor_Legs.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Type"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Sword":
					DataTable Weapon_Sword = Get_Weapon_Sword();
					foreach(DataRow row in Weapon_Sword.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Staff":
					DataTable Weapon_Staff = Get_Weapon_Staff();
					foreach(DataRow row in Weapon_Staff.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Weapon_Dagger":
					DataTable Weapon_Dagger = Get_Weapon_Dagger();
					foreach(DataRow row in Weapon_Dagger.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Warrior":
					DataTable Abilities_Warrior = Get_Abilities_Warrior();
					foreach(DataRow row in Abilities_Warrior.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Mage":
					DataTable Abilities_Mage = Get_Abilities_Mage();
					foreach(DataRow row in Abilities_Mage.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
					
				case "Abilities_Rogue":
					DataTable Abilities_Rogue = Get_Abilities_Rogue();
					foreach(DataRow row in Abilities_Rogue.Rows)
					{
						MainForm.mainform.outputBox.AppendText(row["ID"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Name"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["Desc"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["PlayerEffect"].ToString() + "\t");
						MainForm.mainform.outputBox.AppendText(row["EnemyEffect"].ToString() + "\n");
					}
					break;
			}
		}
	}
}
