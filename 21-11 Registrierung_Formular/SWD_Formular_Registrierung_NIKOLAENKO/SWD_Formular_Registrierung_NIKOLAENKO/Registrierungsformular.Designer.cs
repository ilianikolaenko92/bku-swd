namespace SWD_Formular_Registrierung_NIKOLAENKO
{
    partial class Registrierungsformular
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
            this.main_header_label = new System.Windows.Forms.Label();
            this.input1_name = new System.Windows.Forms.TextBox();
            this.label1_name = new System.Windows.Forms.Label();
            this.label2_lastname = new System.Windows.Forms.Label();
            this.input2_lastname = new System.Windows.Forms.TextBox();
            this.input3_address = new System.Windows.Forms.TextBox();
            this.label3_address = new System.Windows.Forms.Label();
            this.input4_city = new System.Windows.Forms.TextBox();
            this.label4_city = new System.Windows.Forms.Label();
            this.label5_postindex = new System.Windows.Forms.Label();
            this.masked_input5_postinx = new System.Windows.Forms.MaskedTextBox();
            this.input6_username = new System.Windows.Forms.TextBox();
            this.label6_username = new System.Windows.Forms.Label();
            this.input7_password = new System.Windows.Forms.TextBox();
            this.label7_password = new System.Windows.Forms.Label();
            this.input8_sex = new System.Windows.Forms.ComboBox();
            this.label8_sex = new System.Windows.Forms.Label();
            this.label9_birthday = new System.Windows.Forms.Label();
            this.input9_birthday = new System.Windows.Forms.MaskedTextBox();
            this.button1_register = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1_personal_data = new System.Windows.Forms.GroupBox();
            this.error_label2_lastname = new System.Windows.Forms.Label();
            this.error_label1_name = new System.Windows.Forms.Label();
            this.groupBox2_address = new System.Windows.Forms.GroupBox();
            this.error_label4_cityname = new System.Windows.Forms.Label();
            this.error_label3_address = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2_show_password = new System.Windows.Forms.Button();
            this.error_label5_password = new System.Windows.Forms.Label();
            this.groupBox1_personal_data.SuspendLayout();
            this.groupBox2_address.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_header_label
            // 
            this.main_header_label.AutoSize = true;
            this.main_header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_header_label.Location = new System.Drawing.Point(28, 20);
            this.main_header_label.Name = "main_header_label";
            this.main_header_label.Size = new System.Drawing.Size(244, 29);
            this.main_header_label.TabIndex = 0;
            this.main_header_label.Text = "Benutzerregistrierung";
            // 
            // input1_name
            // 
            this.input1_name.Location = new System.Drawing.Point(13, 54);
            this.input1_name.MaxLength = 20;
            this.input1_name.Name = "input1_name";
            this.input1_name.Size = new System.Drawing.Size(313, 22);
            this.input1_name.TabIndex = 1;
            this.input1_name.TextChanged += new System.EventHandler(this.input1_name_TextChanged);
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Location = new System.Drawing.Point(13, 31);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(70, 17);
            this.label1_name.TabIndex = 2;
            this.label1_name.Text = "Vorname*";
            // 
            // label2_lastname
            // 
            this.label2_lastname.AutoSize = true;
            this.label2_lastname.Location = new System.Drawing.Point(13, 101);
            this.label2_lastname.Name = "label2_lastname";
            this.label2_lastname.Size = new System.Drawing.Size(81, 17);
            this.label2_lastname.TabIndex = 3;
            this.label2_lastname.Text = "Nachname*";
            // 
            // input2_lastname
            // 
            this.input2_lastname.Location = new System.Drawing.Point(13, 121);
            this.input2_lastname.MaxLength = 30;
            this.input2_lastname.Name = "input2_lastname";
            this.input2_lastname.Size = new System.Drawing.Size(313, 22);
            this.input2_lastname.TabIndex = 4;
            this.input2_lastname.TextChanged += new System.EventHandler(this.input2_lastname_TextChanged);
            // 
            // input3_address
            // 
            this.input3_address.Location = new System.Drawing.Point(13, 48);
            this.input3_address.MaxLength = 40;
            this.input3_address.Name = "input3_address";
            this.input3_address.Size = new System.Drawing.Size(313, 22);
            this.input3_address.TabIndex = 9;
            this.input3_address.TextChanged += new System.EventHandler(this.input3_address_TextChanged);
            // 
            // label3_address
            // 
            this.label3_address.AutoSize = true;
            this.label3_address.Location = new System.Drawing.Point(13, 28);
            this.label3_address.Name = "label3_address";
            this.label3_address.Size = new System.Drawing.Size(115, 17);
            this.label3_address.TabIndex = 10;
            this.label3_address.Text = "Strasse, Hausnr*";
            // 
            // input4_city
            // 
            this.input4_city.Location = new System.Drawing.Point(13, 111);
            this.input4_city.MaxLength = 15;
            this.input4_city.Name = "input4_city";
            this.input4_city.Size = new System.Drawing.Size(185, 22);
            this.input4_city.TabIndex = 5;
            this.input4_city.TextChanged += new System.EventHandler(this.input4_city_TextChanged);
            // 
            // label4_city
            // 
            this.label4_city.AutoSize = true;
            this.label4_city.Location = new System.Drawing.Point(13, 91);
            this.label4_city.Name = "label4_city";
            this.label4_city.Size = new System.Drawing.Size(67, 17);
            this.label4_city.TabIndex = 6;
            this.label4_city.Text = "Wohnort*";
            // 
            // label5_postindex
            // 
            this.label5_postindex.AutoSize = true;
            this.label5_postindex.Location = new System.Drawing.Point(223, 91);
            this.label5_postindex.Name = "label5_postindex";
            this.label5_postindex.Size = new System.Drawing.Size(39, 17);
            this.label5_postindex.TabIndex = 7;
            this.label5_postindex.Text = "PLZ*";
            // 
            // masked_input5_postinx
            // 
            this.masked_input5_postinx.Location = new System.Drawing.Point(226, 111);
            this.masked_input5_postinx.Mask = "00000";
            this.masked_input5_postinx.Name = "masked_input5_postinx";
            this.masked_input5_postinx.Size = new System.Drawing.Size(100, 22);
            this.masked_input5_postinx.TabIndex = 15;
            // 
            // input6_username
            // 
            this.input6_username.Location = new System.Drawing.Point(10, 32);
            this.input6_username.MaxLength = 50;
            this.input6_username.Name = "input6_username";
            this.input6_username.ReadOnly = true;
            this.input6_username.Size = new System.Drawing.Size(185, 22);
            this.input6_username.TabIndex = 11;
            // 
            // label6_username
            // 
            this.label6_username.AutoSize = true;
            this.label6_username.Location = new System.Drawing.Point(10, 12);
            this.label6_username.Name = "label6_username";
            this.label6_username.Size = new System.Drawing.Size(105, 17);
            this.label6_username.TabIndex = 12;
            this.label6_username.Text = "Benutzername*";
            // 
            // input7_password
            // 
            this.input7_password.Location = new System.Drawing.Point(10, 81);
            this.input7_password.Name = "input7_password";
            this.input7_password.Size = new System.Drawing.Size(185, 22);
            this.input7_password.TabIndex = 13;
            this.input7_password.UseSystemPasswordChar = true;
            this.input7_password.TextChanged += new System.EventHandler(this.input7_password_TextChanged);
            // 
            // label7_password
            // 
            this.label7_password.AutoSize = true;
            this.label7_password.Location = new System.Drawing.Point(10, 60);
            this.label7_password.Name = "label7_password";
            this.label7_password.Size = new System.Drawing.Size(70, 17);
            this.label7_password.TabIndex = 14;
            this.label7_password.Text = "Passwort*";
            this.label7_password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input8_sex
            // 
            this.input8_sex.FormattingEnabled = true;
            this.input8_sex.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich",
            "Divers"});
            this.input8_sex.Location = new System.Drawing.Point(352, 52);
            this.input8_sex.Name = "input8_sex";
            this.input8_sex.Size = new System.Drawing.Size(121, 24);
            this.input8_sex.TabIndex = 19;
            // 
            // label8_sex
            // 
            this.label8_sex.AutoSize = true;
            this.label8_sex.Location = new System.Drawing.Point(352, 30);
            this.label8_sex.Name = "label8_sex";
            this.label8_sex.Size = new System.Drawing.Size(84, 17);
            this.label8_sex.TabIndex = 20;
            this.label8_sex.Text = "Geschlecht*";
            // 
            // label9_birthday
            // 
            this.label9_birthday.AutoSize = true;
            this.label9_birthday.Location = new System.Drawing.Point(355, 100);
            this.label9_birthday.Name = "label9_birthday";
            this.label9_birthday.Size = new System.Drawing.Size(103, 17);
            this.label9_birthday.TabIndex = 22;
            this.label9_birthday.Text = "Geburtsdatum*";
            // 
            // input9_birthday
            // 
            this.input9_birthday.Location = new System.Drawing.Point(355, 120);
            this.input9_birthday.Mask = "00/00/0000";
            this.input9_birthday.Name = "input9_birthday";
            this.input9_birthday.Size = new System.Drawing.Size(118, 22);
            this.input9_birthday.TabIndex = 21;
            this.input9_birthday.ValidatingType = typeof(System.DateTime);
            // 
            // button1_register
            // 
            this.button1_register.Enabled = false;
            this.button1_register.Location = new System.Drawing.Point(43, 620);
            this.button1_register.Name = "button1_register";
            this.button1_register.Size = new System.Drawing.Size(185, 40);
            this.button1_register.TabIndex = 23;
            this.button1_register.Text = "Anmelden";
            this.button1_register.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link zu AGBs";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(314, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Ich habe die AGB gelesen und akzeptiere sie";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1_personal_data
            // 
            this.groupBox1_personal_data.Controls.Add(this.error_label2_lastname);
            this.groupBox1_personal_data.Controls.Add(this.error_label1_name);
            this.groupBox1_personal_data.Controls.Add(this.input1_name);
            this.groupBox1_personal_data.Controls.Add(this.label1_name);
            this.groupBox1_personal_data.Controls.Add(this.label9_birthday);
            this.groupBox1_personal_data.Controls.Add(this.label2_lastname);
            this.groupBox1_personal_data.Controls.Add(this.input9_birthday);
            this.groupBox1_personal_data.Controls.Add(this.input2_lastname);
            this.groupBox1_personal_data.Controls.Add(this.label8_sex);
            this.groupBox1_personal_data.Controls.Add(this.input8_sex);
            this.groupBox1_personal_data.Location = new System.Drawing.Point(33, 77);
            this.groupBox1_personal_data.Name = "groupBox1_personal_data";
            this.groupBox1_personal_data.Size = new System.Drawing.Size(490, 172);
            this.groupBox1_personal_data.TabIndex = 24;
            this.groupBox1_personal_data.TabStop = false;
            this.groupBox1_personal_data.Text = "Persönliche Daten";
            // 
            // error_label2_lastname
            // 
            this.error_label2_lastname.AutoSize = true;
            this.error_label2_lastname.ForeColor = System.Drawing.Color.Red;
            this.error_label2_lastname.Location = new System.Drawing.Point(13, 146);
            this.error_label2_lastname.Name = "error_label2_lastname";
            this.error_label2_lastname.Size = new System.Drawing.Size(272, 17);
            this.error_label2_lastname.TabIndex = 24;
            this.error_label2_lastname.Text = "Nachname darf nur Buchstaben enthalten";
            this.error_label2_lastname.Visible = false;
            // 
            // error_label1_name
            // 
            this.error_label1_name.AutoSize = true;
            this.error_label1_name.ForeColor = System.Drawing.Color.Red;
            this.error_label1_name.Location = new System.Drawing.Point(13, 79);
            this.error_label1_name.Name = "error_label1_name";
            this.error_label1_name.Size = new System.Drawing.Size(261, 17);
            this.error_label1_name.TabIndex = 23;
            this.error_label1_name.Text = "Vorname darf nur Buchstaben enthalten";
            this.error_label1_name.Visible = false;
            // 
            // groupBox2_address
            // 
            this.groupBox2_address.Controls.Add(this.error_label4_cityname);
            this.groupBox2_address.Controls.Add(this.error_label3_address);
            this.groupBox2_address.Controls.Add(this.input4_city);
            this.groupBox2_address.Controls.Add(this.label4_city);
            this.groupBox2_address.Controls.Add(this.label5_postindex);
            this.groupBox2_address.Controls.Add(this.input3_address);
            this.groupBox2_address.Controls.Add(this.label3_address);
            this.groupBox2_address.Controls.Add(this.masked_input5_postinx);
            this.groupBox2_address.Location = new System.Drawing.Point(33, 255);
            this.groupBox2_address.Name = "groupBox2_address";
            this.groupBox2_address.Size = new System.Drawing.Size(490, 158);
            this.groupBox2_address.TabIndex = 23;
            this.groupBox2_address.TabStop = false;
            this.groupBox2_address.Text = "Adresse";
            // 
            // error_label4_cityname
            // 
            this.error_label4_cityname.AutoSize = true;
            this.error_label4_cityname.ForeColor = System.Drawing.Color.Red;
            this.error_label4_cityname.Location = new System.Drawing.Point(13, 136);
            this.error_label4_cityname.Name = "error_label4_cityname";
            this.error_label4_cityname.Size = new System.Drawing.Size(313, 17);
            this.error_label4_cityname.TabIndex = 26;
            this.error_label4_cityname.Text = "Ortsname darf nur Buchstaben und \"-\" enthalten";
            this.error_label4_cityname.Visible = false;
            // 
            // error_label3_address
            // 
            this.error_label3_address.AutoSize = true;
            this.error_label3_address.ForeColor = System.Drawing.Color.Red;
            this.error_label3_address.Location = new System.Drawing.Point(13, 73);
            this.error_label3_address.Name = "error_label3_address";
            this.error_label3_address.Size = new System.Drawing.Size(464, 17);
            this.error_label3_address.TabIndex = 25;
            this.error_label3_address.Text = "Straßennamen ohne Ziffern eingeben, Hausnummer mit Komma trennen";
            this.error_label3_address.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2_show_password);
            this.panel1.Controls.Add(this.error_label5_password);
            this.panel1.Controls.Add(this.label6_username);
            this.panel1.Controls.Add(this.input6_username);
            this.panel1.Controls.Add(this.input7_password);
            this.panel1.Controls.Add(this.label7_password);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(33, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 184);
            this.panel1.TabIndex = 25;
            // 
            // button2_show_password
            // 
            this.button2_show_password.Location = new System.Drawing.Point(201, 80);
            this.button2_show_password.Name = "button2_show_password";
            this.button2_show_password.Size = new System.Drawing.Size(38, 23);
            this.button2_show_password.TabIndex = 28;
            this.button2_show_password.UseVisualStyleBackColor = true;
            this.button2_show_password.Click += new System.EventHandler(this.button2_show_password_Click);
            // 
            // error_label5_password
            // 
            this.error_label5_password.AutoSize = true;
            this.error_label5_password.ForeColor = System.Drawing.Color.Red;
            this.error_label5_password.Location = new System.Drawing.Point(7, 106);
            this.error_label5_password.Name = "error_label5_password";
            this.error_label5_password.Size = new System.Drawing.Size(406, 17);
            this.error_label5_password.TabIndex = 27;
            this.error_label5_password.Text = "Kennwort muss mdst. 7 Symbole inkl. Sonderzeichen enthalten!";
            this.error_label5_password.Visible = false;
            // 
            // Registrierungsformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2_address);
            this.Controls.Add(this.groupBox1_personal_data);
            this.Controls.Add(this.button1_register);
            this.Controls.Add(this.main_header_label);
            this.Name = "Registrierungsformular";
            this.Text = "Registrierung neues Benutzers";
            this.groupBox1_personal_data.ResumeLayout(false);
            this.groupBox1_personal_data.PerformLayout();
            this.groupBox2_address.ResumeLayout(false);
            this.groupBox2_address.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_header_label;
        private System.Windows.Forms.TextBox input1_name;
        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.Label label2_lastname;
        private System.Windows.Forms.TextBox input2_lastname;
        private System.Windows.Forms.TextBox input4_city;
        private System.Windows.Forms.Label label4_city;
        private System.Windows.Forms.Label label5_postindex;
        private System.Windows.Forms.TextBox input3_address;
        private System.Windows.Forms.Label label3_address;
        private System.Windows.Forms.TextBox input6_username;
        private System.Windows.Forms.Label label6_username;
        private System.Windows.Forms.TextBox input7_password;
        private System.Windows.Forms.Label label7_password;
        private System.Windows.Forms.MaskedTextBox masked_input5_postinx;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox input8_sex;
        private System.Windows.Forms.Label label8_sex;
        private System.Windows.Forms.MaskedTextBox input9_birthday;
        private System.Windows.Forms.Label label9_birthday;
        private System.Windows.Forms.Button button1_register;
        private System.Windows.Forms.GroupBox groupBox1_personal_data;
        private System.Windows.Forms.GroupBox groupBox2_address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label error_label1_name;
        private System.Windows.Forms.Label error_label2_lastname;
        private System.Windows.Forms.Label error_label3_address;
        private System.Windows.Forms.Label error_label4_cityname;
        private System.Windows.Forms.Label error_label5_password;
        private System.Windows.Forms.Button button2_show_password;
    }
}

