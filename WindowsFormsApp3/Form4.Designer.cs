namespace WindowsFormsApp3
{
    partial class Form4
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
            this.tb_Orcnt = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Orcnt
            // 
            this.tb_Orcnt.Location = new System.Drawing.Point(120, 72);
            this.tb_Orcnt.Name = "tb_Orcnt";
            this.tb_Orcnt.Size = new System.Drawing.Size(100, 25);
            this.tb_Orcnt.TabIndex = 0;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(248, 72);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "구매";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "재고량";
            // 
            // TB_stock
            // 
            this.TB_stock.Location = new System.Drawing.Point(120, 32);
            this.TB_stock.Name = "TB_stock";
            this.TB_stock.Size = new System.Drawing.Size(100, 25);
            this.TB_stock.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 152);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_stock);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.tb_Orcnt);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Orcnt;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_stock;
    }
}