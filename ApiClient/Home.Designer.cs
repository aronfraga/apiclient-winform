namespace ApiClient {
	partial class Home {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.group_bearer = new System.Windows.Forms.GroupBox();
			this.btn_token = new System.Windows.Forms.Button();
			this.group_method = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_put = new System.Windows.Forms.Button();
			this.btn_post = new System.Windows.Forms.Button();
			this.btn_get = new System.Windows.Forms.Button();
			this.lbl_ver = new System.Windows.Forms.Label();
			this.bar = new System.Windows.Forms.ProgressBar();
			this.group_response = new System.Windows.Forms.GroupBox();
			this.rich_response = new System.Windows.Forms.RichTextBox();
			this.group_body = new System.Windows.Forms.GroupBox();
			this.rich_body = new System.Windows.Forms.RichTextBox();
			this.lbl_statuscode = new System.Windows.Forms.Label();
			this.lblcode = new System.Windows.Forms.Label();
			this.txtbox_url = new System.Windows.Forms.TextBox();
			this.clienturl = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.group_bearer.SuspendLayout();
			this.group_method.SuspendLayout();
			this.group_response.SuspendLayout();
			this.group_body.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1285, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.splitContainer1.Panel1.Controls.Add(this.group_bearer);
			this.splitContainer1.Panel1.Controls.Add(this.group_method);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_ver);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.bar);
			this.splitContainer1.Panel2.Controls.Add(this.group_response);
			this.splitContainer1.Panel2.Controls.Add(this.group_body);
			this.splitContainer1.Panel2.Controls.Add(this.lbl_statuscode);
			this.splitContainer1.Panel2.Controls.Add(this.lblcode);
			this.splitContainer1.Panel2.Controls.Add(this.txtbox_url);
			this.splitContainer1.Panel2.Controls.Add(this.clienturl);
			this.splitContainer1.Size = new System.Drawing.Size(1285, 702);
			this.splitContainer1.SplitterDistance = 78;
			this.splitContainer1.TabIndex = 1;
			// 
			// group_bearer
			// 
			this.group_bearer.Controls.Add(this.btn_token);
			this.group_bearer.Location = new System.Drawing.Point(3, 179);
			this.group_bearer.Name = "group_bearer";
			this.group_bearer.Size = new System.Drawing.Size(73, 49);
			this.group_bearer.TabIndex = 4;
			this.group_bearer.TabStop = false;
			this.group_bearer.Text = "Bearer";
			// 
			// btn_token
			// 
			this.btn_token.BackColor = System.Drawing.Color.Yellow;
			this.btn_token.Location = new System.Drawing.Point(6, 19);
			this.btn_token.Name = "btn_token";
			this.btn_token.Size = new System.Drawing.Size(61, 23);
			this.btn_token.TabIndex = 0;
			this.btn_token.Text = "TOKEN";
			this.btn_token.UseVisualStyleBackColor = false;
			this.btn_token.Click += new System.EventHandler(this.btn_token_Click);
			// 
			// group_method
			// 
			this.group_method.Controls.Add(this.btn_delete);
			this.group_method.Controls.Add(this.btn_put);
			this.group_method.Controls.Add(this.btn_post);
			this.group_method.Controls.Add(this.btn_get);
			this.group_method.Location = new System.Drawing.Point(2, 36);
			this.group_method.Name = "group_method";
			this.group_method.Size = new System.Drawing.Size(73, 137);
			this.group_method.TabIndex = 0;
			this.group_method.TabStop = false;
			this.group_method.Text = "Method";
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.Red;
			this.btn_delete.Location = new System.Drawing.Point(6, 106);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(61, 23);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "DELETE";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_put
			// 
			this.btn_put.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_put.Location = new System.Drawing.Point(6, 77);
			this.btn_put.Name = "btn_put";
			this.btn_put.Size = new System.Drawing.Size(61, 23);
			this.btn_put.TabIndex = 2;
			this.btn_put.Text = "PUT";
			this.btn_put.UseVisualStyleBackColor = false;
			this.btn_put.Click += new System.EventHandler(this.btn_put_Click);
			// 
			// btn_post
			// 
			this.btn_post.BackColor = System.Drawing.Color.Lime;
			this.btn_post.Location = new System.Drawing.Point(6, 48);
			this.btn_post.Name = "btn_post";
			this.btn_post.Size = new System.Drawing.Size(61, 23);
			this.btn_post.TabIndex = 1;
			this.btn_post.Text = "POST";
			this.btn_post.UseVisualStyleBackColor = false;
			this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
			// 
			// btn_get
			// 
			this.btn_get.BackColor = System.Drawing.Color.Cyan;
			this.btn_get.Location = new System.Drawing.Point(6, 19);
			this.btn_get.Name = "btn_get";
			this.btn_get.Size = new System.Drawing.Size(61, 23);
			this.btn_get.TabIndex = 0;
			this.btn_get.Text = "GET";
			this.btn_get.UseVisualStyleBackColor = false;
			this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
			// 
			// lbl_ver
			// 
			this.lbl_ver.AutoSize = true;
			this.lbl_ver.Location = new System.Drawing.Point(3, 680);
			this.lbl_ver.Name = "lbl_ver";
			this.lbl_ver.Size = new System.Drawing.Size(72, 13);
			this.lbl_ver.TabIndex = 4;
			this.lbl_ver.Text = "V.0.0.35 Beta";
			// 
			// bar
			// 
			this.bar.Location = new System.Drawing.Point(1019, 14);
			this.bar.Name = "bar";
			this.bar.Size = new System.Drawing.Size(175, 10);
			this.bar.TabIndex = 10;
			// 
			// group_response
			// 
			this.group_response.Controls.Add(this.rich_response);
			this.group_response.Location = new System.Drawing.Point(605, 36);
			this.group_response.Name = "group_response";
			this.group_response.Size = new System.Drawing.Size(589, 657);
			this.group_response.TabIndex = 9;
			this.group_response.TabStop = false;
			this.group_response.Text = "Response";
			// 
			// rich_response
			// 
			this.rich_response.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rich_response.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rich_response.Location = new System.Drawing.Point(6, 19);
			this.rich_response.Name = "rich_response";
			this.rich_response.ReadOnly = true;
			this.rich_response.Size = new System.Drawing.Size(577, 632);
			this.rich_response.TabIndex = 1;
			this.rich_response.Text = "";
			// 
			// group_body
			// 
			this.group_body.Controls.Add(this.rich_body);
			this.group_body.Location = new System.Drawing.Point(10, 36);
			this.group_body.Name = "group_body";
			this.group_body.Size = new System.Drawing.Size(589, 657);
			this.group_body.TabIndex = 8;
			this.group_body.TabStop = false;
			this.group_body.Text = "Body";
			// 
			// rich_body
			// 
			this.rich_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rich_body.Font = new System.Drawing.Font("Consolas", 11.25F);
			this.rich_body.Location = new System.Drawing.Point(6, 19);
			this.rich_body.Name = "rich_body";
			this.rich_body.Size = new System.Drawing.Size(577, 632);
			this.rich_body.TabIndex = 0;
			this.rich_body.Text = "";
			// 
			// lbl_statuscode
			// 
			this.lbl_statuscode.AutoSize = true;
			this.lbl_statuscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_statuscode.Location = new System.Drawing.Point(878, 11);
			this.lbl_statuscode.Name = "lbl_statuscode";
			this.lbl_statuscode.Size = new System.Drawing.Size(0, 13);
			this.lbl_statuscode.TabIndex = 6;
			// 
			// lblcode
			// 
			this.lblcode.AutoSize = true;
			this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcode.Location = new System.Drawing.Point(797, 11);
			this.lblcode.Name = "lblcode";
			this.lblcode.Size = new System.Drawing.Size(80, 13);
			this.lblcode.TabIndex = 5;
			this.lblcode.Text = "Status Code:";
			// 
			// txtbox_url
			// 
			this.txtbox_url.Location = new System.Drawing.Point(42, 8);
			this.txtbox_url.Name = "txtbox_url";
			this.txtbox_url.Size = new System.Drawing.Size(749, 20);
			this.txtbox_url.TabIndex = 1;
			// 
			// clienturl
			// 
			this.clienturl.AutoSize = true;
			this.clienturl.Location = new System.Drawing.Point(4, 11);
			this.clienturl.Name = "clienturl";
			this.clienturl.Size = new System.Drawing.Size(32, 13);
			this.clienturl.TabIndex = 0;
			this.clienturl.Text = "URL:";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 726);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Api Client";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.group_bearer.ResumeLayout(false);
			this.group_method.ResumeLayout(false);
			this.group_response.ResumeLayout(false);
			this.group_body.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox group_method;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_put;
		private System.Windows.Forms.Button btn_post;
		private System.Windows.Forms.Button btn_get;
		private System.Windows.Forms.TextBox txtbox_url;
		private System.Windows.Forms.Label clienturl;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label lbl_ver;
		private System.Windows.Forms.GroupBox group_bearer;
		private System.Windows.Forms.Button btn_token;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label lbl_statuscode;
		private System.Windows.Forms.Label lblcode;
		private System.Windows.Forms.ProgressBar bar;
		private System.Windows.Forms.GroupBox group_response;
		private System.Windows.Forms.RichTextBox rich_response;
		private System.Windows.Forms.GroupBox group_body;
		private System.Windows.Forms.RichTextBox rich_body;
	}
}

