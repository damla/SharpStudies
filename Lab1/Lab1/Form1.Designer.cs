namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnAge1 = new System.Windows.Forms.RadioButton();
            this.radioBtnAge2 = new System.Windows.Forms.RadioButton();
            this.cmbBoxCity = new System.Windows.Forms.ComboBox();
            this.checkBoxDance = new System.Windows.Forms.CheckBox();
            this.checkBoxCook = new System.Windows.Forms.CheckBox();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NAME:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(10, 77);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(193, 37);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(10, 194);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(227, 37);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "AGE RANGE:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(10, 244);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(104, 37);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "CITY:";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHobbies.Location = new System.Drawing.Point(10, 299);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(174, 37);
            this.lblHobbies.TabIndex = 5;
            this.lblHobbies.Text = "HOBBIES:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(10, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(169, 37);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "GENDER:";
            this.lblGender.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(255, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 31);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "<Enter your name>";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(255, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(236, 31);
            this.txtSurname.TabIndex = 7;
            this.txtSurname.Text = "<Enter your surname>";
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(4, 17);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(128, 29);
            this.radioBtnFemale.TabIndex = 8;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "FEMALE";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            this.radioBtnFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioBtnMale.Location = new System.Drawing.Point(134, 17);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(101, 29);
            this.radioBtnMale.TabIndex = 9;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "MALE";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnAge1
            // 
            this.radioBtnAge1.AutoSize = true;
            this.radioBtnAge1.Location = new System.Drawing.Point(0, 17);
            this.radioBtnAge1.Name = "radioBtnAge1";
            this.radioBtnAge1.Size = new System.Drawing.Size(86, 29);
            this.radioBtnAge1.TabIndex = 10;
            this.radioBtnAge1.TabStop = true;
            this.radioBtnAge1.Text = "0-35";
            this.radioBtnAge1.UseVisualStyleBackColor = true;
            // 
            // radioBtnAge2
            // 
            this.radioBtnAge2.AutoSize = true;
            this.radioBtnAge2.Location = new System.Drawing.Point(130, 17);
            this.radioBtnAge2.Name = "radioBtnAge2";
            this.radioBtnAge2.Size = new System.Drawing.Size(98, 29);
            this.radioBtnAge2.TabIndex = 11;
            this.radioBtnAge2.TabStop = true;
            this.radioBtnAge2.Text = "35-70";
            this.radioBtnAge2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxCity
            // 
            this.cmbBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCity.FormattingEnabled = true;
            this.cmbBoxCity.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "Kocaeli",
            "Kayseri",
            "Trabzon"});
            this.cmbBoxCity.Location = new System.Drawing.Point(255, 244);
            this.cmbBoxCity.Name = "cmbBoxCity";
            this.cmbBoxCity.Size = new System.Drawing.Size(236, 33);
            this.cmbBoxCity.TabIndex = 12;
            this.cmbBoxCity.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCity_SelectedIndexChanged);
            // 
            // checkBoxDance
            // 
            this.checkBoxDance.AutoSize = true;
            this.checkBoxDance.Location = new System.Drawing.Point(207, 299);
            this.checkBoxDance.Name = "checkBoxDance";
            this.checkBoxDance.Size = new System.Drawing.Size(106, 29);
            this.checkBoxDance.TabIndex = 13;
            this.checkBoxDance.Text = "Dance";
            this.checkBoxDance.UseVisualStyleBackColor = true;
            // 
            // checkBoxCook
            // 
            this.checkBoxCook.AutoSize = true;
            this.checkBoxCook.Location = new System.Drawing.Point(422, 299);
            this.checkBoxCook.Name = "checkBoxCook";
            this.checkBoxCook.Size = new System.Drawing.Size(94, 29);
            this.checkBoxCook.TabIndex = 14;
            this.checkBoxCook.Text = "Cook";
            this.checkBoxCook.UseVisualStyleBackColor = true;
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Location = new System.Drawing.Point(313, 299);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(101, 29);
            this.checkBoxMusic.TabIndex = 15;
            this.checkBoxMusic.Text = "Music";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(38, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 77);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(291, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 77);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.radioBtnMale);
            this.groupGender.Controls.Add(this.radioBtnFemale);
            this.groupGender.Location = new System.Drawing.Point(255, 114);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(237, 54);
            this.groupGender.TabIndex = 18;
            this.groupGender.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnAge1);
            this.groupBox1.Controls.Add(this.radioBtnAge2);
            this.groupBox1.Location = new System.Drawing.Point(259, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 54);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 510);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxMusic);
            this.Controls.Add(this.checkBoxCook);
            this.Controls.Add(this.checkBoxDance);
            this.Controls.Add(this.cmbBoxCity);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Information Form";
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnAge1;
        private System.Windows.Forms.RadioButton radioBtnAge2;
        private System.Windows.Forms.ComboBox cmbBoxCity;
        private System.Windows.Forms.CheckBox checkBoxDance;
        private System.Windows.Forms.CheckBox checkBoxCook;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

