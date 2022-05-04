namespace Rekursive_Mathe
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
            this.x_input = new System.Windows.Forms.TextBox();
            this.y_input = new System.Windows.Forms.TextBox();
            this.comboBox_math_operations = new System.Windows.Forms.ComboBox();
            this.result_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_x = new System.Windows.Forms.Label();
            this.label3_y = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5_x_message = new System.Windows.Forms.Label();
            this.label6_y_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x_input
            // 
            this.x_input.Location = new System.Drawing.Point(44, 167);
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(121, 22);
            this.x_input.TabIndex = 0;
            this.x_input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // y_input
            // 
            this.y_input.Location = new System.Drawing.Point(44, 222);
            this.y_input.Name = "y_input";
            this.y_input.Size = new System.Drawing.Size(121, 22);
            this.y_input.TabIndex = 1;
            this.y_input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // comboBox_math_operations
            // 
            this.comboBox_math_operations.FormattingEnabled = true;
            this.comboBox_math_operations.Items.AddRange(new object[] {
            "Addieren",
            "Substrahieren",
            "Multiplizieren",
            "Dividieren"});
            this.comboBox_math_operations.Location = new System.Drawing.Point(44, 94);
            this.comboBox_math_operations.Name = "comboBox_math_operations";
            this.comboBox_math_operations.Size = new System.Drawing.Size(236, 24);
            this.comboBox_math_operations.TabIndex = 2;
            this.comboBox_math_operations.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // result_field
            // 
            this.result_field.Location = new System.Drawing.Point(44, 285);
            this.result_field.Name = "result_field";
            this.result_field.Size = new System.Drawing.Size(236, 22);
            this.result_field.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operation";
            // 
            // label2_x
            // 
            this.label2_x.AutoSize = true;
            this.label2_x.Location = new System.Drawing.Point(41, 147);
            this.label2_x.Name = "label2_x";
            this.label2_x.Size = new System.Drawing.Size(17, 17);
            this.label2_x.TabIndex = 5;
            this.label2_x.Text = "X";
            // 
            // label3_y
            // 
            this.label3_y.AutoSize = true;
            this.label3_y.Location = new System.Drawing.Point(41, 202);
            this.label3_y.Name = "label3_y";
            this.label3_y.Size = new System.Drawing.Size(17, 17);
            this.label3_y.TabIndex = 6;
            this.label3_y.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ergebnis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Berechnen!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5_x_message
            // 
            this.label5_x_message.AutoSize = true;
            this.label5_x_message.Location = new System.Drawing.Point(172, 167);
            this.label5_x_message.Name = "label5_x_message";
            this.label5_x_message.Size = new System.Drawing.Size(30, 17);
            this.label5_x_message.TabIndex = 9;
            this.label5_x_message.Text = "null";
            this.label5_x_message.Visible = false;
            // 
            // label6_y_message
            // 
            this.label6_y_message.AutoSize = true;
            this.label6_y_message.Location = new System.Drawing.Point(172, 225);
            this.label6_y_message.Name = "label6_y_message";
            this.label6_y_message.Size = new System.Drawing.Size(30, 17);
            this.label6_y_message.TabIndex = 10;
            this.label6_y_message.Text = "null";
            this.label6_y_message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 380);
            this.Controls.Add(this.label6_y_message);
            this.Controls.Add(this.label5_x_message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3_y);
            this.Controls.Add(this.label2_x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_field);
            this.Controls.Add(this.comboBox_math_operations);
            this.Controls.Add(this.y_input);
            this.Controls.Add(this.x_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_input;
        private System.Windows.Forms.TextBox y_input;
        private System.Windows.Forms.ComboBox comboBox_math_operations;
        private System.Windows.Forms.TextBox result_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_x;
        private System.Windows.Forms.Label label3_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5_x_message;
        private System.Windows.Forms.Label label6_y_message;
    }
}

