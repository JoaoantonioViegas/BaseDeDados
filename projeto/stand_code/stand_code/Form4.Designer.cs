
namespace stand_code
{
    partial class RegisterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.tel_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nif_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(144, 135);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(132, 20);
            this.email_input.TabIndex = 4;
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(144, 85);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(132, 20);
            this.lastname_input.TabIndex = 5;
            // 
            // firstname_input
            // 
            this.firstname_input.Location = new System.Drawing.Point(144, 40);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(132, 20);
            this.firstname_input.TabIndex = 6;
            this.firstname_input.TextChanged += new System.EventHandler(this.firstname_input_TextChanged);
            // 
            // pw_input
            // 
            this.pw_input.Location = new System.Drawing.Point(144, 180);
            this.pw_input.Name = "pw_input";
            this.pw_input.Size = new System.Drawing.Size(132, 20);
            this.pw_input.TabIndex = 7;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(29, 334);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(191, 334);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // tel_input
            // 
            this.tel_input.Location = new System.Drawing.Point(144, 226);
            this.tel_input.Name = "tel_input";
            this.tel_input.Size = new System.Drawing.Size(132, 20);
            this.tel_input.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telephone:";
            // 
            // Nif_input
            // 
            this.Nif_input.Location = new System.Drawing.Point(144, 279);
            this.Nif_input.Name = "Nif_input";
            this.Nif_input.Size = new System.Drawing.Size(132, 20);
            this.Nif_input.TabIndex = 13;
            this.Nif_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nif:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 539);
            this.Controls.Add(this.Nif_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tel_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.firstname_input);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox lastname_input;
        private System.Windows.Forms.TextBox firstname_input;
        private System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox tel_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nif_input;
        private System.Windows.Forms.Label label6;
    }
}