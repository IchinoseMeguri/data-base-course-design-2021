
namespace HotelMS
{
    partial class AdminChangeRoomMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "房间";
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "标准间",
            "大床间",
            "单人间",
            "三人间"});
            this.Type.Location = new System.Drawing.Point(400, 247);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(300, 41);
            this.Type.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(200, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "房间类型：";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(900, 350);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(180, 60);
            this.OK.TabIndex = 15;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(900, 450);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.Location = new System.Drawing.Point(900, 250);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 60);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "删除房间";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AdminChangeRoomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminChangeRoomMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店房间自助管理系统 - 修改房间信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete;
    }
}