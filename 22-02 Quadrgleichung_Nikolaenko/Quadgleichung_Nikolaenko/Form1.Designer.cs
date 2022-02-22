namespace Quadgleichung_Nikolaenko
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.p_textbox = new System.Windows.Forms.TextBox();
            this.q_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solution_label = new System.Windows.Forms.Label();
            this.x2_label = new System.Windows.Forms.Label();
            this.x1_label = new System.Windows.Forms.Label();
            this.x2_textbox = new System.Windows.Forms.TextBox();
            this.x1_textbox = new System.Windows.Forms.TextBox();
            this.p_label = new System.Windows.Forms.Label();
            this.q_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mit dieser Anwendung lösen Sie eine qudratische Gleichung:\r\nx^2 + p*x + q = 0\r\n\r\n" +
    "Geben Sie bitte folgende Parameter ein:";
            // 
            // p_textbox
            // 
            this.p_textbox.Location = new System.Drawing.Point(40, 30);
            this.p_textbox.Name = "p_textbox";
            this.p_textbox.Size = new System.Drawing.Size(100, 22);
            this.p_textbox.TabIndex = 1;
            this.p_textbox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // q_textbox
            // 
            this.q_textbox.Location = new System.Drawing.Point(40, 60);
            this.q_textbox.Name = "q_textbox";
            this.q_textbox.Size = new System.Drawing.Size(100, 22);
            this.q_textbox.TabIndex = 2;
            this.q_textbox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solution_label);
            this.groupBox1.Controls.Add(this.x2_label);
            this.groupBox1.Controls.Add(this.x1_label);
            this.groupBox1.Controls.Add(this.x2_textbox);
            this.groupBox1.Controls.Add(this.x1_textbox);
            this.groupBox1.Location = new System.Drawing.Point(222, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lösung";
            // 
            // solution_label
            // 
            this.solution_label.AutoSize = true;
            this.solution_label.Location = new System.Drawing.Point(10, 105);
            this.solution_label.Name = "solution_label";
            this.solution_label.Size = new System.Drawing.Size(79, 17);
            this.solution_label.TabIndex = 4;
            this.solution_label.Text = "D message";
            this.solution_label.Visible = false;
            // 
            // x2_label
            // 
            this.x2_label.AutoSize = true;
            this.x2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2_label.Location = new System.Drawing.Point(10, 63);
            this.x2_label.Name = "x2_label";
            this.x2_label.Size = new System.Drawing.Size(24, 17);
            this.x2_label.TabIndex = 3;
            this.x2_label.Text = "x2";
            this.x2_label.Visible = false;
            // 
            // x1_label
            // 
            this.x1_label.AutoSize = true;
            this.x1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1_label.Location = new System.Drawing.Point(10, 35);
            this.x1_label.Name = "x1_label";
            this.x1_label.Size = new System.Drawing.Size(24, 17);
            this.x1_label.TabIndex = 2;
            this.x1_label.Text = "x1";
            this.x1_label.Visible = false;
            // 
            // x2_textbox
            // 
            this.x2_textbox.Location = new System.Drawing.Point(40, 60);
            this.x2_textbox.Name = "x2_textbox";
            this.x2_textbox.ReadOnly = true;
            this.x2_textbox.Size = new System.Drawing.Size(100, 22);
            this.x2_textbox.TabIndex = 1;
            this.x2_textbox.Visible = false;
            // 
            // x1_textbox
            // 
            this.x1_textbox.Location = new System.Drawing.Point(40, 30);
            this.x1_textbox.Name = "x1_textbox";
            this.x1_textbox.ReadOnly = true;
            this.x1_textbox.Size = new System.Drawing.Size(100, 22);
            this.x1_textbox.TabIndex = 0;
            this.x1_textbox.Visible = false;
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_label.Location = new System.Drawing.Point(17, 35);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(17, 17);
            this.p_label.TabIndex = 5;
            this.p_label.Text = "p";
            // 
            // q_label
            // 
            this.q_label.AutoSize = true;
            this.q_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_label.Location = new System.Drawing.Point(17, 65);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(17, 17);
            this.q_label.TabIndex = 6;
            this.q_label.Text = "q";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_textbox);
            this.groupBox2.Controls.Add(this.q_label);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.q_textbox);
            this.groupBox2.Controls.Add(this.p_label);
            this.groupBox2.Location = new System.Drawing.Point(25, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 143);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quadratische Gleichung SWD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p_textbox;
        private System.Windows.Forms.TextBox q_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label solution_label;
        private System.Windows.Forms.Label x2_label;
        private System.Windows.Forms.Label x1_label;
        private System.Windows.Forms.TextBox x2_textbox;
        private System.Windows.Forms.TextBox x1_textbox;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

