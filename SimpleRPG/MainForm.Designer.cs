/*
 * User: parizeau15881
 * Date: 4/13/2015
 * Time: 7:42 AM
 */
namespace SimpleRPG
{
	partial class MainForm
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
			this.inputBox = new System.Windows.Forms.TextBox();
			this.outputBox = new System.Windows.Forms.RichTextBox();
			this.playerStatsgroupbox = new System.Windows.Forms.GroupBox();
			this.playerGoldlbl = new System.Windows.Forms.Label();
			this.playerManalbl = new System.Windows.Forms.Label();
			this.playerAgilitylbl = new System.Windows.Forms.Label();
			this.playerDefencelbl = new System.Windows.Forms.Label();
			this.playerIntellectlbl = new System.Windows.Forms.Label();
			this.playerStrengthlbl = new System.Windows.Forms.Label();
			this.playerXPlbl = new System.Windows.Forms.Label();
			this.playerLevellbl = new System.Windows.Forms.Label();
			this.playerHealthlbl = new System.Windows.Forms.Label();
			this.playerClasslbl = new System.Windows.Forms.Label();
			this.playerRacelbl = new System.Windows.Forms.Label();
			this.playerInvgroupbox = new System.Windows.Forms.GroupBox();
			this.playerInvItemDesc = new System.Windows.Forms.RichTextBox();
			this.playerInventorylistbox = new System.Windows.Forms.ListBox();
			this.playerStatsgroupbox.SuspendLayout();
			this.playerInvgroupbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputBox.AutoCompleteCustomSource.AddRange(new string[] {
									"game.exit",
									"clear",
									"help",
									"cmdhelp"});
			this.inputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.inputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.inputBox.BackColor = System.Drawing.Color.Black;
			this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox.ForeColor = System.Drawing.Color.White;
			this.inputBox.Location = new System.Drawing.Point(12, 579);
			this.inputBox.Margin = new System.Windows.Forms.Padding(0);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(485, 16);
			this.inputBox.TabIndex = 0;
			this.inputBox.Enter += new System.EventHandler(this.InputBoxEnter);
			this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
			this.inputBox.Leave += new System.EventHandler(this.InputBoxLeave);
			// 
			// outputBox
			// 
			this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputBox.BackColor = System.Drawing.Color.Black;
			this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputBox.ForeColor = System.Drawing.Color.White;
			this.outputBox.Location = new System.Drawing.Point(12, 12);
			this.outputBox.Name = "outputBox";
			this.outputBox.ReadOnly = true;
			this.outputBox.Size = new System.Drawing.Size(485, 564);
			this.outputBox.TabIndex = 1;
			this.outputBox.TabStop = false;
			this.outputBox.Text = "";
			// 
			// playerStatsgroupbox
			// 
			this.playerStatsgroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playerStatsgroupbox.BackColor = System.Drawing.Color.Black;
			this.playerStatsgroupbox.Controls.Add(this.playerGoldlbl);
			this.playerStatsgroupbox.Controls.Add(this.playerManalbl);
			this.playerStatsgroupbox.Controls.Add(this.playerAgilitylbl);
			this.playerStatsgroupbox.Controls.Add(this.playerDefencelbl);
			this.playerStatsgroupbox.Controls.Add(this.playerIntellectlbl);
			this.playerStatsgroupbox.Controls.Add(this.playerStrengthlbl);
			this.playerStatsgroupbox.Controls.Add(this.playerXPlbl);
			this.playerStatsgroupbox.Controls.Add(this.playerLevellbl);
			this.playerStatsgroupbox.Controls.Add(this.playerHealthlbl);
			this.playerStatsgroupbox.Controls.Add(this.playerClasslbl);
			this.playerStatsgroupbox.Controls.Add(this.playerRacelbl);
			this.playerStatsgroupbox.ForeColor = System.Drawing.Color.White;
			this.playerStatsgroupbox.Location = new System.Drawing.Point(501, 12);
			this.playerStatsgroupbox.Name = "playerStatsgroupbox";
			this.playerStatsgroupbox.Size = new System.Drawing.Size(251, 272);
			this.playerStatsgroupbox.TabIndex = 3;
			this.playerStatsgroupbox.TabStop = false;
			this.playerStatsgroupbox.Text = "PlayerName";
			// 
			// playerGoldlbl
			// 
			this.playerGoldlbl.Location = new System.Drawing.Point(95, 16);
			this.playerGoldlbl.Name = "playerGoldlbl";
			this.playerGoldlbl.Size = new System.Drawing.Size(83, 23);
			this.playerGoldlbl.TabIndex = 10;
			this.playerGoldlbl.Text = "Gold:";
			this.playerGoldlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerManalbl
			// 
			this.playerManalbl.Location = new System.Drawing.Point(6, 85);
			this.playerManalbl.Name = "playerManalbl";
			this.playerManalbl.Size = new System.Drawing.Size(83, 23);
			this.playerManalbl.TabIndex = 3;
			this.playerManalbl.Text = "Mana:";
			this.playerManalbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerAgilitylbl
			// 
			this.playerAgilitylbl.Location = new System.Drawing.Point(6, 223);
			this.playerAgilitylbl.Name = "playerAgilitylbl";
			this.playerAgilitylbl.Size = new System.Drawing.Size(83, 23);
			this.playerAgilitylbl.TabIndex = 9;
			this.playerAgilitylbl.Text = "Agility:";
			this.playerAgilitylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerDefencelbl
			// 
			this.playerDefencelbl.Location = new System.Drawing.Point(6, 200);
			this.playerDefencelbl.Name = "playerDefencelbl";
			this.playerDefencelbl.Size = new System.Drawing.Size(83, 23);
			this.playerDefencelbl.TabIndex = 8;
			this.playerDefencelbl.Text = "Defence:";
			this.playerDefencelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerIntellectlbl
			// 
			this.playerIntellectlbl.Location = new System.Drawing.Point(6, 177);
			this.playerIntellectlbl.Name = "playerIntellectlbl";
			this.playerIntellectlbl.Size = new System.Drawing.Size(83, 23);
			this.playerIntellectlbl.TabIndex = 7;
			this.playerIntellectlbl.Text = "Intellect:";
			this.playerIntellectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerStrengthlbl
			// 
			this.playerStrengthlbl.Location = new System.Drawing.Point(6, 154);
			this.playerStrengthlbl.Name = "playerStrengthlbl";
			this.playerStrengthlbl.Size = new System.Drawing.Size(83, 23);
			this.playerStrengthlbl.TabIndex = 6;
			this.playerStrengthlbl.Text = "Strength:";
			this.playerStrengthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerXPlbl
			// 
			this.playerXPlbl.Location = new System.Drawing.Point(6, 131);
			this.playerXPlbl.Name = "playerXPlbl";
			this.playerXPlbl.Size = new System.Drawing.Size(83, 23);
			this.playerXPlbl.TabIndex = 5;
			this.playerXPlbl.Text = "XP:";
			this.playerXPlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerLevellbl
			// 
			this.playerLevellbl.Location = new System.Drawing.Point(6, 108);
			this.playerLevellbl.Name = "playerLevellbl";
			this.playerLevellbl.Size = new System.Drawing.Size(83, 23);
			this.playerLevellbl.TabIndex = 4;
			this.playerLevellbl.Text = "Level:";
			this.playerLevellbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerHealthlbl
			// 
			this.playerHealthlbl.Location = new System.Drawing.Point(6, 62);
			this.playerHealthlbl.Name = "playerHealthlbl";
			this.playerHealthlbl.Size = new System.Drawing.Size(83, 23);
			this.playerHealthlbl.TabIndex = 2;
			this.playerHealthlbl.Text = "Health:";
			this.playerHealthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerClasslbl
			// 
			this.playerClasslbl.Location = new System.Drawing.Point(6, 39);
			this.playerClasslbl.Name = "playerClasslbl";
			this.playerClasslbl.Size = new System.Drawing.Size(83, 23);
			this.playerClasslbl.TabIndex = 1;
			this.playerClasslbl.Text = "Class:";
			this.playerClasslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerRacelbl
			// 
			this.playerRacelbl.Location = new System.Drawing.Point(6, 16);
			this.playerRacelbl.Name = "playerRacelbl";
			this.playerRacelbl.Size = new System.Drawing.Size(83, 23);
			this.playerRacelbl.TabIndex = 0;
			this.playerRacelbl.Text = "Race:";
			this.playerRacelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// playerInvgroupbox
			// 
			this.playerInvgroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playerInvgroupbox.BackColor = System.Drawing.Color.Black;
			this.playerInvgroupbox.Controls.Add(this.playerInvItemDesc);
			this.playerInvgroupbox.Controls.Add(this.playerInventorylistbox);
			this.playerInvgroupbox.ForeColor = System.Drawing.Color.White;
			this.playerInvgroupbox.Location = new System.Drawing.Point(501, 290);
			this.playerInvgroupbox.Name = "playerInvgroupbox";
			this.playerInvgroupbox.Size = new System.Drawing.Size(251, 286);
			this.playerInvgroupbox.TabIndex = 4;
			this.playerInvgroupbox.TabStop = false;
			this.playerInvgroupbox.Text = "Inventory";
			// 
			// playerInvItemDesc
			// 
			this.playerInvItemDesc.BackColor = System.Drawing.Color.Black;
			this.playerInvItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playerInvItemDesc.ForeColor = System.Drawing.Color.White;
			this.playerInvItemDesc.Location = new System.Drawing.Point(6, 90);
			this.playerInvItemDesc.Name = "playerInvItemDesc";
			this.playerInvItemDesc.ReadOnly = true;
			this.playerInvItemDesc.Size = new System.Drawing.Size(239, 190);
			this.playerInvItemDesc.TabIndex = 1;
			this.playerInvItemDesc.Text = "";
			// 
			// playerInventorylistbox
			// 
			this.playerInventorylistbox.BackColor = System.Drawing.Color.Black;
			this.playerInventorylistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playerInventorylistbox.ForeColor = System.Drawing.Color.White;
			this.playerInventorylistbox.FormattingEnabled = true;
			this.playerInventorylistbox.Items.AddRange(new object[] {
									""});
			this.playerInventorylistbox.Location = new System.Drawing.Point(6, 19);
			this.playerInventorylistbox.Name = "playerInventorylistbox";
			this.playerInventorylistbox.Size = new System.Drawing.Size(239, 65);
			this.playerInventorylistbox.TabIndex = 0;
			this.playerInventorylistbox.SelectedIndexChanged += new System.EventHandler(this.PlayerInventorylistboxSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(764, 608);
			this.ControlBox = false;
			this.Controls.Add(this.playerInvgroupbox);
			this.Controls.Add(this.playerStatsgroupbox);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.inputBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleRPG";
			this.TransparencyKey = System.Drawing.Color.Lime;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.playerStatsgroupbox.ResumeLayout(false);
			this.playerInvgroupbox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RichTextBox playerInvItemDesc;
		public System.Windows.Forms.ListBox playerInventorylistbox;
		private System.Windows.Forms.GroupBox playerInvgroupbox;
		public System.Windows.Forms.Label playerGoldlbl;
		public System.Windows.Forms.GroupBox playerStatsgroupbox;
		public System.Windows.Forms.RichTextBox outputBox;
		public System.Windows.Forms.TextBox inputBox;
		public System.Windows.Forms.Label playerAgilitylbl;
		public System.Windows.Forms.Label playerDefencelbl;
		public System.Windows.Forms.Label playerIntellectlbl;
		public System.Windows.Forms.Label playerStrengthlbl;
		public System.Windows.Forms.Label playerXPlbl;
		public System.Windows.Forms.Label playerLevellbl;
		public System.Windows.Forms.Label playerManalbl;
		public System.Windows.Forms.Label playerHealthlbl;
		public System.Windows.Forms.Label playerClasslbl;
		public System.Windows.Forms.Label playerRacelbl;
	}
}
