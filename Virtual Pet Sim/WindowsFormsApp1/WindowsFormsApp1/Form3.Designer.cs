namespace WindowsFormsApp1
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pat = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.Happiness = new System.Windows.Forms.ProgressBar();
            this.Energy = new System.Windows.Forms.ProgressBar();
            this.Hunger = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(313, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 166);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Pat
            // 
            this.Pat.Location = new System.Drawing.Point(703, 221);
            this.Pat.Name = "Pat";
            this.Pat.Size = new System.Drawing.Size(75, 23);
            this.Pat.TabIndex = 2;
            this.Pat.Text = "Pat";
            this.Pat.UseVisualStyleBackColor = true;
            this.Pat.Click += new System.EventHandler(this.Pat_Click);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(703, 163);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(75, 23);
            this.Feed.TabIndex = 3;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Rest
            // 
            this.Rest.Location = new System.Drawing.Point(703, 192);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(75, 23);
            this.Rest.TabIndex = 4;
            this.Rest.Text = "Rest";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // Happiness
            // 
            this.Happiness.Location = new System.Drawing.Point(483, 403);
            this.Happiness.Name = "Happiness";
            this.Happiness.Size = new System.Drawing.Size(83, 20);
            this.Happiness.TabIndex = 7;
            this.Happiness.Value = 100;
            // 
            // Energy
            // 
            this.Energy.Location = new System.Drawing.Point(363, 403);
            this.Energy.Name = "Energy";
            this.Energy.Size = new System.Drawing.Size(83, 20);
            this.Energy.TabIndex = 8;
            this.Energy.Value = 100;
            // 
            // Hunger
            // 
            this.Hunger.Location = new System.Drawing.Point(241, 403);
            this.Hunger.Name = "Hunger";
            this.Hunger.Size = new System.Drawing.Size(83, 20);
            this.Hunger.TabIndex = 9;
            this.Hunger.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Happiness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Energy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hunger";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hunger);
            this.Controls.Add(this.Energy);
            this.Controls.Add(this.Happiness);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Pat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pat;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.ProgressBar Happiness;
        private System.Windows.Forms.ProgressBar Energy;
        private System.Windows.Forms.ProgressBar Hunger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}