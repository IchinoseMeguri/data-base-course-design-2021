
namespace HotelMS
{
    partial class UserMessage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.TellText = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.PswChange = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "lbl用户您好";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(200, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "联系电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(200, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "居民身份证号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(200, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "姓名：";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameText.Location = new System.Drawing.Point(400, 247);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(300, 43);
            this.NameText.TabIndex = 6;
            // 
            // IdText
            // 
            this.IdText.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdText.Location = new System.Drawing.Point(400, 347);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(300, 43);
            this.IdText.TabIndex = 7;
            // 
            // TellText
            // 
            this.TellText.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TellText.Location = new System.Drawing.Point(400, 447);
            this.TellText.Name = "TellText";
            this.TellText.Size = new System.Drawing.Size(300, 43);
            this.TellText.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save.Location = new System.Drawing.Point(900, 350);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 60);
            this.Save.TabIndex = 9;
            this.Save.Text = "保存信息";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PswChange
            // 
            this.PswChange.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PswChange.Location = new System.Drawing.Point(900, 250);
            this.PswChange.Name = "PswChange";
            this.PswChange.Size = new System.Drawing.Size(180, 60);
            this.PswChange.TabIndex = 10;
            this.PswChange.Text = "修改密码";
            this.PswChange.UseVisualStyleBackColor = true;
            this.PswChange.Click += new System.EventHandler(this.PswChange_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(900, 450);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PswChange);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TellText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店房间自助管理系统 - 修改个人信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox TellText;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button PswChange;
        private System.Windows.Forms.Button Exit;
    }
}