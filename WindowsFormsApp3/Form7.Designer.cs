namespace WindowsFormsApp3
{
    partial class Form7
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
            this.Pink_bel = new System.Windows.Forms.Button();
            this.Red_bel1 = new System.Windows.Forms.Button();
            this.truck = new System.Windows.Forms.PictureBox();
            this.redlip = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pink_bel
            // 
            this.Pink_bel.Location = new System.Drawing.Point(544, 40);
            this.Pink_bel.Name = "Pink_bel";
            this.Pink_bel.Size = new System.Drawing.Size(97, 47);
            this.Pink_bel.TabIndex = 9;
            this.Pink_bel.Text = "핑크";
            this.Pink_bel.UseVisualStyleBackColor = true;
            // 
            // Red_bel1
            // 
            this.Red_bel1.Location = new System.Drawing.Point(414, 40);
            this.Red_bel1.Name = "Red_bel1";
            this.Red_bel1.Size = new System.Drawing.Size(97, 47);
            this.Red_bel1.TabIndex = 8;
            this.Red_bel1.Text = "레드벨벳";
            this.Red_bel1.UseVisualStyleBackColor = true;
            this.Red_bel1.Click += new System.EventHandler(this.Red_bel1_Click);
            // 
            // truck
            // 
            this.truck.Image = global::WindowsFormsApp3.Properties.Resources.truck;
            this.truck.Location = new System.Drawing.Point(736, 192);
            this.truck.Name = "truck";
            this.truck.Size = new System.Drawing.Size(231, 131);
            this.truck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.truck.TabIndex = 10;
            this.truck.TabStop = false;
            // 
            // redlip
            // 
            this.redlip.Image = global::WindowsFormsApp3.Properties.Resources.Lipstick_orange;
            this.redlip.Location = new System.Drawing.Point(40, 32);
            this.redlip.Name = "redlip";
            this.redlip.Size = new System.Drawing.Size(103, 131);
            this.redlip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redlip.TabIndex = 7;
            this.redlip.TabStop = false;
            this.redlip.Click += new System.EventHandler(this.redlip_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.Lipstick_Pink;
            this.pictureBox2.Location = new System.Drawing.Point(43, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Lipstick_red;
            this.pictureBox1.Location = new System.Drawing.Point(40, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 570);
            this.Controls.Add(this.truck);
            this.Controls.Add(this.Pink_bel);
            this.Controls.Add(this.Red_bel1);
            this.Controls.Add(this.redlip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redlip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pink_bel;
        private System.Windows.Forms.Button Red_bel1;
        private System.Windows.Forms.PictureBox truck;
    }
}