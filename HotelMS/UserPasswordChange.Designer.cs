
namespace HotelMS
{
    partial class UserPasswordChange
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
            this.pswf = new System.Windows.Forms.TextBox();
            this.pswn = new System.Windows.Forms.TextBox();
            this.pswn2 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入原始密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(200, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(200, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "请再次输入新密码：";
            // 
            // pswf
            // 
            this.pswf.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pswf.Location = new System.Drawing.Point(500, 147);
            this.pswf.Name = "pswf";
            this.pswf.PasswordChar = '*';
            this.pswf.Size = new System.Drawing.Size(300, 43);
            this.pswf.TabIndex = 5;
            // 
            // pswn
            // 
            this.pswn.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pswn.Location = new System.Drawing.Point(500, 247);
            this.pswn.Name = "pswn";
            this.pswn.PasswordChar = '*';
            this.pswn.Size = new System.Drawing.Size(300, 43);
            this.pswn.TabIndex = 6;
            // 
            // pswn2
            // 
            this.pswn2.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pswn2.Location = new System.Drawing.Point(500, 347);
            this.pswn2.Name = "pswn2";
            this.pswn2.PasswordChar = '*';
            this.pswn2.Size = new System.Drawing.Size(300, 43);
            this.pswn2.TabIndex = 7;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(900, 350);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(180, 60);
            this.OK.TabIndex = 8;
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
            this.Exit.TabIndex = 9;
            this.Exit.Text = "取消";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.pswn2);
            this.Controls.Add(this.pswn);
            this.Controls.Add(this.pswf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店房间自助管理系统 - 修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pswf;
        private System.Windows.Forms.TextBox pswn;
        private System.Windows.Forms.TextBox pswn2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Exit;
    }
}