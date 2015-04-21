/*
 * User: Ethan Parizeau
 * Date: 4/14/2015
 * Time: 7:46 AM
 */
namespace SimpleRPG
{
	partial class MakeCharacter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.raceCombobox = new System.Windows.Forms.ComboBox();
			this.characterNametxtbox = new System.Windows.Forms.TextBox();
			this.characterNamelbl = new System.Windows.Forms.Label();
			this.characterRacelbl = new System.Windows.Forms.Label();
			this.classCombobox = new System.Windows.Forms.ComboBox();
			this.classlbl = new System.Windows.Forms.Label();
			this.raceDesctxtbox = new System.Windows.Forms.RichTextBox();
			this.classDesctxtbox = new System.Windows.Forms.RichTextBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.backbtn = new System.Windows.Forms.Button();
			this.createbtn = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// raceCombobox
			// 
			this.raceCombobox.FormattingEnabled = true;
			this.raceCombobox.Items.AddRange(new object[] {
									"Human",
									"Dwarf",
									"Elf"});
			this.raceCombobox.Location = new System.Drawing.Point(55, 53);
			this.raceCombobox.Name = "raceCombobox";
			this.raceCombobox.Size = new System.Drawing.Size(103, 21);
			this.raceCombobox.TabIndex = 0;
			this.raceCombobox.TabStop = false;
			this.raceCombobox.SelectedIndexChanged += new System.EventHandler(this.RaceComboboxSelectedIndexChanged);
			// 
			// characterNametxtbox
			// 
			this.characterNametxtbox.Location = new System.Drawing.Point(55, 13);
			this.characterNametxtbox.Name = "characterNametxtbox";
			this.characterNametxtbox.Size = new System.Drawing.Size(103, 20);
			this.characterNametxtbox.TabIndex = 1;
			// 
			// characterNamelbl
			// 
			this.characterNamelbl.ForeColor = System.Drawing.Color.White;
			this.characterNamelbl.Location = new System.Drawing.Point(10, 13);
			this.characterNamelbl.Name = "characterNamelbl";
			this.characterNamelbl.Size = new System.Drawing.Size(39, 23);
			this.characterNamelbl.TabIndex = 2;
			this.characterNamelbl.Text = "Name:";
			this.characterNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// characterRacelbl
			// 
			this.characterRacelbl.ForeColor = System.Drawing.Color.White;
			this.characterRacelbl.Location = new System.Drawing.Point(10, 53);
			this.characterRacelbl.Name = "characterRacelbl";
			this.characterRacelbl.Size = new System.Drawing.Size(39, 23);
			this.characterRacelbl.TabIndex = 3;
			this.characterRacelbl.Text = "Race:";
			this.characterRacelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// classCombobox
			// 
			this.classCombobox.FormattingEnabled = true;
			this.classCombobox.Items.AddRange(new object[] {
									"Warrior",
									"Mage",
									"Rogue"});
			this.classCombobox.Location = new System.Drawing.Point(55, 97);
			this.classCombobox.Name = "classCombobox";
			this.classCombobox.Size = new System.Drawing.Size(103, 21);
			this.classCombobox.TabIndex = 4;
			this.classCombobox.TabStop = false;
			this.classCombobox.SelectedIndexChanged += new System.EventHandler(this.ClassComboboxSelectedIndexChanged);
			// 
			// classlbl
			// 
			this.classlbl.ForeColor = System.Drawing.Color.White;
			this.classlbl.Location = new System.Drawing.Point(10, 97);
			this.classlbl.Name = "classlbl";
			this.classlbl.Size = new System.Drawing.Size(39, 23);
			this.classlbl.TabIndex = 6;
			this.classlbl.Text = "Class:";
			this.classlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// raceDesctxtbox
			// 
			this.raceDesctxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.raceDesctxtbox.BackColor = System.Drawing.Color.Black;
			this.raceDesctxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.raceDesctxtbox.ForeColor = System.Drawing.Color.White;
			this.raceDesctxtbox.Location = new System.Drawing.Point(164, 13);
			this.raceDesctxtbox.Name = "raceDesctxtbox";
			this.raceDesctxtbox.ReadOnly = true;
			this.raceDesctxtbox.Size = new System.Drawing.Size(275, 113);
			this.raceDesctxtbox.TabIndex = 7;
			this.raceDesctxtbox.TabStop = false;
			this.raceDesctxtbox.Text = "Race description - Select a race to view its description";
			// 
			// classDesctxtbox
			// 
			this.classDesctxtbox.BackColor = System.Drawing.Color.Black;
			this.classDesctxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.classDesctxtbox.ForeColor = System.Drawing.Color.White;
			this.classDesctxtbox.Location = new System.Drawing.Point(10, 128);
			this.classDesctxtbox.Name = "classDesctxtbox";
			this.classDesctxtbox.ReadOnly = true;
			this.classDesctxtbox.Size = new System.Drawing.Size(507, 309);
			this.classDesctxtbox.TabIndex = 8;
			this.classDesctxtbox.TabStop = false;
			this.classDesctxtbox.Text = "Class description - Select a class to view its description";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.backbtn);
			this.mainPanel.Controls.Add(this.createbtn);
			this.mainPanel.Controls.Add(this.classDesctxtbox);
			this.mainPanel.Controls.Add(this.raceDesctxtbox);
			this.mainPanel.Controls.Add(this.classCombobox);
			this.mainPanel.Controls.Add(this.raceCombobox);
			this.mainPanel.Controls.Add(this.characterNametxtbox);
			this.mainPanel.Controls.Add(this.classlbl);
			this.mainPanel.Controls.Add(this.characterNamelbl);
			this.mainPanel.Controls.Add(this.characterRacelbl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(530, 480);
			this.mainPanel.TabIndex = 9;
			// 
			// backbtn
			// 
			this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backbtn.ForeColor = System.Drawing.Color.White;
			this.backbtn.Location = new System.Drawing.Point(441, 10);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(75, 23);
			this.backbtn.TabIndex = 10;
			this.backbtn.Text = "Back";
			this.backbtn.UseVisualStyleBackColor = true;
			this.backbtn.Click += new System.EventHandler(this.BackbtnClick);
			// 
			// createbtn
			// 
			this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createbtn.ForeColor = System.Drawing.Color.White;
			this.createbtn.Location = new System.Drawing.Point(442, 443);
			this.createbtn.Name = "createbtn";
			this.createbtn.Size = new System.Drawing.Size(75, 23);
			this.createbtn.TabIndex = 9;
			this.createbtn.Text = "Create!";
			this.createbtn.UseVisualStyleBackColor = true;
			this.createbtn.Click += new System.EventHandler(this.CreatebtnClick);
			// 
			// MakeCharacter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(530, 480);
			this.Controls.Add(this.mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MakeCharacter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.MakeCharacterLoad);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Button createbtn;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.RichTextBox classDesctxtbox;
		private System.Windows.Forms.RichTextBox raceDesctxtbox;
		private System.Windows.Forms.Label classlbl;
		private System.Windows.Forms.ComboBox classCombobox;
		private System.Windows.Forms.Label characterRacelbl;
		private System.Windows.Forms.Label characterNamelbl;
		private System.Windows.Forms.TextBox characterNametxtbox;
		private System.Windows.Forms.ComboBox raceCombobox;
	}
}
