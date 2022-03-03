
namespace HotelMS
{
    partial class UserPage
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
            this.Change = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.Bookroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "lbl用户您好";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Change.Location = new System.Drawing.Point(200, 350);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(180, 60);
            this.Change.TabIndex = 2;
            this.Change.Text = "修改个人信息";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(950, 350);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 60);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Checkout
            // 
            this.Checkout.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Checkout.Location = new System.Drawing.Point(700, 350);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(180, 60);
            this.Checkout.TabIndex = 4;
            this.Checkout.Text = "房间退订";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Bookroom
            // 
            this.Bookroom.Font = new System.Drawing.Font("思源黑体 CN Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bookroom.Location = new System.Drawing.Point(450, 350);
            this.Bookroom.Name = "Bookroom";
            this.Bookroom.Size = new System.Drawing.Size(180, 60);
            this.Bookroom.TabIndex = 5;
            this.Bookroom.Text = "房间预订";
            this.Bookroom.UseVisualStyleBackColor = true;
            this.Bookroom.Click += new System.EventHandler(this.Bookroom_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Bookroom);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label1);
            this.Name = "UserPage";
            this.Text = "酒店房间自助管理系统 - 用户主页";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Button Bookroom;
    }
}