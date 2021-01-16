
namespace mp4decryptgui
{
	partial class mp4decryptgui
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.vk1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.vk2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ak1 = new System.Windows.Forms.TextBox();
			this.ak2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.keys = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.subs = new System.Windows.Forms.TextBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.clear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// vk1
			// 
			this.vk1.Location = new System.Drawing.Point(21, 21);
			this.vk1.Name = "vk1";
			this.vk1.Size = new System.Drawing.Size(173, 20);
			this.vk1.TabIndex = 0;
			this.vk1.Click += new System.EventHandler(this.textBox1_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(23, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = ":";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// vk2
			// 
			this.vk2.Location = new System.Drawing.Point(208, 21);
			this.vk2.Name = "vk2";
			this.vk2.Size = new System.Drawing.Size(171, 20);
			this.vk2.TabIndex = 2;
			this.vk2.Click += new System.EventHandler(this.textBox2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 318);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(194, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.vk1);
			this.groupBox1.Controls.Add(this.vk2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(17, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(396, 53);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "video";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ak1);
			this.groupBox2.Controls.Add(this.ak2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(17, 71);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(396, 61);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "audio";
			// 
			// ak1
			// 
			this.ak1.Location = new System.Drawing.Point(21, 21);
			this.ak1.Name = "ak1";
			this.ak1.Size = new System.Drawing.Size(173, 20);
			this.ak1.TabIndex = 0;
			this.ak1.Click += new System.EventHandler(this.ak1_Click);
			// 
			// ak2
			// 
			this.ak2.Location = new System.Drawing.Point(208, 21);
			this.ak2.Name = "ak2";
			this.ak2.Size = new System.Drawing.Size(171, 20);
			this.ak2.TabIndex = 2;
			this.ak2.Click += new System.EventHandler(this.ak2_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(356, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = ":";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.keys);
			this.groupBox4.Location = new System.Drawing.Point(17, 138);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(396, 83);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "get keys";
			// 
			// keys
			// 
			this.keys.Location = new System.Drawing.Point(21, 22);
			this.keys.Multiline = true;
			this.keys.Name = "keys";
			this.keys.Size = new System.Drawing.Size(358, 45);
			this.keys.TabIndex = 0;
			this.keys.Click += new System.EventHandler(this.keys_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.subs);
			this.groupBox5.Location = new System.Drawing.Point(17, 227);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(396, 85);
			this.groupBox5.TabIndex = 10;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "get subs";
			// 
			// subs
			// 
			this.subs.Location = new System.Drawing.Point(21, 22);
			this.subs.Multiline = true;
			this.subs.Name = "subs";
			this.subs.Size = new System.Drawing.Size(358, 48);
			this.subs.TabIndex = 0;
			this.subs.Click += new System.EventHandler(this.subs_Click);
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(17, 347);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLog.Size = new System.Drawing.Size(396, 133);
			this.txtLog.TabIndex = 11;
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(219, 318);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(194, 23);
			this.clear.TabIndex = 12;
			this.clear.Text = "clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.button2_Click);
			// 
			// mp4decryptgui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 491);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "mp4decryptgui";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mp4decryptgui";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox vk1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox vk2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox ak1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ak2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox keys;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox subs;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Button clear;
	}
}

