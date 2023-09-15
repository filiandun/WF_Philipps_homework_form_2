namespace form2
{
    partial class Form1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.completeButton);
            this.groupBox.Controls.Add(this.cityComboBox);
            this.groupBox.Controls.Add(this.countryComboBox);
            this.groupBox.Controls.Add(this.genderGroupBox);
            this.groupBox.Controls.Add(this.nameTextBox);
            this.groupBox.Controls.Add(this.surnameTextBox);
            this.groupBox.Controls.Add(this.patronymicTextBox);
            this.groupBox.Controls.Add(this.cityLabel);
            this.groupBox.Controls.Add(this.countryLabel);
            this.groupBox.Controls.Add(this.patronymicLabel);
            this.groupBox.Controls.Add(this.surnameLabel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(269, 280);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(7, 248);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(245, 23);
            this.completeButton.TabIndex = 6;
            this.completeButton.Text = "Отправить анкету";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(88, 181);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(164, 21);
            this.cityComboBox.TabIndex = 5;
            this.cityComboBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Россия",
            "Украина",
            "Казахстан",
            "США"});
            this.countryComboBox.Location = new System.Drawing.Point(88, 154);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(164, 21);
            this.countryComboBox.TabIndex = 4;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            this.countryComboBox.TextUpdate += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            this.countryComboBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(7, 104);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(256, 38);
            this.genderGroupBox.TabIndex = 8;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Пол";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleRadioButton.Location = new System.Drawing.Point(176, 15);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(69, 17);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.Text = "женский";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleRadioButton.Location = new System.Drawing.Point(81, 15);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(70, 17);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.Text = "мужской";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(88, 17);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(164, 20);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(88, 69);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(164, 20);
            this.patronymicTextBox.TabIndex = 3;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(7, 184);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "Город";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(7, 157);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Страна";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(7, 73);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(7, 24);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(301, 22);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(320, 268);
            this.resultRichTextBox.TabIndex = 1;
            this.resultRichTextBox.TabStop = false;
            this.resultRichTextBox.Text = "Фамилия:\nИмя:\nОтчество:\n\nПол: мужской\n\nСтрана:\nГород:\n";
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 305);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.groupBox);
            this.MaximumSize = new System.Drawing.Size(656, 344);
            this.MinimumSize = new System.Drawing.Size(656, 344);
            this.Name = "Form1";
            this.Text = "Анкета";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}

