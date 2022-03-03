
namespace HotelMS
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Register = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Forgetpsw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(700, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(700, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // AccountText
            // 
            this.AccountText.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AccountText.Location = new System.Drawing.Point(850, 247);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(300, 43);
            this.AccountText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordText.Location = new System.Drawing.Point(850, 347);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(300, 43);
            this.PasswordText.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Login.Location = new System.Drawing.Point(700, 450);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(180, 60);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(200, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "现在时间";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltime.Location = new System.Drawing.Point(200, 350);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(95, 33);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "lbltime";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Register.Location = new System.Drawing.Point(970, 450);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(180, 60);
            this.Register.TabIndex = 8;
            this.Register.Text = "注册";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exit.Location = new System.Drawing.Point(970, 550);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Forgetpsw
            // 
            this.Forgetpsw.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Forgetpsw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Forgetpsw.Location = new System.Drawing.Point(700, 550);
            this.Forgetpsw.Name = "Forgetpsw";
            this.Forgetpsw.Size = new System.Drawing.Size(180, 60);
            this.Forgetpsw.TabIndex = 10;
            this.Forgetpsw.Text = "忘记密码";
            this.Forgetpsw.UseVisualStyleBackColor = true;
            this.Forgetpsw.Click += new System.EventHandler(this.Forgetpsw_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Forgetpsw);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.AccountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "酒店房间自助管理系统 - 登录";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Forgetpsw;
    }
}

