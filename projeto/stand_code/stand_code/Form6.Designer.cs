
namespace stand_code
{
    partial class Form6
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
            this.create_ad_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.piece_condition_input = new System.Windows.Forms.ComboBox();
            this.piece_name_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_ad_button
            // 
            this.create_ad_button.Location = new System.Drawing.Point(55, 329);
            this.create_ad_button.Name = "create_ad_button";
            this.create_ad_button.Size = new System.Drawing.Size(75, 23);
            this.create_ad_button.TabIndex = 17;
            this.create_ad_button.Text = "Create";
            this.create_ad_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Piece Condition:";
            // 
            // piece_condition_input
            // 
            this.piece_condition_input.FormattingEnabled = true;
            this.piece_condition_input.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.piece_condition_input.Location = new System.Drawing.Point(136, 232);
            this.piece_condition_input.Name = "piece_condition_input";
            this.piece_condition_input.Size = new System.Drawing.Size(121, 21);
            this.piece_condition_input.TabIndex = 15;
            // 
            // piece_name_input
            // 
            this.piece_name_input.Location = new System.Drawing.Point(136, 187);
            this.piece_name_input.Name = "piece_name_input";
            this.piece_name_input.Size = new System.Drawing.Size(202, 20);
            this.piece_name_input.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Piece Name:";
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(97, 92);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(202, 20);
            this.price_input.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price:";
            // 
            // title_input
            // 
            this.title_input.Location = new System.Drawing.Point(97, 39);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(202, 20);
            this.title_input.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_ad_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.piece_condition_input);
            this.Controls.Add(this.piece_name_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_input);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_ad_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox piece_condition_input;
        private System.Windows.Forms.TextBox piece_name_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.Label label1;
    }
}