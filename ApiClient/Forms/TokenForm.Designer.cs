namespace ApiClient.Forms {
	partial class TokenForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.group_token = new System.Windows.Forms.GroupBox();
			this.richtxt_token = new System.Windows.Forms.RichTextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.group_token.SuspendLayout();
			this.SuspendLayout();
			// 
			// group_token
			// 
			this.group_token.Controls.Add(this.richtxt_token);
			this.group_token.Location = new System.Drawing.Point(12, 12);
			this.group_token.Name = "group_token";
			this.group_token.Size = new System.Drawing.Size(601, 100);
			this.group_token.TabIndex = 0;
			this.group_token.TabStop = false;
			this.group_token.Text = "Token Provider";
			// 
			// richtxt_token
			// 
			this.richtxt_token.Location = new System.Drawing.Point(6, 19);
			this.richtxt_token.Name = "richtxt_token";
			this.richtxt_token.Size = new System.Drawing.Size(589, 75);
			this.richtxt_token.TabIndex = 0;
			this.richtxt_token.Text = "";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(538, 118);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// TokenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(625, 153);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.group_token);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TokenForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Token";
			this.group_token.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox group_token;
		private System.Windows.Forms.RichTextBox richtxt_token;
		private System.Windows.Forms.Button btn_add;
	}
}