namespace WindowsFormsApp3
{
    partial class Form2
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
            this.btn_input = new System.Windows.Forms.Button();
            this.TB_Mat = new System.Windows.Forms.TextBox();
            this.TB_Pig = new System.Windows.Forms.TextBox();
            this.TB_Perf = new System.Windows.Forms.TextBox();
            this.TB_Col = new System.Windows.Forms.TextBox();
            this.Ma_input = new System.Windows.Forms.ComboBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(672, 96);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "입고";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // TB_Mat
            // 
            this.TB_Mat.Location = new System.Drawing.Point(536, 48);
            this.TB_Mat.Name = "TB_Mat";
            this.TB_Mat.Size = new System.Drawing.Size(100, 25);
            this.TB_Mat.TabIndex = 8;
            this.TB_Mat.TextChanged += new System.EventHandler(this.TB_Mat_TextChanged);
            // 
            // TB_Pig
            // 
            this.TB_Pig.Location = new System.Drawing.Point(696, 48);
            this.TB_Pig.Name = "TB_Pig";
            this.TB_Pig.Size = new System.Drawing.Size(100, 25);
            this.TB_Pig.TabIndex = 10;
            this.TB_Pig.TextChanged += new System.EventHandler(this.TB_Pig_TextChanged);
            // 
            // TB_Perf
            // 
            this.TB_Perf.Location = new System.Drawing.Point(840, 48);
            this.TB_Perf.Name = "TB_Perf";
            this.TB_Perf.Size = new System.Drawing.Size(100, 25);
            this.TB_Perf.TabIndex = 11;
            this.TB_Perf.TextChanged += new System.EventHandler(this.TB_Perf_TextChanged);
            // 
            // TB_Col
            // 
            this.TB_Col.Location = new System.Drawing.Point(992, 48);
            this.TB_Col.Name = "TB_Col";
            this.TB_Col.Size = new System.Drawing.Size(100, 25);
            this.TB_Col.TabIndex = 12;
            this.TB_Col.TextChanged += new System.EventHandler(this.TB_Col_TextChanged);
            // 
            // Ma_input
            // 
            this.Ma_input.FormattingEnabled = true;
            this.Ma_input.Items.AddRange(new object[] {
            "재료",
            "안료",
            "향료",
            "색소"});
            this.Ma_input.Location = new System.Drawing.Point(536, 96);
            this.Ma_input.Name = "Ma_input";
            this.Ma_input.Size = new System.Drawing.Size(121, 23);
            this.Ma_input.TabIndex = 13;
            // 
            // pb1
            // 
            this.pb1.Image = global::WindowsFormsApp3.Properties.Resources.mater3;
            this.pb1.Location = new System.Drawing.Point(176, 40);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(150, 150);
            this.pb1.TabIndex = 19;
            this.pb1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(736, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::WindowsFormsApp3.Properties.Resources.color3;
            this.pb4.Location = new System.Drawing.Point(176, 672);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(150, 150);
            this.pb4.TabIndex = 17;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::WindowsFormsApp3.Properties.Resources.small3;
            this.pb3.Location = new System.Drawing.Point(176, 456);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(150, 150);
            this.pb3.TabIndex = 16;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::WindowsFormsApp3.Properties.Resources.ang4;
            this.pb2.Location = new System.Drawing.Point(176, 248);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(150, 150);
            this.pb2.TabIndex = 15;
            this.pb2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 931);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.Ma_input);
            this.Controls.Add(this.TB_Col);
            this.Controls.Add(this.TB_Perf);
            this.Controls.Add(this.TB_Pig);
            this.Controls.Add(this.TB_Mat);
            this.Controls.Add(this.btn_input);
            this.Name = "Form2";
            this.Text = "       ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox TB_Mat;
        private System.Windows.Forms.TextBox TB_Pig;
        private System.Windows.Forms.TextBox TB_Perf;
        private System.Windows.Forms.TextBox TB_Col;
        private System.Windows.Forms.ComboBox Ma_input;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pb1;
    }
}