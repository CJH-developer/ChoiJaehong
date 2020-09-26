namespace WindowsFormsApp3
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
            this.CB_Kind = new System.Windows.Forms.ComboBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.tb_Orcnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_stock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Kind
            // 
            this.CB_Kind.FormattingEnabled = true;
            this.CB_Kind.Items.AddRange(new object[] {
            "켄텔릴라왁스",
            "유동 파라핀"});
            this.CB_Kind.Location = new System.Drawing.Point(96, 24);
            this.CB_Kind.Name = "CB_Kind";
            this.CB_Kind.Size = new System.Drawing.Size(121, 23);
            this.CB_Kind.TabIndex = 0;
            this.CB_Kind.SelectedIndexChanged += new System.EventHandler(this.CB_Kind_SelectedIndexChanged);
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(472, 64);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "구매";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // tb_Orcnt
            // 
            this.tb_Orcnt.Location = new System.Drawing.Point(344, 64);
            this.tb_Orcnt.Name = "tb_Orcnt";
            this.tb_Orcnt.Size = new System.Drawing.Size(100, 25);
            this.tb_Orcnt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "주문 수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "종류";
            // 
            // TB_stock
            // 
            this.TB_stock.Location = new System.Drawing.Point(344, 24);
            this.TB_stock.Name = "TB_stock";
            this.TB_stock.Size = new System.Drawing.Size(100, 25);
            this.TB_stock.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "재고량";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 112);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Orcnt);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.CB_Kind);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Kind;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.TextBox tb_Orcnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_stock;
        private System.Windows.Forms.Label label3;
    }
}