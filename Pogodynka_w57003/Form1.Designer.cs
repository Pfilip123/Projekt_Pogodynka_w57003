namespace Pogodynka_w57003
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
            this.components = new System.ComponentModel.Container();
            this.label_city = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_temp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_day_forcast = new System.Windows.Forms.Label();
            this.label_conditionals_forcast = new System.Windows.Forms.Label();
            this.label_descritpion_forcast = new System.Windows.Forms.Label();
            this.label_wind_forcast = new System.Windows.Forms.Label();
            this.label_temp_forcast = new System.Windows.Forms.Label();
            this.label_forcast = new System.Windows.Forms.Label();
            this.label_day_forcast2 = new System.Windows.Forms.Label();
            this.label_conditionals_forcast2 = new System.Windows.Forms.Label();
            this.label_descritpion_forcast2 = new System.Windows.Forms.Label();
            this.label_wind_forcast2 = new System.Windows.Forms.Label();
            this.label_temp_forcast2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_forecast2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.BackColor = System.Drawing.Color.Transparent;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_city.ForeColor = System.Drawing.Color.Yellow;
            this.label_city.Location = new System.Drawing.Point(254, 21);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(428, 46);
            this.label_city.TabIndex = 0;
            this.label_city.Text = "Rzeszów, Podkarpacie";
            this.label_city.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BackColor = System.Drawing.Color.Transparent;
            this.label_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_country.ForeColor = System.Drawing.Color.Yellow;
            this.label_country.Location = new System.Drawing.Point(678, 21);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(47, 31);
            this.label_country.TabIndex = 0;
            this.label_country.Text = "PL";
            this.label_country.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pogodynka_w57003.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(44, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.BackColor = System.Drawing.Color.Transparent;
            this.label_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_temp.ForeColor = System.Drawing.Color.Yellow;
            this.label_temp.Location = new System.Drawing.Point(261, 74);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(81, 76);
            this.label_temp.TabIndex = 2;
            this.label_temp.Text = "C";
            this.label_temp.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pogodynka_w57003.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(44, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_day_forcast
            // 
            this.label_day_forcast.AutoSize = true;
            this.label_day_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_day_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_day_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_day_forcast.Location = new System.Drawing.Point(40, 469);
            this.label_day_forcast.Name = "label_day_forcast";
            this.label_day_forcast.Size = new System.Drawing.Size(58, 24);
            this.label_day_forcast.TabIndex = 0;
            this.label_day_forcast.Text = "Dzień";
            this.label_day_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_conditionals_forcast
            // 
            this.label_conditionals_forcast.AutoSize = true;
            this.label_conditionals_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_conditionals_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_conditionals_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_conditionals_forcast.Location = new System.Drawing.Point(40, 505);
            this.label_conditionals_forcast.Name = "label_conditionals_forcast";
            this.label_conditionals_forcast.Size = new System.Drawing.Size(79, 24);
            this.label_conditionals_forcast.TabIndex = 0;
            this.label_conditionals_forcast.Text = "Warunki";
            this.label_conditionals_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_descritpion_forcast
            // 
            this.label_descritpion_forcast.AutoSize = true;
            this.label_descritpion_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_descritpion_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_descritpion_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_descritpion_forcast.Location = new System.Drawing.Point(40, 542);
            this.label_descritpion_forcast.Name = "label_descritpion_forcast";
            this.label_descritpion_forcast.Size = new System.Drawing.Size(49, 24);
            this.label_descritpion_forcast.TabIndex = 0;
            this.label_descritpion_forcast.Text = "Opis";
            this.label_descritpion_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_wind_forcast
            // 
            this.label_wind_forcast.AutoSize = true;
            this.label_wind_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_wind_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wind_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_wind_forcast.Location = new System.Drawing.Point(40, 578);
            this.label_wind_forcast.Name = "label_wind_forcast";
            this.label_wind_forcast.Size = new System.Drawing.Size(52, 24);
            this.label_wind_forcast.TabIndex = 0;
            this.label_wind_forcast.Text = "Wiatr";
            this.label_wind_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_temp_forcast
            // 
            this.label_temp_forcast.AutoSize = true;
            this.label_temp_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_temp_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_temp_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_temp_forcast.Location = new System.Drawing.Point(189, 469);
            this.label_temp_forcast.Name = "label_temp_forcast";
            this.label_temp_forcast.Size = new System.Drawing.Size(30, 24);
            this.label_temp_forcast.TabIndex = 0;
            this.label_temp_forcast.Text = "26";
            this.label_temp_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_forcast
            // 
            this.label_forcast.AutoSize = true;
            this.label_forcast.BackColor = System.Drawing.Color.Transparent;
            this.label_forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_forcast.ForeColor = System.Drawing.Color.Yellow;
            this.label_forcast.Location = new System.Drawing.Point(50, 276);
            this.label_forcast.Name = "label_forcast";
            this.label_forcast.Size = new System.Drawing.Size(116, 29);
            this.label_forcast.TabIndex = 0;
            this.label_forcast.Text = "Prognoza";
            this.label_forcast.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_day_forcast2
            // 
            this.label_day_forcast2.AutoSize = true;
            this.label_day_forcast2.BackColor = System.Drawing.Color.Transparent;
            this.label_day_forcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_day_forcast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_day_forcast2.Location = new System.Drawing.Point(292, 469);
            this.label_day_forcast2.Name = "label_day_forcast2";
            this.label_day_forcast2.Size = new System.Drawing.Size(58, 24);
            this.label_day_forcast2.TabIndex = 0;
            this.label_day_forcast2.Text = "Dzień";
            this.label_day_forcast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_conditionals_forcast2
            // 
            this.label_conditionals_forcast2.AutoSize = true;
            this.label_conditionals_forcast2.BackColor = System.Drawing.Color.Transparent;
            this.label_conditionals_forcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_conditionals_forcast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_conditionals_forcast2.Location = new System.Drawing.Point(292, 505);
            this.label_conditionals_forcast2.Name = "label_conditionals_forcast2";
            this.label_conditionals_forcast2.Size = new System.Drawing.Size(79, 24);
            this.label_conditionals_forcast2.TabIndex = 0;
            this.label_conditionals_forcast2.Text = "Warunki";
            this.label_conditionals_forcast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_descritpion_forcast2
            // 
            this.label_descritpion_forcast2.AutoSize = true;
            this.label_descritpion_forcast2.BackColor = System.Drawing.Color.Transparent;
            this.label_descritpion_forcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_descritpion_forcast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_descritpion_forcast2.Location = new System.Drawing.Point(292, 542);
            this.label_descritpion_forcast2.Name = "label_descritpion_forcast2";
            this.label_descritpion_forcast2.Size = new System.Drawing.Size(49, 24);
            this.label_descritpion_forcast2.TabIndex = 0;
            this.label_descritpion_forcast2.Text = "Opis";
            this.label_descritpion_forcast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_wind_forcast2
            // 
            this.label_wind_forcast2.AutoSize = true;
            this.label_wind_forcast2.BackColor = System.Drawing.Color.Transparent;
            this.label_wind_forcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wind_forcast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_wind_forcast2.Location = new System.Drawing.Point(292, 578);
            this.label_wind_forcast2.Name = "label_wind_forcast2";
            this.label_wind_forcast2.Size = new System.Drawing.Size(52, 24);
            this.label_wind_forcast2.TabIndex = 0;
            this.label_wind_forcast2.Text = "Wiatr";
            this.label_wind_forcast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_temp_forcast2
            // 
            this.label_temp_forcast2.AutoSize = true;
            this.label_temp_forcast2.BackColor = System.Drawing.Color.Transparent;
            this.label_temp_forcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_temp_forcast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_temp_forcast2.Location = new System.Drawing.Point(441, 469);
            this.label_temp_forcast2.Name = "label_temp_forcast2";
            this.label_temp_forcast2.Size = new System.Drawing.Size(30, 24);
            this.label_temp_forcast2.TabIndex = 0;
            this.label_temp_forcast2.Text = "26";
            this.label_temp_forcast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Pogodynka_w57003.Properties.Resources._0;
            this.pictureBox3.Location = new System.Drawing.Point(296, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_forecast2
            // 
            this.label_forecast2.AutoSize = true;
            this.label_forecast2.BackColor = System.Drawing.Color.Transparent;
            this.label_forecast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_forecast2.ForeColor = System.Drawing.Color.Yellow;
            this.label_forecast2.Location = new System.Drawing.Point(291, 276);
            this.label_forecast2.Name = "label_forecast2";
            this.label_forecast2.Size = new System.Drawing.Size(116, 29);
            this.label_forecast2.TabIndex = 0;
            this.label_forecast2.Text = "Prognoza";
            this.label_forecast2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(521, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prognoza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(522, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dzień";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(522, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Warunki";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(522, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opis";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(522, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wiatr";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(671, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "26";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Pogodynka_w57003.Properties.Resources._0;
            this.pictureBox4.Location = new System.Drawing.Point(526, 321);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pogodynka_w57003.Properties.Resources.grass_3199370_960_720;
            this.ClientSize = new System.Drawing.Size(733, 637);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_temp_forcast2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_wind_forcast2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_temp_forcast);
            this.Controls.Add(this.label_descritpion_forcast2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_wind_forcast);
            this.Controls.Add(this.label_conditionals_forcast2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_descritpion_forcast);
            this.Controls.Add(this.label_day_forcast2);
            this.Controls.Add(this.label_conditionals_forcast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_day_forcast);
            this.Controls.Add(this.label_forecast2);
            this.Controls.Add(this.label_forcast);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_city);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_day_forcast;
        private System.Windows.Forms.Label label_conditionals_forcast;
        private System.Windows.Forms.Label label_descritpion_forcast;
        private System.Windows.Forms.Label label_wind_forcast;
        private System.Windows.Forms.Label label_temp_forcast;
        private System.Windows.Forms.Label label_forcast;
        private System.Windows.Forms.Label label_day_forcast2;
        private System.Windows.Forms.Label label_conditionals_forcast2;
        private System.Windows.Forms.Label label_descritpion_forcast2;
        private System.Windows.Forms.Label label_wind_forcast2;
        private System.Windows.Forms.Label label_temp_forcast2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_forecast2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

