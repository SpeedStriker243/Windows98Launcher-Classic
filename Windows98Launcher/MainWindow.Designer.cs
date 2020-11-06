namespace Windows98Launcher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Setup = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BootOptions = new System.Windows.Forms.Button();
            this.ClearDisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Windows 98 Launcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Where do you want to go today?";
            // 
            // Setup
            // 
            this.Setup.Image = global::Windows98Launcher.Properties.Resources.SetupIcon;
            this.Setup.Location = new System.Drawing.Point(287, 178);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(84, 84);
            this.Setup.TabIndex = 4;
            this.Setup.UseVisualStyleBackColor = true;
            this.Setup.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start
            // 
            this.Start.Image = global::Windows98Launcher.Properties.Resources.StartIcon;
            this.Start.Location = new System.Drawing.Point(138, 178);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(84, 84);
            this.Start.TabIndex = 3;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows98Launcher.Properties.Resources.WindowsLogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Windows 98";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Setup Windows 98";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Windows 98 Launcher uses QEMU for emulation.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BootOptions
            // 
            this.BootOptions.Location = new System.Drawing.Point(138, 149);
            this.BootOptions.Name = "BootOptions";
            this.BootOptions.Size = new System.Drawing.Size(84, 23);
            this.BootOptions.TabIndex = 7;
            this.BootOptions.Text = "Boot Options";
            this.BootOptions.UseVisualStyleBackColor = true;
            this.BootOptions.Click += new System.EventHandler(this.button3_Click);
            // 
            // ClearDisk
            // 
            this.ClearDisk.Location = new System.Drawing.Point(287, 149);
            this.ClearDisk.Name = "ClearDisk";
            this.ClearDisk.Size = new System.Drawing.Size(84, 23);
            this.ClearDisk.TabIndex = 8;
            this.ClearDisk.Text = "Clear Disk";
            this.ClearDisk.UseVisualStyleBackColor = true;
            this.ClearDisk.Click += new System.EventHandler(this.ClearDisk_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 359);
            this.Controls.Add(this.ClearDisk);
            this.Controls.Add(this.BootOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Setup);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Windows 98 Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Setup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BootOptions;
        private System.Windows.Forms.Button ClearDisk;
    }
}

