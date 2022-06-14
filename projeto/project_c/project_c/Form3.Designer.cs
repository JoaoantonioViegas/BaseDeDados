
namespace project_c
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
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstname_input
            // 
            this.firstname_input.Location = new System.Drawing.Point(152, 82);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(100, 22);
            this.firstname_input.TabIndex = 1;
            this.firstname_input.TextChanged += new System.EventHandler(this.firstname_input_TextChanged);
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(152, 150);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(100, 22);
            this.lastname_input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Último Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(152, 214);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(100, 22);
            this.email_input.TabIndex = 5;
            this.email_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pw_input
            // 
            this.pw_input.Location = new System.Drawing.Point(152, 274);
            this.pw_input.Name = "pw_input";
            this.pw_input.Size = new System.Drawing.Size(100, 22);
            this.pw_input.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // tel_input
            // 
            this.tel_input.Location = new System.Drawing.Point(152, 331);
            this.tel_input.Name = "tel_input";
            this.tel_input.Size = new System.Drawing.Size(100, 22);
            this.tel_input.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(423, 79);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 10;
            this.register_button.Text = "Submit";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.tel_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname_input);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname_input;
        private System.Windows.Forms.TextBox lastname_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_input;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button register_button;
    }
}