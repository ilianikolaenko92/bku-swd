namespace IP_Validierung_SWD
{
    partial class IP_Validierung
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
            this.maskedTextBox1_Subnetmask = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2_ip1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3_ip2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_ip1 = new System.Windows.Forms.Label();
            this.label3_ip2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4_ip2_label = new System.Windows.Forms.Label();
            this.label3_ip1_label = new System.Windows.Forms.Label();
            this.label4_result = new System.Windows.Forms.Label();
            this.label2_subnetmask_label = new System.Windows.Forms.Label();
            this.listView1_ip1 = new System.Windows.Forms.ListView();
            this.listView2_ip2 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1_Subnetmask
            // 
            this.maskedTextBox1_Subnetmask.Location = new System.Drawing.Point(39, 38);
            this.maskedTextBox1_Subnetmask.Mask = "099,099,099,099";
            this.maskedTextBox1_Subnetmask.Name = "maskedTextBox1_Subnetmask";
            this.maskedTextBox1_Subnetmask.Size = new System.Drawing.Size(265, 22);
            this.maskedTextBox1_Subnetmask.TabIndex = 0;
            this.maskedTextBox1_Subnetmask.Text = "2552552550";
            this.maskedTextBox1_Subnetmask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_MaskInputRejected);
            this.maskedTextBox1_Subnetmask.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            this.maskedTextBox1_Subnetmask.Validated += new System.EventHandler(this.maskedTextBox_Validated);
            // 
            // maskedTextBox2_ip1
            // 
            this.maskedTextBox2_ip1.Location = new System.Drawing.Point(6, 54);
            this.maskedTextBox2_ip1.Mask = "099,099,099,099";
            this.maskedTextBox2_ip1.Name = "maskedTextBox2_ip1";
            this.maskedTextBox2_ip1.Size = new System.Drawing.Size(265, 22);
            this.maskedTextBox2_ip1.TabIndex = 1;
            this.maskedTextBox2_ip1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_MaskInputRejected);
            this.maskedTextBox2_ip1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            this.maskedTextBox2_ip1.Validated += new System.EventHandler(this.maskedTextBox_Validated);
            // 
            // maskedTextBox3_ip2
            // 
            this.maskedTextBox3_ip2.Location = new System.Drawing.Point(6, 124);
            this.maskedTextBox3_ip2.Mask = "099,099,099,099";
            this.maskedTextBox3_ip2.Name = "maskedTextBox3_ip2";
            this.maskedTextBox3_ip2.Size = new System.Drawing.Size(265, 22);
            this.maskedTextBox3_ip2.TabIndex = 2;
            this.maskedTextBox3_ip2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_MaskInputRejected);
            this.maskedTextBox3_ip2.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            this.maskedTextBox3_ip2.Validated += new System.EventHandler(this.maskedTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subnetmaske";
            // 
            // label2_ip1
            // 
            this.label2_ip1.AutoSize = true;
            this.label2_ip1.Location = new System.Drawing.Point(6, 34);
            this.label2_ip1.Name = "label2_ip1";
            this.label2_ip1.Size = new System.Drawing.Size(89, 17);
            this.label2_ip1.TabIndex = 4;
            this.label2_ip1.Text = "IP-Adresse 1";
            // 
            // label3_ip2
            // 
            this.label3_ip2.AutoSize = true;
            this.label3_ip2.Location = new System.Drawing.Point(6, 104);
            this.label3_ip2.Name = "label3_ip2";
            this.label3_ip2.Size = new System.Drawing.Size(89, 17);
            this.label3_ip2.TabIndex = 5;
            this.label3_ip2.Text = "IP-Adresse 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "IP-Adressen validieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_result
            // 
            this.textBox1_result.Location = new System.Drawing.Point(9, 283);
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(604, 22);
            this.textBox1_result.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView2_ip2);
            this.groupBox1.Controls.Add(this.listView1_ip1);
            this.groupBox1.Controls.Add(this.label4_ip2_label);
            this.groupBox1.Controls.Add(this.label3_ip1_label);
            this.groupBox1.Controls.Add(this.label4_result);
            this.groupBox1.Controls.Add(this.maskedTextBox2_ip1);
            this.groupBox1.Controls.Add(this.textBox1_result);
            this.groupBox1.Controls.Add(this.label2_ip1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox3_ip2);
            this.groupBox1.Controls.Add(this.label3_ip2);
            this.groupBox1.Location = new System.Drawing.Point(39, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 325);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geben Sie die IP-Adressen zur Validierung mit der Subnetmaske ein";
            // 
            // label4_ip2_label
            // 
            this.label4_ip2_label.AutoSize = true;
            this.label4_ip2_label.Location = new System.Drawing.Point(6, 149);
            this.label4_ip2_label.Name = "label4_ip2_label";
            this.label4_ip2_label.Size = new System.Drawing.Size(30, 17);
            this.label4_ip2_label.TabIndex = 10;
            this.label4_ip2_label.Text = "null";
            this.label4_ip2_label.Visible = false;
            // 
            // label3_ip1_label
            // 
            this.label3_ip1_label.AutoSize = true;
            this.label3_ip1_label.Location = new System.Drawing.Point(6, 79);
            this.label3_ip1_label.Name = "label3_ip1_label";
            this.label3_ip1_label.Size = new System.Drawing.Size(30, 17);
            this.label3_ip1_label.TabIndex = 9;
            this.label3_ip1_label.Text = "null";
            this.label3_ip1_label.Visible = false;
            // 
            // label4_result
            // 
            this.label4_result.AutoSize = true;
            this.label4_result.Location = new System.Drawing.Point(6, 263);
            this.label4_result.Name = "label4_result";
            this.label4_result.Size = new System.Drawing.Size(141, 17);
            this.label4_result.TabIndex = 8;
            this.label4_result.Text = "Validierungsergebnis";
            // 
            // label2_subnetmask_label
            // 
            this.label2_subnetmask_label.AutoSize = true;
            this.label2_subnetmask_label.Location = new System.Drawing.Point(42, 63);
            this.label2_subnetmask_label.Name = "label2_subnetmask_label";
            this.label2_subnetmask_label.Size = new System.Drawing.Size(30, 17);
            this.label2_subnetmask_label.TabIndex = 9;
            this.label2_subnetmask_label.Text = "null";
            this.label2_subnetmask_label.Visible = false;
            // 
            // listView1_ip1
            // 
            this.listView1_ip1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1_ip1.HideSelection = false;
            this.listView1_ip1.Location = new System.Drawing.Point(289, 54);
            this.listView1_ip1.Name = "listView1_ip1";
            this.listView1_ip1.Size = new System.Drawing.Size(324, 60);
            this.listView1_ip1.TabIndex = 11;
            this.listView1_ip1.UseCompatibleStateImageBehavior = false;
            this.listView1_ip1.View = System.Windows.Forms.View.List;
            // 
            // listView2_ip2
            // 
            this.listView2_ip2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2_ip2.HideSelection = false;
            this.listView2_ip2.Location = new System.Drawing.Point(289, 124);
            this.listView2_ip2.Name = "listView2_ip2";
            this.listView2_ip2.Size = new System.Drawing.Size(324, 60);
            this.listView2_ip2.TabIndex = 12;
            this.listView2_ip2.UseCompatibleStateImageBehavior = false;
            this.listView2_ip2.View = System.Windows.Forms.View.List;
            // 
            // IP_Validierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 479);
            this.Controls.Add(this.label2_subnetmask_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1_Subnetmask);
            this.Name = "IP_Validierung";
            this.Text = "IP-Adressen Validator 2022";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1_Subnetmask;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2_ip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3_ip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_ip1;
        private System.Windows.Forms.Label label3_ip2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4_result;
        private System.Windows.Forms.Label label3_ip1_label;
        private System.Windows.Forms.Label label2_subnetmask_label;
        private System.Windows.Forms.Label label4_ip2_label;
        private System.Windows.Forms.ListView listView2_ip2;
        private System.Windows.Forms.ListView listView1_ip1;
    }
}

