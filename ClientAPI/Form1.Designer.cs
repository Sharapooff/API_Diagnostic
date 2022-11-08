namespace ClientAPI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.registration = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.LogInTextLogIn = new System.Windows.Forms.TextBox();
            this.LogInTextPasword = new System.Windows.Forms.TextBox();
            this.RegistrationTextLog = new System.Windows.Forms.TextBox();
            this.RegistrationTextPasword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(199, 107);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(100, 23);
            this.registration.TabIndex = 0;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(62, 107);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 23);
            this.login.TabIndex = 1;
            this.login.Text = "LogIn";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LogInTextLogIn
            // 
            this.LogInTextLogIn.Location = new System.Drawing.Point(62, 37);
            this.LogInTextLogIn.Name = "LogInTextLogIn";
            this.LogInTextLogIn.Size = new System.Drawing.Size(100, 20);
            this.LogInTextLogIn.TabIndex = 2;
            // 
            // LogInTextPasword
            // 
            this.LogInTextPasword.Location = new System.Drawing.Point(62, 63);
            this.LogInTextPasword.Name = "LogInTextPasword";
            this.LogInTextPasword.Size = new System.Drawing.Size(100, 20);
            this.LogInTextPasword.TabIndex = 3;
            // 
            // RegistrationTextLog
            // 
            this.RegistrationTextLog.Location = new System.Drawing.Point(199, 37);
            this.RegistrationTextLog.Name = "RegistrationTextLog";
            this.RegistrationTextLog.Size = new System.Drawing.Size(100, 20);
            this.RegistrationTextLog.TabIndex = 4;
            // 
            // RegistrationTextPasword
            // 
            this.RegistrationTextPasword.Location = new System.Drawing.Point(199, 63);
            this.RegistrationTextPasword.Name = "RegistrationTextPasword";
            this.RegistrationTextPasword.Size = new System.Drawing.Size(100, 20);
            this.RegistrationTextPasword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LogIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "pasword:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 159);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationTextPasword);
            this.Controls.Add(this.RegistrationTextLog);
            this.Controls.Add(this.LogInTextPasword);
            this.Controls.Add(this.LogInTextLogIn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registration);
            this.Name = "Form1";
            this.Text = "Client_API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox LogInTextLogIn;
        private System.Windows.Forms.TextBox LogInTextPasword;
        private System.Windows.Forms.TextBox RegistrationTextLog;
        private System.Windows.Forms.TextBox RegistrationTextPasword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

