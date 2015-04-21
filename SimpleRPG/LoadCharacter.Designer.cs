/*
 * User: Ethan Parizeau
 * Date: 4/14/2015
 * Time: 8:05 AM
 */
namespace SimpleRPG
{
	partial class LoadCharacter
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
			this.characterslbl = new System.Windows.Forms.Label();
			this.charactersListBox = new System.Windows.Forms.ListBox();
			this.characterLoadbtn = new System.Windows.Forms.Button();
			this.delbtn = new System.Windows.Forms.Button();
			this.backbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// characterslbl
			// 
			this.characterslbl.ForeColor = System.Drawing.Color.White;
			this.characterslbl.Location = new System.Drawing.Point(25, 9);
			this.characterslbl.Name = "characterslbl";
			this.characterslbl.Size = new System.Drawing.Size(62, 23);
			this.characterslbl.TabIndex = 1;
			this.characterslbl.Text = "Characters";
			this.characterslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// charactersListBox
			// 
			this.charactersListBox.BackColor = System.Drawing.Color.Black;
			this.charactersListBox.ForeColor = System.Drawing.Color.White;
			this.charactersListBox.FormattingEnabled = true;
			this.charactersListBox.Location = new System.Drawing.Point(12, 35);
			this.charactersListBox.Name = "charactersListBox";
			this.charactersListBox.Size = new System.Drawing.Size(158, 121);
			this.charactersListBox.TabIndex = 2;
			// 
			// characterLoadbtn
			// 
			this.characterLoadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.characterLoadbtn.ForeColor = System.Drawing.Color.White;
			this.characterLoadbtn.Location = new System.Drawing.Point(14, 162);
			this.characterLoadbtn.Name = "characterLoadbtn";
			this.characterLoadbtn.Size = new System.Drawing.Size(75, 23);
			this.characterLoadbtn.TabIndex = 7;
			this.characterLoadbtn.Text = "Load";
			this.characterLoadbtn.UseVisualStyleBackColor = true;
			this.characterLoadbtn.Click += new System.EventHandler(this.CharacterLoadbtnClick);
			// 
			// delbtn
			// 
			this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delbtn.ForeColor = System.Drawing.Color.White;
			this.delbtn.Location = new System.Drawing.Point(95, 162);
			this.delbtn.Name = "delbtn";
			this.delbtn.Size = new System.Drawing.Size(75, 23);
			this.delbtn.TabIndex = 8;
			this.delbtn.Text = "Delete";
			this.delbtn.UseVisualStyleBackColor = true;
			this.delbtn.Click += new System.EventHandler(this.DelbtnClick);
			// 
			// backbtn
			// 
			this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backbtn.ForeColor = System.Drawing.Color.White;
			this.backbtn.Location = new System.Drawing.Point(443, 12);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(75, 23);
			this.backbtn.TabIndex = 9;
			this.backbtn.Text = "Back";
			this.backbtn.UseVisualStyleBackColor = true;
			this.backbtn.Click += new System.EventHandler(this.BackbtnClick);
			// 
			// LoadCharacter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(530, 480);
			this.Controls.Add(this.backbtn);
			this.Controls.Add(this.delbtn);
			this.Controls.Add(this.characterLoadbtn);
			this.Controls.Add(this.charactersListBox);
			this.Controls.Add(this.characterslbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoadCharacter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.LoadCharacterLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Button delbtn;
		private System.Windows.Forms.Button characterLoadbtn;
		private System.Windows.Forms.ListBox charactersListBox;
		private System.Windows.Forms.Label characterslbl;
	}
}
