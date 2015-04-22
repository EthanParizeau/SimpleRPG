using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace SimpleRPG
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Player instance
		public static Player mainPlayer = new Player();
		
		//Player inventory
		public static BindingList<string> playerInventory = new BindingList<string>();
		
		//Mainform instance
		public static MainForm mainform;
		
		//If character is loaded
		public static bool characterLoaded = false;
		
		public MainForm()
		{
			
			InitializeComponent();
			mainform = this;
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.inputBox.AutoSize = true;
			
			//Startup
			Startup.Check();
			
			//Welcome and startup screen
			outputBox.AppendText("Welcome to SimpleRPG!\n");
			outputBox.AppendText("Created by: Armadow\n");
			outputBox.AppendText("Github: https://github.com/Armadow\n\n");

			outputBox.AppendText(" ######  #### ##     ## ########  ##       ######## ########  ########   ######    \n");
			outputBox.AppendText("##    ##  ##  ###   ### ##     ## ##       ##       ##     ## ##     ## ##    ##   \n");
			outputBox.AppendText("##        ##  #### #### ##     ## ##       ##       ##     ## ##     ## ##         \n");
			outputBox.AppendText(" ######   ##  ## ### ## ########  ##       ######   ########  ########  ##   ####  \n");
			outputBox.AppendText("      ##  ##  ##  #  ## ##        ##       ##       ##   ##   ##        ##    ##   \n");
			outputBox.AppendText("##    ##  ##  ##     ## ##        ##       ##       ##    ##  ##        ##    ##   \n");
			outputBox.AppendText(" ######  #### ##     ## ##        ######## ######## ##     ## ##         ######    \n\n");
			
			
			LoadorCreate loadorcreate = new LoadorCreate(); //Make new instance of loadorcreate
			loadorcreate.ShowDialog(); //Show it as dialog
			inputBox.Enabled = true; //Renable the input box
		}

		void InputBoxKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				if(inputBox.Text != "")
				{
					Command.getCommand(inputBox.Text); //Send command to Command.getCommand() for sorting
					inputBox.Clear(); //Clear textbox after enter press
				}
			}
		}
		
		void PlayerInventorylistboxSelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedItem = playerInventorylistbox.Text; //Set selected item to string
			playerInvItemDesc.Clear(); //Clear the text box
			playerInvItemDesc.AppendText(selectedItem + " is selected.\n"); //Show what item is selected
		}
		
		void InputBoxLeave(object sender, EventArgs e) //When you click somwhere out of the textbox
		{
			inputBox.BorderStyle = BorderStyle.Fixed3D; //Set border style to fixed3d so you can see where the text box is
			inputBox.ForeColor = Color.Red; //Set the text to red so it stands out
			inputBox.Text = "Click here to use the text box..."; //Let the user know what they have to do to set focus back to the text box
		}
		
		void InputBoxEnter(object sender, EventArgs e) //When you click back into the text box
		{
			inputBox.BorderStyle = BorderStyle.None; //Set border style to none so you can't see it
			inputBox.Clear(); //Clear the text
			inputBox.ForeColor = Color.White; //Reset the color
		}
	}
}
