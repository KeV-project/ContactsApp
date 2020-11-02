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
			this.ContactPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.ContactBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExclamationMarkTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.BirthTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.BirthTextBox = new System.Windows.Forms.TextBox();
			this.BirthLabel = new System.Windows.Forms.Label();
			this.ContactsTableLayoutPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.BirthTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// FindTextBox
			// 
			this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FindTextBox.Location = new System.Drawing.Point(64, 34);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.Size = new System.Drawing.Size(301, 22);
			this.FindTextBox.TabIndex = 0;
			this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
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
			this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
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
			this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
			// 
			// ContactsTableLayoutPanel
			// 
			this.ContactsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.ContactsTableLayoutPanel.Controls.Add(this.ContactPhoneMaskedTextBox, 1, 3);
			this.ContactsTableLayoutPanel.Controls.Add(this.ContactBirthDateTimePicker, 1, 2);
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
			// ContactPhoneMaskedTextBox
			// 
			this.ContactPhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ContactPhoneMaskedTextBox.Enabled = false;
			this.ContactPhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactPhoneMaskedTextBox.Location = new System.Drawing.Point(84, 112);
			this.ContactPhoneMaskedTextBox.Mask = "+7 (000) 00-00-00";
			this.ContactPhoneMaskedTextBox.Name = "ContactPhoneMaskedTextBox";
			this.ContactPhoneMaskedTextBox.Size = new System.Drawing.Size(655, 22);
			this.ContactPhoneMaskedTextBox.TabIndex = 15;
			// 
			// ContactBirthDateTimePicker
			// 
			this.ContactBirthDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactBirthDateTimePicker.Enabled = false;
			this.ContactBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactBirthDateTimePicker.Location = new System.Drawing.Point(84, 75);
			this.ContactBirthDateTimePicker.Name = "ContactBirthDateTimePicker";
			this.ContactBirthDateTimePicker.Size = new System.Drawing.Size(159, 22);
			this.ContactBirthDateTimePicker.TabIndex = 16;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1158, 25);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.ExitToolStripMenuItem.Text = "Exit (Alt + F4)";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContactToolStripMenuItem,
            this.EditContactToolStripMenuItem,
            this.RemoveContactToolStripMenuItem});
			this.EditToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
			this.EditToolStripMenuItem.Text = "Edit";
			// 
			// AddContactToolStripMenuItem
			// 
			this.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem";
			this.AddContactToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.AddContactToolStripMenuItem.Text = "Add contact";
			this.AddContactToolStripMenuItem.Click += new System.EventHandler(this.AddContactButton_Click);
			// 
			// EditContactToolStripMenuItem
			// 
			this.EditContactToolStripMenuItem.Name = "EditContactToolStripMenuItem";
			this.EditContactToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.EditContactToolStripMenuItem.Text = "Edit contact";
			this.EditContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactButton_Click);
			// 
			// RemoveContactToolStripMenuItem
			// 
			this.RemoveContactToolStripMenuItem.Name = "RemoveContactToolStripMenuItem";
			this.RemoveContactToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.RemoveContactToolStripMenuItem.Text = "Remove contact";
			this.RemoveContactToolStripMenuItem.Click += new System.EventHandler(this.RemoveContactButton_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
			this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.HelpToolStripMenuItem.Text = "Help";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.AboutToolStripMenuItem.Text = "About (F1)";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// ExclamationMarkTableLayoutPanel
			// 
			this.ExclamationMarkTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExclamationMarkTableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExclamationMarkTableLayoutPanel.BackgroundImage")));
			this.ExclamationMarkTableLayoutPanel.ColumnCount = 1;
			this.ExclamationMarkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.14815F));
			this.ExclamationMarkTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.ExclamationMarkTableLayoutPanel.MaximumSize = new System.Drawing.Size(100, 100);
			this.ExclamationMarkTableLayoutPanel.MinimumSize = new System.Drawing.Size(100, 100);
			this.ExclamationMarkTableLayoutPanel.Name = "ExclamationMarkTableLayoutPanel";
			this.ExclamationMarkTableLayoutPanel.RowCount = 1;
			this.ExclamationMarkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ExclamationMarkTableLayoutPanel.Size = new System.Drawing.Size(100, 100);
			this.ExclamationMarkTableLayoutPanel.TabIndex = 11;
			// 
			// BirthTableLayoutPanel
			// 
			this.BirthTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BirthTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BirthTableLayoutPanel.ColumnCount = 3;
			this.BirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.BirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.BirthTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 584F));
			this.BirthTableLayoutPanel.Controls.Add(this.ExclamationMarkTableLayoutPanel, 0, 0);
			this.BirthTableLayoutPanel.Controls.Add(this.BirthTextBox, 2, 2);
			this.BirthTableLayoutPanel.Controls.Add(this.BirthLabel, 2, 1);
			this.BirthTableLayoutPanel.Location = new System.Drawing.Point(413, 462);
			this.BirthTableLayoutPanel.Name = "BirthTableLayoutPanel";
			this.BirthTableLayoutPanel.RowCount = 3;
			this.BirthTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.BirthTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.BirthTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
			this.BirthTableLayoutPanel.Size = new System.Drawing.Size(727, 106);
			this.BirthTableLayoutPanel.TabIndex = 12;
			this.BirthTableLayoutPanel.Visible = false;
			// 
			// BirthTextBox
			// 
			this.BirthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BirthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BirthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BirthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BirthTextBox.Location = new System.Drawing.Point(150, 48);
			this.BirthTextBox.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
			this.BirthTextBox.Multiline = true;
			this.BirthTextBox.Name = "BirthTextBox";
			this.BirthTextBox.Size = new System.Drawing.Size(574, 55);
			this.BirthTextBox.TabIndex = 13;
			// 
			// BirthLabel
			// 
			this.BirthLabel.AutoSize = true;
			this.BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BirthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BirthLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BirthLabel.Location = new System.Drawing.Point(146, 21);
			this.BirthLabel.Name = "BirthLabel";
			this.BirthLabel.Size = new System.Drawing.Size(113, 18);
			this.BirthLabel.TabIndex = 13;
			this.BirthLabel.Text = "Birthdays today:";
			this.BirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 598);
			this.Controls.Add(this.BirthTableLayoutPanel);
			this.Controls.Add(this.ContactsTableLayoutPanel);
			this.Controls.Add(this.ContactsListBox);
			this.Controls.Add(this.RemoveContactButton);
			this.Controls.Add(this.EditContactButton);
			this.Controls.Add(this.AddContactButton);
			this.Controls.Add(this.FindLabel);
			this.Controls.Add(this.FindTextBox);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1174, 636);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ContactsApp";
			this.ContactsTableLayoutPanel.ResumeLayout(false);
			this.ContactsTableLayoutPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.BirthTableLayoutPanel.ResumeLayout(false);
			this.BirthTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox ContactPhoneMaskedTextBox;
        private System.Windows.Forms.DateTimePicker ContactBirthDateTimePicker;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel ExclamationMarkTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel BirthTableLayoutPanel;
		private System.Windows.Forms.Label BirthLabel;
		private System.Windows.Forms.TextBox BirthTextBox;
	}
}

