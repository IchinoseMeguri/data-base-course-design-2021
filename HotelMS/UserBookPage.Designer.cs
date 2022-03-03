
namespace HotelMS
{
    partial class UserBookPage
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
            if(disposing&&(components!=null))
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Book = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Roomid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Roomtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(900, 657);
            this.dataGridView1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(1000, 550);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(1000, 350);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 60);
            this.Search.TabIndex = 5;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book.Location = new System.Drawing.Point(1000, 450);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(180, 60);
            this.Book.TabIndex = 6;
            this.Book.Text = "预订";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Roomid);
            this.groupBox1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1000, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间号";
            // 
            // Roomid
            // 
            this.Roomid.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Roomid.Location = new System.Drawing.Point(40, 40);
            this.Roomid.Name = "Roomid";
            this.Roomid.Size = new System.Drawing.Size(100, 43);
            this.Roomid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Roomtype);
            this.groupBox2.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(1000, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间类型";
            // 
            // Roomtype
            // 
            this.Roomtype.FormattingEnabled = true;
            this.Roomtype.Items.AddRange(new object[] {
            "标准间",
            "大床间",
            "单人间",
            "三人间"});
            this.Roomtype.Location = new System.Drawing.Point(40, 40);
            this.Roomtype.Name = "Roomtype";
            this.Roomtype.Size = new System.Drawing.Size(100, 41);
            this.Roomtype.TabIndex = 0;
            // 
            // UserBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserBookPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店房间自助管理系统 - 房间预订";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Roomid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Roomtype;
    }
}