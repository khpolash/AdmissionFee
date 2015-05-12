namespace AdmissionFeeApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateBbutton = new System.Windows.Forms.Button();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculateBbutton);
            this.groupBox1.Controls.Add(this.discountCheckBox);
            this.groupBox1.Controls.Add(this.selectClassComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator for yearly cost of a student";
            // 
            // calculateBbutton
            // 
            this.calculateBbutton.Location = new System.Drawing.Point(154, 158);
            this.calculateBbutton.Name = "calculateBbutton";
            this.calculateBbutton.Size = new System.Drawing.Size(192, 29);
            this.calculateBbutton.TabIndex = 3;
            this.calculateBbutton.Text = "Calculate total amount for one year";
            this.calculateBbutton.UseVisualStyleBackColor = true;
            this.calculateBbutton.Click += new System.EventHandler(this.calculateBbutton_Click);
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(154, 99);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(192, 17);
            this.discountCheckBox.TabIndex = 2;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Items.AddRange(new object[] {
            "Select Class"});
            this.selectClassComboBox.Location = new System.Drawing.Point(154, 51);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(192, 21);
            this.selectClassComboBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 277);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Admission Fee UI";
            this.Load += new System.EventHandler(this.onLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculateBbutton;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.ComboBox selectClassComboBox;
    }
}

