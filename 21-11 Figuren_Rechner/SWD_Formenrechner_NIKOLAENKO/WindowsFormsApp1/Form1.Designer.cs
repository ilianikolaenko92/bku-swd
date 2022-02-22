namespace FormenRechner
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
            this.shapesComboBox = new System.Windows.Forms.ComboBox();
            this.shapesComboBoxLabel = new System.Windows.Forms.Label();
            this.inputField1 = new System.Windows.Forms.TextBox();
            this.inputField2 = new System.Windows.Forms.TextBox();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.calculateBttn = new System.Windows.Forms.Button();
            this.inputsField = new System.Windows.Forms.GroupBox();
            this.inputsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsField = new System.Windows.Forms.Panel();
            this.resultsField = new System.Windows.Forms.GroupBox();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputField2 = new System.Windows.Forms.TextBox();
            this.outputField1 = new System.Windows.Forms.TextBox();
            this.inputsField.SuspendLayout();
            this.inputsFlowLayoutPanel.SuspendLayout();
            this.buttonsField.SuspendLayout();
            this.resultsField.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapesComboBox
            // 
            this.shapesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.shapesComboBox.FormattingEnabled = true;
            this.shapesComboBox.Items.AddRange(new object[] {
            "Q: Quadrat",
            "R: Rechteck",
            "K: Kreis"});
            this.shapesComboBox.Location = new System.Drawing.Point(21, 24);
            this.shapesComboBox.Name = "shapesComboBox";
            this.shapesComboBox.Size = new System.Drawing.Size(296, 24);
            this.shapesComboBox.TabIndex = 0;
            this.shapesComboBox.Text = "Wählen Sie die Figur";
            this.shapesComboBox.SelectedIndexChanged += new System.EventHandler(this.ShapesComboBox_SelectedIndexChanged);
            // 
            // shapesComboBoxLabel
            // 
            this.shapesComboBoxLabel.AutoSize = true;
            this.shapesComboBoxLabel.Location = new System.Drawing.Point(18, 4);
            this.shapesComboBoxLabel.Name = "shapesComboBoxLabel";
            this.shapesComboBoxLabel.Size = new System.Drawing.Size(157, 17);
            this.shapesComboBoxLabel.TabIndex = 4;
            this.shapesComboBoxLabel.Text = "Modus des Programms:";
            // 
            // inputField1
            // 
            this.inputField1.AcceptsReturn = true;
            this.inputField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputField1.Location = new System.Drawing.Point(8, 30);
            this.inputField1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.inputField1.MaximumSize = new System.Drawing.Size(120, 4);
            this.inputField1.MinimumSize = new System.Drawing.Size(120, 30);
            this.inputField1.Name = "inputField1";
            this.inputField1.Size = new System.Drawing.Size(120, 22);
            this.inputField1.TabIndex = 5;
            this.inputField1.Visible = false;
            this.inputField1.TextChanged += new System.EventHandler(this.InputField1_TextChanged);
            this.inputField1.Enter += new System.EventHandler(this.InputField1_Enter);
            // 
            // inputField2
            // 
            this.inputField2.AcceptsReturn = true;
            this.inputField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputField2.Location = new System.Drawing.Point(151, 30);
            this.inputField2.MinimumSize = new System.Drawing.Size(120, 30);
            this.inputField2.Name = "inputField2";
            this.inputField2.Size = new System.Drawing.Size(120, 22);
            this.inputField2.TabIndex = 6;
            this.inputField2.Visible = false;
            this.inputField2.TextChanged += new System.EventHandler(this.InputField2_TextChanged);
            this.inputField2.Enter += new System.EventHandler(this.InputField2_Enter);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(8, 5);
            this.inputLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 20, 5);
            this.inputLabel1.MaximumSize = new System.Drawing.Size(120, 0);
            this.inputLabel1.MinimumSize = new System.Drawing.Size(120, 0);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(120, 17);
            this.inputLabel1.TabIndex = 7;
            this.inputLabel1.Text = "Parameter 1";
            this.inputLabel1.Visible = false;
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(151, 5);
            this.inputLabel2.MaximumSize = new System.Drawing.Size(120, 0);
            this.inputLabel2.MinimumSize = new System.Drawing.Size(120, 0);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(120, 17);
            this.inputLabel2.TabIndex = 8;
            this.inputLabel2.Text = "Parameter 2";
            this.inputLabel2.Visible = false;
            // 
            // calculateBttn
            // 
            this.calculateBttn.BackColor = System.Drawing.Color.LightBlue;
            this.calculateBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBttn.Location = new System.Drawing.Point(173, 22);
            this.calculateBttn.Name = "calculateBttn";
            this.calculateBttn.Size = new System.Drawing.Size(117, 48);
            this.calculateBttn.TabIndex = 10;
            this.calculateBttn.Text = "Berechnen";
            this.calculateBttn.UseVisualStyleBackColor = false;
            this.calculateBttn.Click += new System.EventHandler(this.CalculateBttn_Click);
            // 
            // inputsField
            // 
            this.inputsField.Controls.Add(this.inputsFlowLayoutPanel);
            this.inputsField.Location = new System.Drawing.Point(21, 90);
            this.inputsField.Name = "inputsField";
            this.inputsField.Size = new System.Drawing.Size(296, 140);
            this.inputsField.TabIndex = 11;
            this.inputsField.TabStop = false;
            this.inputsField.Text = "Eingabe erforderlicher Parameter";
            // 
            // inputsFlowLayoutPanel
            // 
            this.inputsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.inputsFlowLayoutPanel.Controls.Add(this.inputLabel1);
            this.inputsFlowLayoutPanel.Controls.Add(this.inputLabel2);
            this.inputsFlowLayoutPanel.Controls.Add(this.inputField1);
            this.inputsFlowLayoutPanel.Controls.Add(this.inputField2);
            this.inputsFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputsFlowLayoutPanel.Location = new System.Drawing.Point(6, 21);
            this.inputsFlowLayoutPanel.Name = "inputsFlowLayoutPanel";
            this.inputsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.inputsFlowLayoutPanel.Size = new System.Drawing.Size(284, 113);
            this.inputsFlowLayoutPanel.TabIndex = 13;
            // 
            // buttonsField
            // 
            this.buttonsField.Controls.Add(this.calculateBttn);
            this.buttonsField.Location = new System.Drawing.Point(21, 236);
            this.buttonsField.Name = "buttonsField";
            this.buttonsField.Size = new System.Drawing.Size(296, 93);
            this.buttonsField.TabIndex = 12;
            // 
            // resultsField
            // 
            this.resultsField.Controls.Add(this.outputLabel2);
            this.resultsField.Controls.Add(this.outputLabel1);
            this.resultsField.Controls.Add(this.outputField2);
            this.resultsField.Controls.Add(this.outputField1);
            this.resultsField.Location = new System.Drawing.Point(323, 90);
            this.resultsField.Name = "resultsField";
            this.resultsField.Size = new System.Drawing.Size(325, 239);
            this.resultsField.TabIndex = 13;
            this.resultsField.TabStop = false;
            this.resultsField.Text = "Ergebnis";
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(10, 96);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(54, 17);
            this.outputLabel2.TabIndex = 3;
            this.outputLabel2.Text = "Fläche:";
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(7, 41);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(61, 17);
            this.outputLabel1.TabIndex = 2;
            this.outputLabel1.Text = "Umfang:";
            // 
            // outputField2
            // 
            this.outputField2.BackColor = System.Drawing.Color.LightCyan;
            this.outputField2.Location = new System.Drawing.Point(132, 96);
            this.outputField2.Name = "outputField2";
            this.outputField2.ReadOnly = true;
            this.outputField2.Size = new System.Drawing.Size(100, 22);
            this.outputField2.TabIndex = 1;
            // 
            // outputField1
            // 
            this.outputField1.BackColor = System.Drawing.Color.LightCyan;
            this.outputField1.Location = new System.Drawing.Point(132, 41);
            this.outputField1.Name = "outputField1";
            this.outputField1.ReadOnly = true;
            this.outputField1.Size = new System.Drawing.Size(100, 22);
            this.outputField1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 415);
            this.Controls.Add(this.resultsField);
            this.Controls.Add(this.buttonsField);
            this.Controls.Add(this.inputsField);
            this.Controls.Add(this.shapesComboBoxLabel);
            this.Controls.Add(this.shapesComboBox);
            this.Name = "Form1";
            this.Text = "Umfang & Fläche Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputsField.ResumeLayout(false);
            this.inputsFlowLayoutPanel.ResumeLayout(false);
            this.inputsFlowLayoutPanel.PerformLayout();
            this.buttonsField.ResumeLayout(false);
            this.resultsField.ResumeLayout(false);
            this.resultsField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapesComboBoxLabel;
        private System.Windows.Forms.ComboBox shapesComboBox;
        private System.Windows.Forms.GroupBox inputsField;
        private System.Windows.Forms.FlowLayoutPanel inputsFlowLayoutPanel;
        private System.Windows.Forms.TextBox inputField1;
        private System.Windows.Forms.TextBox inputField2;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Panel buttonsField;
        private System.Windows.Forms.Button calculateBttn;
        private System.Windows.Forms.GroupBox resultsField;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.TextBox outputField2;
        private System.Windows.Forms.TextBox outputField1;
    }
}

