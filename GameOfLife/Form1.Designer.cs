namespace WindowsFormsApplication5
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
            this.Start_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Beehive_button = new System.Windows.Forms.Button();
            this.Glider_button = new System.Windows.Forms.Button();
            this.Oscillator_button = new System.Windows.Forms.Button();
            this.Random_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Simulation_button = new System.Windows.Forms.Button();
            this.Powerful_Glider_gun_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(383, 13);
            this.Start_button.Margin = new System.Windows.Forms.Padding(4);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(181, 42);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Nastepna";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(16, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1221, 743);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Szerokość";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "30";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "30";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wysokość";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Periodyczne"});
            this.comboBox2.Location = new System.Drawing.Point(19, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Warunki";
            // 
            // Beehive_button
            // 
            this.Beehive_button.Location = new System.Drawing.Point(592, 4);
            this.Beehive_button.Name = "Beehive_button";
            this.Beehive_button.Size = new System.Drawing.Size(94, 32);
            this.Beehive_button.TabIndex = 15;
            this.Beehive_button.Text = "Niezmienny";
            this.Beehive_button.UseVisualStyleBackColor = true;
            this.Beehive_button.Click += new System.EventHandler(this.beehive_button_Click);
            // 
            // Glider_button
            // 
            this.Glider_button.Location = new System.Drawing.Point(592, 33);
            this.Glider_button.Name = "Glider_button";
            this.Glider_button.Size = new System.Drawing.Size(94, 32);
            this.Glider_button.TabIndex = 16;
            this.Glider_button.Text = "Glider";
            this.Glider_button.UseVisualStyleBackColor = true;
            this.Glider_button.Click += new System.EventHandler(this.Glider_button_Click);
            // 
            // Oscillator_button
            // 
            this.Oscillator_button.Location = new System.Drawing.Point(592, 62);
            this.Oscillator_button.Name = "Oscillator_button";
            this.Oscillator_button.Size = new System.Drawing.Size(94, 32);
            this.Oscillator_button.TabIndex = 17;
            this.Oscillator_button.Text = "Oscylator";
            this.Oscillator_button.UseVisualStyleBackColor = true;
            this.Oscillator_button.Click += new System.EventHandler(this.Oscillator_button_Click);
            // 
            // Random_button
            // 
            this.Random_button.Location = new System.Drawing.Point(592, 90);
            this.Random_button.Name = "Random_button";
            this.Random_button.Size = new System.Drawing.Size(94, 32);
            this.Random_button.TabIndex = 18;
            this.Random_button.Text = "Losowy";
            this.Random_button.UseVisualStyleBackColor = true;
            this.Random_button.Click += new System.EventHandler(this.Random_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(711, 63);
            this.Stop_button.Margin = new System.Windows.Forms.Padding(4);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(181, 42);
            this.Stop_button.TabIndex = 19;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Simulation_button
            // 
            this.Simulation_button.Location = new System.Drawing.Point(711, 13);
            this.Simulation_button.Margin = new System.Windows.Forms.Padding(4);
            this.Simulation_button.Name = "Simulation_button";
            this.Simulation_button.Size = new System.Drawing.Size(181, 42);
            this.Simulation_button.TabIndex = 20;
            this.Simulation_button.Text = "Start symulacji";
            this.Simulation_button.UseVisualStyleBackColor = true;
            this.Simulation_button.Click += new System.EventHandler(this.Simulation_button_Click);
            // 
            // Powerful_Glider_gun_button
            // 
            this.Powerful_Glider_gun_button.Location = new System.Drawing.Point(383, 63);
            this.Powerful_Glider_gun_button.Margin = new System.Windows.Forms.Padding(4);
            this.Powerful_Glider_gun_button.Name = "Powerful_Glider_gun_button";
            this.Powerful_Glider_gun_button.Size = new System.Drawing.Size(181, 42);
            this.Powerful_Glider_gun_button.TabIndex = 21;
            this.Powerful_Glider_gun_button.Text = "GLIDER GUN";
            this.Powerful_Glider_gun_button.UseVisualStyleBackColor = true;
            this.Powerful_Glider_gun_button.Click += new System.EventHandler(this.Powerful_Glider_gun_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 886);
            this.Controls.Add(this.Powerful_Glider_gun_button);
            this.Controls.Add(this.Simulation_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Random_button);
            this.Controls.Add(this.Oscillator_button);
            this.Controls.Add(this.Glider_button);
            this.Controls.Add(this.Beehive_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Beehive_button;
        private System.Windows.Forms.Button Glider_button;
        private System.Windows.Forms.Button Oscillator_button;
        private System.Windows.Forms.Button Random_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Simulation_button;
        private System.Windows.Forms.Button Powerful_Glider_gun_button;
    }
}

