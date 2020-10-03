namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ContactsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactEmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactEmailLable = new System.Windows.Forms.Label();
            this.ContactBirthdayLable = new System.Windows.Forms.Label();
            this.ContactPhoneLable = new System.Windows.Forms.Label();
            this.ContactSurnameLable = new System.Windows.Forms.Label();
            this.ContactNameLabel = new System.Windows.Forms.Label();
            this.ContactSurnameTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ContactsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(64, 34);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(301, 20);
            this.FindTextBox.TabIndex = 0;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindLabel.Location = new System.Drawing.Point(21, 35);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(37, 16);
            this.FindLabel.TabIndex = 1;
            this.FindLabel.Text = "Find:";
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddContactButton.Image = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Image")));
            this.AddContactButton.Location = new System.Drawing.Point(24, 558);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(30, 28);
            this.AddContactButton.TabIndex = 5;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = ((System.Drawing.Image)(resources.GetObject("EditContactButton.Image")));
            this.EditContactButton.Location = new System.Drawing.Point(60, 558);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(30, 28);
            this.EditContactButton.TabIndex = 6;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveContactButton.Image")));
            this.RemoveContactButton.Location = new System.Drawing.Point(96, 558);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(30, 28);
            this.RemoveContactButton.TabIndex = 7;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 16;
            this.ContactsListBox.Location = new System.Drawing.Point(24, 60);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(341, 484);
            this.ContactsListBox.TabIndex = 8;
            // 
            // ContactsTableLayoutPanel
            // 
            this.ContactsTableLayoutPanel.ColumnCount = 2;
            this.ContactsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.ContactsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactEmailTextBox, 1, 4);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactNameTextBox, 1, 1);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactEmailLable, 0, 4);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactBirthdayLable, 0, 2);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactPhoneLable, 0, 3);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactSurnameLable, 0, 0);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactNameLabel, 0, 1);
            this.ContactsTableLayoutPanel.Controls.Add(this.ContactSurnameTextBox, 1, 0);
            this.ContactsTableLayoutPanel.Controls.Add(this.maskedTextBox1, 1, 3);
            this.ContactsTableLayoutPanel.Controls.Add(this.dateTimePicker1, 1, 2);
            this.ContactsTableLayoutPanel.Location = new System.Drawing.Point(401, 41);
            this.ContactsTableLayoutPanel.Name = "ContactsTableLayoutPanel";
            this.ContactsTableLayoutPanel.RowCount = 5;
            this.ContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.93499F));
            this.ContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.93499F));
            this.ContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04334F));
            this.ContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04334F));
            this.ContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04334F));
            this.ContactsTableLayoutPanel.Size = new System.Drawing.Size(742, 185);
            this.ContactsTableLayoutPanel.TabIndex = 9;
            // 
            // ContactEmailTextBox
            // 
            this.ContactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmailTextBox.Enabled = false;
            this.ContactEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactEmailTextBox.Location = new System.Drawing.Point(84, 149);
            this.ContactEmailTextBox.Name = "ContactEmailTextBox";
            this.ContactEmailTextBox.Size = new System.Drawing.Size(655, 22);
            this.ContactEmailTextBox.TabIndex = 14;
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNameTextBox.Enabled = false;
            this.ContactNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactNameTextBox.Location = new System.Drawing.Point(84, 39);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(655, 22);
            this.ContactNameTextBox.TabIndex = 11;
            // 
            // ContactEmailLable
            // 
            this.ContactEmailLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmailLable.AutoSize = true;
            this.ContactEmailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactEmailLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactEmailLable.Location = new System.Drawing.Point(3, 146);
            this.ContactEmailLable.Name = "ContactEmailLable";
            this.ContactEmailLable.Size = new System.Drawing.Size(75, 39);
            this.ContactEmailLable.TabIndex = 10;
            this.ContactEmailLable.Text = "E-mail:";
            this.ContactEmailLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactBirthdayLable
            // 
            this.ContactBirthdayLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactBirthdayLable.AutoSize = true;
            this.ContactBirthdayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactBirthdayLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactBirthdayLable.Location = new System.Drawing.Point(3, 72);
            this.ContactBirthdayLable.Name = "ContactBirthdayLable";
            this.ContactBirthdayLable.Size = new System.Drawing.Size(75, 37);
            this.ContactBirthdayLable.TabIndex = 10;
            this.ContactBirthdayLable.Text = "Birthday:";
            this.ContactBirthdayLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactPhoneLable
            // 
            this.ContactPhoneLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhoneLable.AutoSize = true;
            this.ContactPhoneLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactPhoneLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactPhoneLable.Location = new System.Drawing.Point(3, 109);
            this.ContactPhoneLable.Name = "ContactPhoneLable";
            this.ContactPhoneLable.Size = new System.Drawing.Size(75, 37);
            this.ContactPhoneLable.TabIndex = 10;
            this.ContactPhoneLable.Text = "Phone:";
            this.ContactPhoneLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactSurnameLable
            // 
            this.ContactSurnameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurnameLable.AutoSize = true;
            this.ContactSurnameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactSurnameLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactSurnameLable.Location = new System.Drawing.Point(3, 0);
            this.ContactSurnameLable.Name = "ContactSurnameLable";
            this.ContactSurnameLable.Size = new System.Drawing.Size(75, 36);
            this.ContactSurnameLable.TabIndex = 0;
            this.ContactSurnameLable.Text = "Surname:";
            this.ContactSurnameLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactNameLabel
            // 
            this.ContactNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNameLabel.AutoSize = true;
            this.ContactNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContactNameLabel.Location = new System.Drawing.Point(3, 36);
            this.ContactNameLabel.Name = "ContactNameLabel";
            this.ContactNameLabel.Size = new System.Drawing.Size(75, 36);
            this.ContactNameLabel.TabIndex = 10;
            this.ContactNameLabel.Text = "Name:";
            this.ContactNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactSurnameTextBox
            // 
            this.ContactSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurnameTextBox.Enabled = false;
            this.ContactSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactSurnameTextBox.Location = new System.Drawing.Point(84, 3);
            this.ContactSurnameTextBox.Name = "ContactSurnameTextBox";
            this.ContactSurnameTextBox.Size = new System.Drawing.Size(655, 22);
            this.ContactSurnameTextBox.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(84, 112);
            this.maskedTextBox1.Mask = "+7 (000) 00-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(655, 20);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 598);
            this.Controls.Add(this.ContactsTableLayoutPanel);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.RemoveContactButton);
            this.Controls.Add(this.EditContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.FindTextBox);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MinimumSize = new System.Drawing.Size(1174, 636);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.ContactsTableLayoutPanel.ResumeLayout(false);
            this.ContactsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TableLayoutPanel ContactsTableLayoutPanel;
        private System.Windows.Forms.Label ContactSurnameLable;
        private System.Windows.Forms.Label ContactNameLabel;
        private System.Windows.Forms.Label ContactBirthdayLable;
        private System.Windows.Forms.Label ContactEmailLable;
        private System.Windows.Forms.Label ContactPhoneLable;
        private System.Windows.Forms.TextBox ContactSurnameTextBox;
        private System.Windows.Forms.TextBox ContactEmailTextBox;
        private System.Windows.Forms.TextBox ContactNameTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

