namespace Lab2b
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HairDresserRB5 = new System.Windows.Forms.RadioButton();
            this.HairDresserRB4 = new System.Windows.Forms.RadioButton();
            this.HairDresserRB3 = new System.Windows.Forms.RadioButton();
            this.HairDresserRB2 = new System.Windows.Forms.RadioButton();
            this.HairDresserRB1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceCB4 = new System.Windows.Forms.CheckBox();
            this.ServiceCB3 = new System.Windows.Forms.CheckBox();
            this.ServiceCB2 = new System.Windows.Forms.CheckBox();
            this.ServiceCB1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClientRB4 = new System.Windows.Forms.RadioButton();
            this.ClientRB3 = new System.Windows.Forms.RadioButton();
            this.ClientRB2 = new System.Windows.Forms.RadioButton();
            this.ClientRB1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClientVisitTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HairDresserRB5);
            this.groupBox1.Controls.Add(this.HairDresserRB4);
            this.groupBox1.Controls.Add(this.HairDresserRB3);
            this.groupBox1.Controls.Add(this.HairDresserRB2);
            this.groupBox1.Controls.Add(this.HairDresserRB1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(228, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hairdresser";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // HairDresserRB5
            // 
            this.HairDresserRB5.AutoSize = true;
            this.HairDresserRB5.Location = new System.Drawing.Point(9, 145);
            this.HairDresserRB5.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserRB5.Name = "HairDresserRB5";
            this.HairDresserRB5.Size = new System.Drawing.Size(134, 22);
            this.HairDresserRB5.TabIndex = 4;
            this.HairDresserRB5.Text = "Laura Renkins";
            this.HairDresserRB5.UseVisualStyleBackColor = true;
            this.HairDresserRB5.CheckedChanged += new System.EventHandler(this.HairDresserRB5_CheckedChanged);
            // 
            // HairDresserRB4
            // 
            this.HairDresserRB4.AutoSize = true;
            this.HairDresserRB4.Location = new System.Drawing.Point(9, 115);
            this.HairDresserRB4.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserRB4.Name = "HairDresserRB4";
            this.HairDresserRB4.Size = new System.Drawing.Size(107, 22);
            this.HairDresserRB4.TabIndex = 3;
            this.HairDresserRB4.Text = "Sue Pallon";
            this.HairDresserRB4.UseVisualStyleBackColor = true;
            this.HairDresserRB4.CheckedChanged += new System.EventHandler(this.HairDresserRB4_CheckedChanged);
            // 
            // HairDresserRB3
            // 
            this.HairDresserRB3.AutoSize = true;
            this.HairDresserRB3.Location = new System.Drawing.Point(8, 85);
            this.HairDresserRB3.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserRB3.Name = "HairDresserRB3";
            this.HairDresserRB3.Size = new System.Drawing.Size(139, 22);
            this.HairDresserRB3.TabIndex = 2;
            this.HairDresserRB3.Text = "Ron Chambers";
            this.HairDresserRB3.UseVisualStyleBackColor = true;
            this.HairDresserRB3.CheckedChanged += new System.EventHandler(this.HairDresserRB3_CheckedChanged);
            // 
            // HairDresserRB2
            // 
            this.HairDresserRB2.AutoSize = true;
            this.HairDresserRB2.Location = new System.Drawing.Point(9, 55);
            this.HairDresserRB2.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserRB2.Name = "HairDresserRB2";
            this.HairDresserRB2.Size = new System.Drawing.Size(121, 22);
            this.HairDresserRB2.TabIndex = 1;
            this.HairDresserRB2.TabStop = true;
            this.HairDresserRB2.Text = "Pat Jhonson";
            this.HairDresserRB2.UseVisualStyleBackColor = true;
            this.HairDresserRB2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // HairDresserRB1
            // 
            this.HairDresserRB1.AutoSize = true;
            this.HairDresserRB1.Checked = true;
            this.HairDresserRB1.Location = new System.Drawing.Point(9, 25);
            this.HairDresserRB1.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserRB1.Name = "HairDresserRB1";
            this.HairDresserRB1.Size = new System.Drawing.Size(122, 22);
            this.HairDresserRB1.TabIndex = 0;
            this.HairDresserRB1.TabStop = true;
            this.HairDresserRB1.Text = "Jane Samely";
            this.HairDresserRB1.UseVisualStyleBackColor = true;
            this.HairDresserRB1.CheckedChanged += new System.EventHandler(this.HairDresserRB1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServiceCB4);
            this.groupBox2.Controls.Add(this.ServiceCB3);
            this.groupBox2.Controls.Add(this.ServiceCB2);
            this.groupBox2.Controls.Add(this.ServiceCB1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(261, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // ServiceCB4
            // 
            this.ServiceCB4.AutoSize = true;
            this.ServiceCB4.Location = new System.Drawing.Point(6, 113);
            this.ServiceCB4.Name = "ServiceCB4";
            this.ServiceCB4.Size = new System.Drawing.Size(101, 22);
            this.ServiceCB4.TabIndex = 3;
            this.ServiceCB4.Text = "Extension";
            this.ServiceCB4.UseVisualStyleBackColor = true;
            this.ServiceCB4.CheckedChanged += new System.EventHandler(this.ServiceCB4_CheckedChanged);
            // 
            // ServiceCB3
            // 
            this.ServiceCB3.AutoSize = true;
            this.ServiceCB3.Location = new System.Drawing.Point(7, 85);
            this.ServiceCB3.Name = "ServiceCB3";
            this.ServiceCB3.Size = new System.Drawing.Size(92, 22);
            this.ServiceCB3.TabIndex = 2;
            this.ServiceCB3.Text = "Highlight";
            this.ServiceCB3.UseVisualStyleBackColor = true;
            this.ServiceCB3.CheckedChanged += new System.EventHandler(this.ServiceCB3_CheckedChanged);
            // 
            // ServiceCB2
            // 
            this.ServiceCB2.AutoSize = true;
            this.ServiceCB2.Location = new System.Drawing.Point(7, 59);
            this.ServiceCB2.Name = "ServiceCB2";
            this.ServiceCB2.Size = new System.Drawing.Size(78, 22);
            this.ServiceCB2.TabIndex = 1;
            this.ServiceCB2.Text = "Colour";
            this.ServiceCB2.UseVisualStyleBackColor = true;
            this.ServiceCB2.CheckedChanged += new System.EventHandler(this.ServiceCB2_CheckedChanged);
            // 
            // ServiceCB1
            // 
            this.ServiceCB1.AutoSize = true;
            this.ServiceCB1.Location = new System.Drawing.Point(7, 29);
            this.ServiceCB1.Name = "ServiceCB1";
            this.ServiceCB1.Size = new System.Drawing.Size(53, 22);
            this.ServiceCB1.TabIndex = 0;
            this.ServiceCB1.Text = "Cut";
            this.ServiceCB1.UseVisualStyleBackColor = true;
            this.ServiceCB1.CheckedChanged += new System.EventHandler(this.ServiceCB1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientRB4);
            this.groupBox3.Controls.Add(this.ClientRB3);
            this.groupBox3.Controls.Add(this.ClientRB2);
            this.groupBox3.Controls.Add(this.ClientRB1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 149);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Type";
            // 
            // ClientRB4
            // 
            this.ClientRB4.AutoSize = true;
            this.ClientRB4.Location = new System.Drawing.Point(9, 114);
            this.ClientRB4.Margin = new System.Windows.Forms.Padding(4);
            this.ClientRB4.Name = "ClientRB4";
            this.ClientRB4.Size = new System.Drawing.Size(156, 22);
            this.ClientRB4.TabIndex = 4;
            this.ClientRB4.TabStop = true;
            this.ClientRB4.Text = "Senior ( Over 65)";
            this.ClientRB4.UseVisualStyleBackColor = true;
            this.ClientRB4.CheckedChanged += new System.EventHandler(this.ClientRB4_CheckedChanged);
            // 
            // ClientRB3
            // 
            this.ClientRB3.AutoSize = true;
            this.ClientRB3.Location = new System.Drawing.Point(9, 84);
            this.ClientRB3.Margin = new System.Windows.Forms.Padding(4);
            this.ClientRB3.Name = "ClientRB3";
            this.ClientRB3.Size = new System.Drawing.Size(83, 22);
            this.ClientRB3.TabIndex = 3;
            this.ClientRB3.TabStop = true;
            this.ClientRB3.Text = "Student";
            this.ClientRB3.UseVisualStyleBackColor = true;
            this.ClientRB3.CheckedChanged += new System.EventHandler(this.ClientRB3_CheckedChanged);
            // 
            // ClientRB2
            // 
            this.ClientRB2.AutoSize = true;
            this.ClientRB2.Location = new System.Drawing.Point(9, 54);
            this.ClientRB2.Margin = new System.Windows.Forms.Padding(4);
            this.ClientRB2.Name = "ClientRB2";
            this.ClientRB2.Size = new System.Drawing.Size(181, 22);
            this.ClientRB2.TabIndex = 2;
            this.ClientRB2.TabStop = true;
            this.ClientRB2.Text = "Child (12 and Under)";
            this.ClientRB2.UseVisualStyleBackColor = true;
            this.ClientRB2.CheckedChanged += new System.EventHandler(this.ClientRB2_CheckedChanged);
            // 
            // ClientRB1
            // 
            this.ClientRB1.AutoSize = true;
            this.ClientRB1.Checked = true;
            this.ClientRB1.Location = new System.Drawing.Point(7, 24);
            this.ClientRB1.Margin = new System.Windows.Forms.Padding(4);
            this.ClientRB1.Name = "ClientRB1";
            this.ClientRB1.Size = new System.Drawing.Size(135, 22);
            this.ClientRB1.TabIndex = 1;
            this.ClientRB1.TabStop = true;
            this.ClientRB1.Text = "Standard Adult";
            this.ClientRB1.UseVisualStyleBackColor = true;
            this.ClientRB1.CheckedChanged += new System.EventHandler(this.ClientRB1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClientVisitTB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(261, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 136);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Visits";
            // 
            // ClientVisitTB
            // 
            this.ClientVisitTB.Location = new System.Drawing.Point(10, 55);
            this.ClientVisitTB.Name = "ClientVisitTB";
            this.ClientVisitTB.Size = new System.Drawing.Size(183, 24);
            this.ClientVisitTB.TabIndex = 1;
            this.ClientVisitTB.TextChanged += new System.EventHandler(this.ClientVisitTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Client Visits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Price:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(251, 385);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(86, 18);
            this.TotalPriceLabel.TabIndex = 11;
            this.TotalPriceLabel.Text = "something";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(16, 453);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 23);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(231, 451);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(423, 452);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 492);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HairDresserRB1;
        private System.Windows.Forms.RadioButton HairDresserRB5;
        private System.Windows.Forms.RadioButton HairDresserRB4;
        private System.Windows.Forms.RadioButton HairDresserRB3;
        private System.Windows.Forms.RadioButton HairDresserRB2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ServiceCB4;
        private System.Windows.Forms.CheckBox ServiceCB3;
        private System.Windows.Forms.CheckBox ServiceCB2;
        private System.Windows.Forms.CheckBox ServiceCB1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ClientRB4;
        private System.Windows.Forms.RadioButton ClientRB3;
        private System.Windows.Forms.RadioButton ClientRB2;
        private System.Windows.Forms.RadioButton ClientRB1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ClientVisitTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

