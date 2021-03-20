namespace Menu_ban_hang
{
    partial class Form_Login
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
            this.Tittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.LoginButt = new System.Windows.Forms.Button();
            this.Exitbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Tw Cen MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.Red;
            this.Tittle.Location = new System.Drawing.Point(28, 43);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(745, 58);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Apps Quan ly nha hang va dat mon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten dang nhap: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mat khau:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(304, 197);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(182, 22);
            this.userName.TabIndex = 1;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(304, 254);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(182, 22);
            this.passWord.TabIndex = 2;
            // 
            // LoginButt
            // 
            this.LoginButt.AutoSize = true;
            this.LoginButt.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButt.Location = new System.Drawing.Point(238, 346);
            this.LoginButt.Name = "LoginButt";
            this.LoginButt.Size = new System.Drawing.Size(123, 38);
            this.LoginButt.TabIndex = 3;
            this.LoginButt.Text = "Dang nhap";
            this.LoginButt.UseVisualStyleBackColor = true;
            this.LoginButt.Click += new System.EventHandler(this.LoginButt_Click);
            // 
            // Exitbutt
            // 
            this.Exitbutt.AutoSize = true;
            this.Exitbutt.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutt.Location = new System.Drawing.Point(423, 346);
            this.Exitbutt.Name = "Exitbutt";
            this.Exitbutt.Size = new System.Drawing.Size(123, 38);
            this.Exitbutt.TabIndex = 4;
            this.Exitbutt.Text = "Thoat";
            this.Exitbutt.UseVisualStyleBackColor = true;
            this.Exitbutt.Click += new System.EventHandler(this.Exitbutt_Click);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.LoginButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 624);
            this.Controls.Add(this.Exitbutt);
            this.Controls.Add(this.LoginButt);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tittle);
            this.Name = "Form_Login";
            this.Text = "Than Thien Voi Nguoi Dung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button LoginButt;
        private System.Windows.Forms.Button Exitbutt;
    }
}

