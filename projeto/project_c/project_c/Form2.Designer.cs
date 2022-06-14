
namespace project_c
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(46, 223);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(119, 139);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(220, 22);
            this.password_input.TabIndex = 3;
            this.password_input.TextChanged += new System.EventHandler(this.password_input_TextChanged);
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(119, 76);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(220, 22);
            this.email_input.TabIndex = 4;
            this.email_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(46, 282);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(46, 338);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button cancel_button;
    }
}