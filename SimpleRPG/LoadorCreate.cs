using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRPG
{
	/// <summary>
	/// Load or create a character
	/// </summary>
	public partial class LoadorCreate : Form
	{
		public LoadorCreate()
		{
			InitializeComponent();
		}
		
		//Load is not finished
		void LoadbtnClick(object sender, EventArgs e)
		{
			//Load pressed
			LoadCharacter loadcharacter = new LoadCharacter(); //Create instance of LoadCharacter form
			loadcharacter.ShowDialog(); //Show loadcharacter as dialog
			if(MainForm.characterLoaded == true) //Make sure the character is loaded before we close this form
			{
				this.Close(); //Close this form because it won't be used again for a while and it is no longer needed
			}
		}
		
		void CreatebtnClick(object sender, EventArgs e)
		{
			//Create pressed
			MakeCharacter makeCharacter = new MakeCharacter(); //Create instance of MakeCharacter form
			makeCharacter.ShowDialog(); //Show MakeCharacter as dialog so its main focus, on top, and will close after
			if(MainForm.characterLoaded == true) //Make sure the character is loaded before we close this form
			{
				this.Close(); //Close this form because it won't be used again for a while and it is no longer needed
			}
		}
	}
}
