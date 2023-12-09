
namespace CourseWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RegistrationOfParticipants = new System.Windows.Forms.TabPage();
            this.RegParticipant = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegistrtionOfExhibit = new System.Windows.Forms.TabPage();
            this.RegExhibit = new System.Windows.Forms.Button();
            this.ExBirthBox = new System.Windows.Forms.NumericUpDown();
            this.ExOriginalityBox = new System.Windows.Forms.ComboBox();
            this.ExEraBox = new System.Windows.Forms.ComboBox();
            this.ExNameBox = new System.Windows.Forms.TextBox();
            this.ExBirth = new System.Windows.Forms.Label();
            this.ExOriginality = new System.Windows.Forms.Label();
            this.ExEra = new System.Windows.Forms.Label();
            this.ExName = new System.Windows.Forms.Label();
            this.ListOfAllParticipants = new System.Windows.Forms.TabPage();
            this.ExDisplay = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Display = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegistrationOfParticipants.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RegistrtionOfExhibit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExBirthBox)).BeginInit();
            this.ListOfAllParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationOfParticipants
            // 
            this.RegistrationOfParticipants.Controls.Add(this.RegParticipant);
            this.RegistrationOfParticipants.Controls.Add(this.label4);
            this.RegistrationOfParticipants.Controls.Add(this.label2);
            this.RegistrationOfParticipants.Controls.Add(this.label1);
            this.RegistrationOfParticipants.Controls.Add(this.Lastname);
            this.RegistrationOfParticipants.Controls.Add(this.Surname);
            this.RegistrationOfParticipants.Controls.Add(this.Firstname);
            this.RegistrationOfParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationOfParticipants.Location = new System.Drawing.Point(4, 22);
            this.RegistrationOfParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrationOfParticipants.Name = "RegistrationOfParticipants";
            this.RegistrationOfParticipants.Padding = new System.Windows.Forms.Padding(4);
            this.RegistrationOfParticipants.Size = new System.Drawing.Size(1342, 548);
            this.RegistrationOfParticipants.TabIndex = 3;
            this.RegistrationOfParticipants.Text = "Регистрация посетителей";
            this.RegistrationOfParticipants.UseVisualStyleBackColor = true;
            this.RegistrationOfParticipants.Click += new System.EventHandler(this.RegistrationOfParticipants_Click);
            // 
            // RegParticipant
            // 
            this.RegParticipant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegParticipant.Location = new System.Drawing.Point(599, 306);
            this.RegParticipant.Margin = new System.Windows.Forms.Padding(4);
            this.RegParticipant.Name = "RegParticipant";
            this.RegParticipant.Size = new System.Drawing.Size(227, 32);
            this.RegParticipant.TabIndex = 12;
            this.RegParticipant.Text = "Зарегистрировать";
            this.RegParticipant.UseVisualStyleBackColor = false;
            this.RegParticipant.Click += new System.EventHandler(this.RegParticipant_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(516, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(518, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(553, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // Lastname
            // 
            this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastname.Location = new System.Drawing.Point(599, 270);
            this.Lastname.Margin = new System.Windows.Forms.Padding(4);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(225, 24);
            this.Lastname.TabIndex = 2;
            this.Lastname.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // Surname
            // 
            this.Surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Surname.Location = new System.Drawing.Point(599, 193);
            this.Surname.Margin = new System.Windows.Forms.Padding(4);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(225, 24);
            this.Surname.TabIndex = 1;
            this.Surname.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // Firstname
            // 
            this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname.Location = new System.Drawing.Point(599, 231);
            this.Firstname.Margin = new System.Windows.Forms.Padding(4);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(225, 24);
            this.Firstname.TabIndex = 0;
            this.Firstname.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.RegistrationOfParticipants);
            this.tabControl1.Controls.Add(this.RegistrtionOfExhibit);
            this.tabControl1.Controls.Add(this.ListOfAllParticipants);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(77, 18);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 574);
            this.tabControl1.TabIndex = 0;
            // 
            // RegistrtionOfExhibit
            // 
            this.RegistrtionOfExhibit.Controls.Add(this.RegExhibit);
            this.RegistrtionOfExhibit.Controls.Add(this.ExBirthBox);
            this.RegistrtionOfExhibit.Controls.Add(this.ExOriginalityBox);
            this.RegistrtionOfExhibit.Controls.Add(this.ExEraBox);
            this.RegistrtionOfExhibit.Controls.Add(this.ExNameBox);
            this.RegistrtionOfExhibit.Controls.Add(this.ExBirth);
            this.RegistrtionOfExhibit.Controls.Add(this.ExOriginality);
            this.RegistrtionOfExhibit.Controls.Add(this.ExEra);
            this.RegistrtionOfExhibit.Controls.Add(this.ExName);
            this.RegistrtionOfExhibit.Location = new System.Drawing.Point(4, 22);
            this.RegistrtionOfExhibit.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrtionOfExhibit.Name = "RegistrtionOfExhibit";
            this.RegistrtionOfExhibit.Size = new System.Drawing.Size(1342, 548);
            this.RegistrtionOfExhibit.TabIndex = 5;
            this.RegistrtionOfExhibit.Text = "Регистрация экспонатов";
            this.RegistrtionOfExhibit.UseVisualStyleBackColor = true;
            // 
            // RegExhibit
            // 
            this.RegExhibit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegExhibit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegExhibit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegExhibit.Location = new System.Drawing.Point(622, 338);
            this.RegExhibit.Margin = new System.Windows.Forms.Padding(4);
            this.RegExhibit.Name = "RegExhibit";
            this.RegExhibit.Size = new System.Drawing.Size(227, 32);
            this.RegExhibit.TabIndex = 13;
            this.RegExhibit.Text = "Зарегистрировать";
            this.RegExhibit.UseVisualStyleBackColor = false;
            this.RegExhibit.Click += new System.EventHandler(this.RegExhibit_Click);
            // 
            // ExBirthBox
            // 
            this.ExBirthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExBirthBox.Location = new System.Drawing.Point(622, 287);
            this.ExBirthBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExBirthBox.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.ExBirthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExBirthBox.Name = "ExBirthBox";
            this.ExBirthBox.Size = new System.Drawing.Size(227, 24);
            this.ExBirthBox.TabIndex = 7;
            this.ExBirthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExBirthBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ExOriginalityBox
            // 
            this.ExOriginalityBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExOriginalityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExOriginalityBox.FormattingEnabled = true;
            this.ExOriginalityBox.Items.AddRange(new object[] {
            "Оригинал",
            "Копия"});
            this.ExOriginalityBox.Location = new System.Drawing.Point(622, 253);
            this.ExOriginalityBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExOriginalityBox.Name = "ExOriginalityBox";
            this.ExOriginalityBox.Size = new System.Drawing.Size(227, 26);
            this.ExOriginalityBox.TabIndex = 6;
            this.ExOriginalityBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.ExOriginalityBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // ExEraBox
            // 
            this.ExEraBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExEraBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExEraBox.FormattingEnabled = true;
            this.ExEraBox.Items.AddRange(new object[] {
            "Искусство античности",
            "Средневековье",
            "Возрождение",
            "Новое время",
            "Модернизм",
            "Стили XX века",
            "Контемпорари-арт"});
            this.ExEraBox.Location = new System.Drawing.Point(622, 219);
            this.ExEraBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExEraBox.Name = "ExEraBox";
            this.ExEraBox.Size = new System.Drawing.Size(227, 26);
            this.ExEraBox.TabIndex = 5;
            this.ExEraBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // ExNameBox
            // 
            this.ExNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExNameBox.Location = new System.Drawing.Point(622, 186);
            this.ExNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExNameBox.Name = "ExNameBox";
            this.ExNameBox.Size = new System.Drawing.Size(227, 24);
            this.ExNameBox.TabIndex = 4;
            this.ExNameBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // ExBirth
            // 
            this.ExBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExBirth.AutoSize = true;
            this.ExBirth.Location = new System.Drawing.Point(509, 289);
            this.ExBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExBirth.Name = "ExBirth";
            this.ExBirth.Size = new System.Drawing.Size(105, 18);
            this.ExBirth.TabIndex = 3;
            this.ExBirth.Text = "Год создания";
            // 
            // ExOriginality
            // 
            this.ExOriginality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExOriginality.AutoSize = true;
            this.ExOriginality.Location = new System.Drawing.Point(512, 256);
            this.ExOriginality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExOriginality.Name = "ExOriginality";
            this.ExOriginality.Size = new System.Drawing.Size(102, 18);
            this.ExOriginality.TabIndex = 2;
            this.ExOriginality.Text = "Подлинность";
            // 
            // ExEra
            // 
            this.ExEra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExEra.AutoSize = true;
            this.ExEra.Location = new System.Drawing.Point(563, 222);
            this.ExEra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExEra.Name = "ExEra";
            this.ExEra.Size = new System.Drawing.Size(51, 18);
            this.ExEra.TabIndex = 1;
            this.ExEra.Text = "Эпоха";
            // 
            // ExName
            // 
            this.ExName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExName.AutoSize = true;
            this.ExName.Location = new System.Drawing.Point(539, 189);
            this.ExName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExName.Name = "ExName";
            this.ExName.Size = new System.Drawing.Size(75, 18);
            this.ExName.TabIndex = 0;
            this.ExName.Text = "Название";
            // 
            // ListOfAllParticipants
            // 
            this.ListOfAllParticipants.Controls.Add(this.ExDisplay);
            this.ListOfAllParticipants.Controls.Add(this.Display);
            this.ListOfAllParticipants.Location = new System.Drawing.Point(4, 22);
            this.ListOfAllParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.ListOfAllParticipants.Name = "ListOfAllParticipants";
            this.ListOfAllParticipants.Padding = new System.Windows.Forms.Padding(4);
            this.ListOfAllParticipants.Size = new System.Drawing.Size(1342, 548);
            this.ListOfAllParticipants.TabIndex = 4;
            this.ListOfAllParticipants.Text = "Список всех посетителей и экспонатов";
            this.ListOfAllParticipants.UseVisualStyleBackColor = true;
            // 
            // ExDisplay
            // 
            this.ExDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9});
            this.ExDisplay.HideSelection = false;
            this.ExDisplay.Location = new System.Drawing.Point(708, 4);
            this.ExDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.ExDisplay.Name = "ExDisplay";
            this.ExDisplay.Size = new System.Drawing.Size(630, 540);
            this.ExDisplay.TabIndex = 1;
            this.ExDisplay.UseCompatibleStateImageBehavior = false;
            this.ExDisplay.View = System.Windows.Forms.View.Details;
            this.ExDisplay.SelectedIndexChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
            this.ExDisplay.VisibleChanged += new System.EventHandler(this.Display_SelectedIndexChangedE);
            this.ExDisplay.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ExDisplay_ColumnClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 27;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Эпоха";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Подлинность";
            this.columnHeader7.Width = 121;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Год создания";
            this.columnHeader9.Width = 155;
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader10});
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(4, 4);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(696, 540);
            this.Display.TabIndex = 0;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.Details;
            this.Display.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Display_ColumnClick);
            this.Display.SelectedIndexChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
            this.Display.VisibleChanged += new System.EventHandler(this.Display_SelectedIndexChangedP);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Дата и время посещения";
            this.columnHeader10.Width = 206;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музей";
            this.RegistrationOfParticipants.ResumeLayout(false);
            this.RegistrationOfParticipants.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RegistrtionOfExhibit.ResumeLayout(false);
            this.RegistrtionOfExhibit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExBirthBox)).EndInit();
            this.ListOfAllParticipants.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage RegistrationOfParticipants;
		private System.Windows.Forms.TextBox Lastname;
		private System.Windows.Forms.TextBox Surname;
		private System.Windows.Forms.TextBox Firstname;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RegParticipant;
		private System.Windows.Forms.TabPage ListOfAllParticipants;
		private System.Windows.Forms.ListView Display;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage RegistrtionOfExhibit;
        private System.Windows.Forms.Button RegExhibit;
        private System.Windows.Forms.NumericUpDown ExBirthBox;
        private System.Windows.Forms.ComboBox ExOriginalityBox;
        private System.Windows.Forms.ComboBox ExEraBox;
        private System.Windows.Forms.TextBox ExNameBox;
        private System.Windows.Forms.Label ExBirth;
        private System.Windows.Forms.Label ExOriginality;
        private System.Windows.Forms.Label ExEra;
        private System.Windows.Forms.Label ExName;
        private System.Windows.Forms.ListView ExDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

