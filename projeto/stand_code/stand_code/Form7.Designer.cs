
namespace stand_code
{
    partial class ChangeCredentialsForm
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
            this.new_email_input = new System.Windows.Forms.TextBox();
            this.new_password_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_email_input
            // 
            this.new_email_input.Location = new System.Drawing.Point(162, 36);
            this.new_email_input.Name = "new_email_input";
            this.new_email_input.Size = new System.Drawing.Size(190, 20);
            this.new_email_input.TabIndex = 0;
            // 
            // new_password_input
            // 
            this.new_password_input.Location = new System.Drawing.Point(162, 117);
            this.new_password_input.Name = "new_password_input";
            this.new_password_input.Size = new System.Drawing.Size(190, 20);
            this.new_password_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(66, 186);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(94, 46);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "Editar";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(223, 186);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(87, 46);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ChangeCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 283);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_password_input);
            this.Controls.Add(this.new_email_input);
            this.Name = "ChangeCredentialsForm";
            this.Text = "Change Credentials";
            this.Load += new System.EventHandler(this.ChangeCredentialsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_email_input;
        private System.Windows.Forms.TextBox new_password_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
    }
}