namespace ContactsAppUI
{
	partial class AboutForm
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
			this.ContactsAppLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.CopyrightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ContactsAppLabel
			// 
			this.ContactsAppLabel.AutoSize = true;
			this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactsAppLabel.Location = new System.Drawing.Point(77, 39);
			this.ContactsAppLabel.Name = "ContactsAppLabel";
			this.ContactsAppLabel.Size = new System.Drawing.Size(216, 39);
			this.ContactsAppLabel.TabIndex = 0;
			this.ContactsAppLabel.Text = "ContactsApp";
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VersionLabel.Location = new System.Drawing.Point(81, 87);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(92, 18);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "version 1.0.0";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorLabel.Location = new System.Drawing.Point(81, 134);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(191, 18);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "Author: Ekaterina Kabanova";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailLabel.Location = new System.Drawing.Point(81, 195);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(327, 18);
			this.EmailLabel.TabIndex = 3;
			this.EmailLabel.Text = "E-mail for feedback: katovskaya009@gmail.com";
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GitHubLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(9, 32);
			this.GitHubLinkLabel.Location = new System.Drawing.Point(81, 232);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(240, 22);
			this.GitHubLinkLabel.TabIndex = 4;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "Git Hub: KeV-project/ContactsApp";
			this.GitHubLinkLabel.UseCompatibleTextRendering = true;
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// CopyrightLabel
			// 
			this.CopyrightLabel.AutoSize = true;
			this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CopyrightLabel.Location = new System.Drawing.Point(81, 364);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new System.Drawing.Size(195, 18);
			this.CopyrightLabel.TabIndex = 5;
			this.CopyrightLabel.Text = "2020 Ekaterina Kabanova  ©";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 414);
			this.Controls.Add(this.CopyrightLabel);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.ContactsAppLabel);
			this.MaximumSize = new System.Drawing.Size(682, 452);
			this.MinimumSize = new System.Drawing.Size(682, 452);
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ContactsAppLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.LinkLabel GitHubLinkLabel;
		private System.Windows.Forms.Label CopyrightLabel;
	}
}