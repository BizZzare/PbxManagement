namespace PbxManagement
{
    partial class LoginForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbPasswordNormal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbUsername.Location = new System.Drawing.Point(65, 190);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(343, 19);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Username";
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsername.Location = new System.Drawing.Point(27, 222);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(381, 1);
            this.panelUsername.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPassword.Location = new System.Drawing.Point(27, 287);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(381, 1);
            this.panelPassword.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Location = new System.Drawing.Point(65, 255);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(309, 19);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Password";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(254)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignIn.Location = new System.Drawing.Point(121, 369);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(177, 51);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImage = global::PbxManagement.Properties.Resources.closed_eye;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnShowPassword.Location = new System.Drawing.Point(380, 249);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(28, 28);
            this.btnShowPassword.TabIndex = 8;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PbxManagement.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnClose.Location = new System.Drawing.Point(380, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.BackgroundImage = global::PbxManagement.Properties.Resources.password_white;
            this.pbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPassword.InitialImage = null;
            this.pbPassword.Location = new System.Drawing.Point(27, 249);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 32);
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImage = global::PbxManagement.Properties.Resources.user_white;
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsername.InitialImage = null;
            this.pbUsername.Location = new System.Drawing.Point(27, 184);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 32);
            this.pbUsername.TabIndex = 1;
            this.pbUsername.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PbxManagement.Properties.Resources.logo1;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(146, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tbPasswordNormal
            // 
            this.tbPasswordNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbPasswordNormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordNormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordNormal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPasswordNormal.Location = new System.Drawing.Point(65, 255);
            this.tbPasswordNormal.Name = "tbPasswordNormal";
            this.tbPasswordNormal.Size = new System.Drawing.Size(309, 19);
            this.tbPasswordNormal.TabIndex = 9;
            this.tbPasswordNormal.Text = "Password";
            this.tbPasswordNormal.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(420, 457);
            this.Controls.Add(this.tbPasswordNormal);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox tbPasswordNormal;
    }
}

