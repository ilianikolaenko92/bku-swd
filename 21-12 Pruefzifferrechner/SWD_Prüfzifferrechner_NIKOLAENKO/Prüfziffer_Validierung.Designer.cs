namespace SWD_Prüfzifferrechner_NIKOLAENKO
{
    partial class Prüfziffer_Validierung
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
            this.groupBox1_card_data = new System.Windows.Forms.GroupBox();
            this.validation_label1 = new System.Windows.Forms.Label();
            this.label1_card_nr = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1_check_cardnr = new System.Windows.Forms.Button();
            this.button2_calculate_security_nr = new System.Windows.Forms.Button();
            this.groupBox1_card_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_card_data
            // 
            this.groupBox1_card_data.Controls.Add(this.validation_label1);
            this.groupBox1_card_data.Controls.Add(this.label1_card_nr);
            this.groupBox1_card_data.Controls.Add(this.maskedTextBox1);
            this.groupBox1_card_data.Location = new System.Drawing.Point(38, 39);
            this.groupBox1_card_data.Name = "groupBox1_card_data";
            this.groupBox1_card_data.Size = new System.Drawing.Size(719, 137);
            this.groupBox1_card_data.TabIndex = 0;
            this.groupBox1_card_data.TabStop = false;
            this.groupBox1_card_data.Text = "Kartendaten";
            // 
            // validation_label1
            // 
            this.validation_label1.AutoSize = true;
            this.validation_label1.Location = new System.Drawing.Point(7, 91);
            this.validation_label1.Name = "validation_label1";
            this.validation_label1.Size = new System.Drawing.Size(131, 17);
            this.validation_label1.TabIndex = 2;
            this.validation_label1.Text = "Feedback message";
            // 
            // label1_card_nr
            // 
            this.label1_card_nr.AutoSize = true;
            this.label1_card_nr.Location = new System.Drawing.Point(7, 31);
            this.label1_card_nr.Name = "label1_card_nr";
            this.label1_card_nr.Size = new System.Drawing.Size(276, 17);
            this.label1_card_nr.TabIndex = 1;
            this.label1_card_nr.Text = "Geben Sie die Nummer der Kreditkarte ein";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowPromptAsInput = false;
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(7, 54);
            this.maskedTextBox1.Mask = "0000,0000,0000,0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(341, 30);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // button1_check_cardnr
            // 
            this.button1_check_cardnr.BackColor = System.Drawing.Color.LimeGreen;
            this.button1_check_cardnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_check_cardnr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1_check_cardnr.Location = new System.Drawing.Point(48, 183);
            this.button1_check_cardnr.Name = "button1_check_cardnr";
            this.button1_check_cardnr.Size = new System.Drawing.Size(157, 53);
            this.button1_check_cardnr.TabIndex = 1;
            this.button1_check_cardnr.Text = "Prüfziffer validieren";
            this.button1_check_cardnr.UseVisualStyleBackColor = false;
            this.button1_check_cardnr.Click += new System.EventHandler(this.button1_check_cardnr_Click);
            // 
            // button2_calculate_security_nr
            // 
            this.button2_calculate_security_nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_calculate_security_nr.Location = new System.Drawing.Point(211, 183);
            this.button2_calculate_security_nr.Name = "button2_calculate_security_nr";
            this.button2_calculate_security_nr.Size = new System.Drawing.Size(157, 53);
            this.button2_calculate_security_nr.TabIndex = 2;
            this.button2_calculate_security_nr.Text = "Prüfziffer berechnen";
            this.button2_calculate_security_nr.UseVisualStyleBackColor = true;
            this.button2_calculate_security_nr.Click += new System.EventHandler(this.button2_calculate_security_nr_Click);
            // 
            // Prüfziffer_Validierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_calculate_security_nr);
            this.Controls.Add(this.button1_check_cardnr);
            this.Controls.Add(this.groupBox1_card_data);
            this.Name = "Prüfziffer_Validierung";
            this.Text = "Luhn-Algorhytmus - Prüfziffer Validierung 2022";
            this.groupBox1_card_data.ResumeLayout(false);
            this.groupBox1_card_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_card_data;
        private System.Windows.Forms.Label label1_card_nr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1_check_cardnr;
        private System.Windows.Forms.Button button2_calculate_security_nr;
        private System.Windows.Forms.Label validation_label1;
    }
}

