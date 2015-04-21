/*
 * User: Ethan Parizeau
 * Date: 4/14/2015
 * Time: 8:07 AM
 */
namespace SimpleRPG
{
	partial class LoadorCreate
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
			this.toptextlbl = new System.Windows.Forms.Label();
			this.loadbtn = new System.Windows.Forms.Button();
			this.createbtn = new System.Windows.Forms.Button();
			this.tiplbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// toptextlbl
			// 
			this.toptextlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toptextlbl.ForeColor = System.Drawing.Color.White;
			this.toptextlbl.Location = new System.Drawing.Point(12, 9);
			this.toptextlbl.Name = "toptextlbl";
			this.toptextlbl.Size = new System.Drawing.Size(457, 23);
			this.toptextlbl.TabIndex = 0;
			this.toptextlbl.Text = "Would you like to load a character or create a new one?";
			this.toptextlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loadbtn
			// 
			this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadbtn.ForeColor = System.Drawing.Color.White;
			this.loadbtn.Location = new System.Drawing.Point(56, 81);
			this.loadbtn.Name = "loadbtn";
			this.loadbtn.Size = new System.Drawing.Size(134, 75);
			this.loadbtn.TabIndex = 1;
			this.loadbtn.TabStop = false;
			this.loadbtn.Text = "Load";
			this.loadbtn.UseVisualStyleBackColor = true;
			this.loadbtn.Click += new System.EventHandler(this.LoadbtnClick);
			// 
			// createbtn
			// 
			this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createbtn.ForeColor = System.Drawing.Color.White;
			this.createbtn.Location = new System.Drawing.Point(281, 81);
			this.createbtn.Name = "createbtn";
			this.createbtn.Size = new System.Drawing.Size(134, 75);
			this.createbtn.TabIndex = 2;
			this.createbtn.TabStop = false;
			this.createbtn.Text = "Create";
			this.createbtn.UseVisualStyleBackColor = true;
			this.createbtn.Click += new System.EventHandler(this.CreatebtnClick);
			// 
			// tiplbl
			// 
			this.tiplbl.ForeColor = System.Drawing.Color.White;
			this.tiplbl.Location = new System.Drawing.Point(56, 293);
			this.tiplbl.Name = "tiplbl";
			this.tiplbl.Size = new System.Drawing.Size(359, 23);
			this.tiplbl.TabIndex = 3;
			this.tiplbl.Text = "Tip: To delete a character, go to load";
			this.tiplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoadorCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(481, 325);
			this.Controls.Add(this.tiplbl);
			this.Controls.Add(this.createbtn);
			this.Controls.Add(this.loadbtn);
			this.Controls.Add(this.toptextlbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoadorCreate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label tiplbl;
		private System.Windows.Forms.Button createbtn;
		private System.Windows.Forms.Button loadbtn;
		private System.Windows.Forms.Label toptextlbl;
	}
}
