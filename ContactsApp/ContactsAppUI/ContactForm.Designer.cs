namespace ContactsAppUI
{
    partial class ContactForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
			this.MakeContactTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.MakeContactEmailTextBox = new System.Windows.Forms.TextBox();
			this.MakeContactNameTextBox = new System.Windows.Forms.TextBox();
			this.MakeContactNameLabel = new System.Windows.Forms.Label();
			this.MakeContactSurnameLabel = new System.Windows.Forms.Label();
			this.MakeContactSurnameTextBox = new System.Windows.Forms.TextBox();
			this.MakeContactBirthdayLabel = new System.Windows.Forms.Label();
			this.MakeContactPhoneLabel = new System.Windows.Forms.Label();
			this.MakeContactEmailLabel = new System.Windows.Forms.Label();
			this.MakeContactPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.MakeContactBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.MakeContactOkButton = new System.Windows.Forms.Button();
			this.MakeContactCancelButton = new System.Windows.Forms.Button();
			this.MakeContactTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MakeContactTableLayoutPanel
			// 
			this.MakeContactTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.MakeContactTableLayoutPanel.ColumnCount = 2;
			this.MakeContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.MakeContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactEmailTextBox, 1, 4);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactNameTextBox, 1, 1);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactNameLabel, 0, 1);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactSurnameLabel, 0, 0);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactSurnameTextBox, 1, 0);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactBirthdayLabel, 0, 2);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactPhoneLabel, 0, 3);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactEmailLabel, 0, 4);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactPhoneMaskedTextBox, 1, 3);
			this.MakeContactTableLayoutPanel.Controls.Add(this.MakeContactBirthDateTimePicker, 1, 2);
			this.MakeContactTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MakeContactTableLayoutPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactTableLayoutPanel.Location = new System.Drawing.Point(32, 27);
			this.MakeContactTableLayoutPanel.Name = "MakeContactTableLayoutPanel";
			this.MakeContactTableLayoutPanel.RowCount = 5;
			this.MakeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.MakeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.MakeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.MakeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.MakeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.MakeContactTableLayoutPanel.Size = new System.Drawing.Size(530, 178);
			this.MakeContactTableLayoutPanel.TabIndex = 0;
			// 
			// MakeContactEmailTextBox
			// 
			this.MakeContactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactEmailTextBox.Location = new System.Drawing.Point(82, 143);
			this.MakeContactEmailTextBox.Name = "MakeContactEmailTextBox";
			this.MakeContactEmailTextBox.Size = new System.Drawing.Size(445, 22);
			this.MakeContactEmailTextBox.TabIndex = 9;
			// 
			// MakeContactNameTextBox
			// 
			this.MakeContactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactNameTextBox.Location = new System.Drawing.Point(82, 38);
			this.MakeContactNameTextBox.Name = "MakeContactNameTextBox";
			this.MakeContactNameTextBox.Size = new System.Drawing.Size(445, 22);
			this.MakeContactNameTextBox.TabIndex = 6;
			// 
			// MakeContactNameLabel
			// 
			this.MakeContactNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactNameLabel.AutoSize = true;
			this.MakeContactNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactNameLabel.Location = new System.Drawing.Point(3, 35);
			this.MakeContactNameLabel.Name = "MakeContactNameLabel";
			this.MakeContactNameLabel.Size = new System.Drawing.Size(73, 35);
			this.MakeContactNameLabel.TabIndex = 2;
			this.MakeContactNameLabel.Text = "Name:";
			this.MakeContactNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MakeContactSurnameLabel
			// 
			this.MakeContactSurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactSurnameLabel.AutoSize = true;
			this.MakeContactSurnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactSurnameLabel.Location = new System.Drawing.Point(3, 0);
			this.MakeContactSurnameLabel.Name = "MakeContactSurnameLabel";
			this.MakeContactSurnameLabel.Size = new System.Drawing.Size(73, 35);
			this.MakeContactSurnameLabel.TabIndex = 0;
			this.MakeContactSurnameLabel.Text = "Surname:";
			this.MakeContactSurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MakeContactSurnameTextBox
			// 
			this.MakeContactSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactSurnameTextBox.Location = new System.Drawing.Point(82, 3);
			this.MakeContactSurnameTextBox.Name = "MakeContactSurnameTextBox";
			this.MakeContactSurnameTextBox.Size = new System.Drawing.Size(445, 22);
			this.MakeContactSurnameTextBox.TabIndex = 1;
			// 
			// MakeContactBirthdayLabel
			// 
			this.MakeContactBirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactBirthdayLabel.AutoSize = true;
			this.MakeContactBirthdayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactBirthdayLabel.Location = new System.Drawing.Point(3, 70);
			this.MakeContactBirthdayLabel.Name = "MakeContactBirthdayLabel";
			this.MakeContactBirthdayLabel.Size = new System.Drawing.Size(73, 35);
			this.MakeContactBirthdayLabel.TabIndex = 3;
			this.MakeContactBirthdayLabel.Text = "Birthday:";
			this.MakeContactBirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MakeContactPhoneLabel
			// 
			this.MakeContactPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactPhoneLabel.AutoSize = true;
			this.MakeContactPhoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactPhoneLabel.Location = new System.Drawing.Point(3, 105);
			this.MakeContactPhoneLabel.Name = "MakeContactPhoneLabel";
			this.MakeContactPhoneLabel.Size = new System.Drawing.Size(73, 35);
			this.MakeContactPhoneLabel.TabIndex = 4;
			this.MakeContactPhoneLabel.Text = "Phone:";
			this.MakeContactPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MakeContactEmailLabel
			// 
			this.MakeContactEmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactEmailLabel.AutoSize = true;
			this.MakeContactEmailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactEmailLabel.Location = new System.Drawing.Point(3, 140);
			this.MakeContactEmailLabel.Name = "MakeContactEmailLabel";
			this.MakeContactEmailLabel.Size = new System.Drawing.Size(73, 38);
			this.MakeContactEmailLabel.TabIndex = 5;
			this.MakeContactEmailLabel.Text = "E-mail:";
			this.MakeContactEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MakeContactPhoneMaskedTextBox
			// 
			this.MakeContactPhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeContactPhoneMaskedTextBox.Location = new System.Drawing.Point(82, 108);
			this.MakeContactPhoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
			this.MakeContactPhoneMaskedTextBox.Name = "MakeContactPhoneMaskedTextBox";
			this.MakeContactPhoneMaskedTextBox.Size = new System.Drawing.Size(445, 22);
			this.MakeContactPhoneMaskedTextBox.TabIndex = 11;
			// 
			// MakeContactBirthDateTimePicker
			// 
			this.MakeContactBirthDateTimePicker.Location = new System.Drawing.Point(82, 73);
			this.MakeContactBirthDateTimePicker.Name = "MakeContactBirthDateTimePicker";
			this.MakeContactBirthDateTimePicker.Size = new System.Drawing.Size(162, 22);
			this.MakeContactBirthDateTimePicker.TabIndex = 12;
			// 
			// MakeContactOkButton
			// 
			this.MakeContactOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MakeContactOkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactOkButton.Location = new System.Drawing.Point(345, 236);
			this.MakeContactOkButton.Name = "MakeContactOkButton";
			this.MakeContactOkButton.Size = new System.Drawing.Size(104, 34);
			this.MakeContactOkButton.TabIndex = 1;
			this.MakeContactOkButton.Text = "Ok";
			this.MakeContactOkButton.UseVisualStyleBackColor = true;
			this.MakeContactOkButton.Click += new System.EventHandler(this.MakeContactOkButton_Click);
			// 
			// MakeContactCancelButton
			// 
			this.MakeContactCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MakeContactCancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeContactCancelButton.Location = new System.Drawing.Point(455, 236);
			this.MakeContactCancelButton.Name = "MakeContactCancelButton";
			this.MakeContactCancelButton.Size = new System.Drawing.Size(104, 34);
			this.MakeContactCancelButton.TabIndex = 2;
			this.MakeContactCancelButton.Text = "Cancel";
			this.MakeContactCancelButton.UseVisualStyleBackColor = true;
			this.MakeContactCancelButton.Click += new System.EventHandler(this.MakeContactCancelButton_Click);
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 282);
			this.Controls.Add(this.MakeContactCancelButton);
			this.Controls.Add(this.MakeContactOkButton);
			this.Controls.Add(this.MakeContactTableLayoutPanel);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(613, 320);
			this.MinimumSize = new System.Drawing.Size(613, 320);
			this.Name = "ContactForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add/Edit contact";
			this.MakeContactTableLayoutPanel.ResumeLayout(false);
			this.MakeContactTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MakeContactTableLayoutPanel;
        private System.Windows.Forms.Label MakeContactSurnameLabel;
        private System.Windows.Forms.TextBox MakeContactSurnameTextBox;
        private System.Windows.Forms.Label MakeContactNameLabel;
        private System.Windows.Forms.Label MakeContactBirthdayLabel;
        private System.Windows.Forms.Label MakeContactPhoneLabel;
        private System.Windows.Forms.Label MakeContactEmailLabel;
        private System.Windows.Forms.TextBox MakeContactEmailTextBox;
        private System.Windows.Forms.TextBox MakeContactNameTextBox;
        private System.Windows.Forms.MaskedTextBox MakeContactPhoneMaskedTextBox;
        private System.Windows.Forms.DateTimePicker MakeContactBirthDateTimePicker;
        private System.Windows.Forms.Button MakeContactOkButton;
        private System.Windows.Forms.Button MakeContactCancelButton;
    }
}