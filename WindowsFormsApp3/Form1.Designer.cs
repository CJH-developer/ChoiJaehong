namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_FSitu = new System.Windows.Forms.Button();
            this.Lib_tb = new System.Windows.Forms.TextBox();
            this.Mat_tb = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.GroupBox();
            this.btn_Sel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DSitu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.cnt,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(32, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(624, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // code
            // 
            this.code.HeaderText = "제품코드";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "제품이름";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // cnt
            // 
            this.cnt.HeaderText = "수량";
            this.cnt.MinimumWidth = 6;
            this.cnt.Name = "cnt";
            this.cnt.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "가격";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // btn_FSitu
            // 
            this.btn_FSitu.Location = new System.Drawing.Point(416, 88);
            this.btn_FSitu.Name = "btn_FSitu";
            this.btn_FSitu.Size = new System.Drawing.Size(104, 48);
            this.btn_FSitu.TabIndex = 3;
            this.btn_FSitu.Text = "공정상황";
            this.btn_FSitu.UseVisualStyleBackColor = true;
            this.btn_FSitu.Click += new System.EventHandler(this.btn_FSitu_Click);
            // 
            // Lib_tb
            // 
            this.Lib_tb.Location = new System.Drawing.Point(136, 40);
            this.Lib_tb.Name = "Lib_tb";
            this.Lib_tb.Size = new System.Drawing.Size(100, 25);
            this.Lib_tb.TabIndex = 4;
            // 
            // Mat_tb
            // 
            this.Mat_tb.Location = new System.Drawing.Point(136, 88);
            this.Mat_tb.Name = "Mat_tb";
            this.Mat_tb.Size = new System.Drawing.Size(100, 25);
            this.Mat_tb.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.btn_Sel);
            this.Search.Controls.Add(this.label6);
            this.Search.Controls.Add(this.label5);
            this.Search.Controls.Add(this.Mat_tb);
            this.Search.Controls.Add(this.Lib_tb);
            this.Search.Location = new System.Drawing.Point(49, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(335, 136);
            this.Search.TabIndex = 11;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // btn_Sel
            // 
            this.btn_Sel.Location = new System.Drawing.Point(248, 40);
            this.btn_Sel.Name = "btn_Sel";
            this.btn_Sel.Size = new System.Drawing.Size(72, 72);
            this.btn_Sel.TabIndex = 14;
            this.btn_Sel.Text = "검색";
            this.btn_Sel.UseVisualStyleBackColor = true;
            this.btn_Sel.Click += new System.EventHandler(this.btn_Sel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "재료 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "제품 이름";
            // 
            // btn_DSitu
            // 
            this.btn_DSitu.Location = new System.Drawing.Point(544, 88);
            this.btn_DSitu.Name = "btn_DSitu";
            this.btn_DSitu.Size = new System.Drawing.Size(104, 48);
            this.btn_DSitu.TabIndex = 12;
            this.btn_DSitu.Text = "입출고현황";
            this.btn_DSitu.UseVisualStyleBackColor = true;
            this.btn_DSitu.Click += new System.EventHandler(this.btn_DSitu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 524);
            this.Controls.Add(this.btn_DSitu);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btn_FSitu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_FSitu;
        private System.Windows.Forms.TextBox Lib_tb;
        private System.Windows.Forms.TextBox Mat_tb;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btn_DSitu;
    }
}

