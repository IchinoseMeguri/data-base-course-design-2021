﻿
namespace HotelMS
{
    partial class AdminUserPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Userid = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Userid);
            this.groupBox1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1000, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户名";
            // 
            // Userid
            // 
            this.Userid.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Userid.Location = new System.Drawing.Point(6, 40);
            this.Userid.Name = "Userid";
            this.Userid.Size = new System.Drawing.Size(168, 43);
            this.Userid.TabIndex = 0;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Change.Location = new System.Drawing.Point(1000, 450);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(180, 60);
            this.Change.TabIndex = 11;
            this.Change.Text = "修改";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(1000, 350);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 60);
            this.Search.TabIndex = 10;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(1000, 550);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.dataGridView1.TabIndex = 8;
            // 
            // AdminUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminUserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店房间自助管理系统 - 修改用户信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Userid;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}