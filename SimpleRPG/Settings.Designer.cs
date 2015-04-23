/*
 * User: Ethan Parizeau
 * Date: 4/23/2015
 * Time: 7:39 AM
 */
namespace SimpleRPG
{
	partial class Settings
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.closebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(12, 12);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// closebtn
			// 
			this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closebtn.Location = new System.Drawing.Point(443, 12);
			this.closebtn.Name = "closebtn";
			this.closebtn.Size = new System.Drawing.Size(75, 23);
			this.closebtn.TabIndex = 1;
			this.closebtn.TabStop = false;
			this.closebtn.Text = "Close";
			this.closebtn.UseVisualStyleBackColor = true;
			this.closebtn.Click += new System.EventHandler(this.ClosebtnClick);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(530, 480);
			this.Controls.Add(this.closebtn);
			this.Controls.Add(this.radioButton1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Settings";
			this.Text = "Settings";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button closebtn;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}
