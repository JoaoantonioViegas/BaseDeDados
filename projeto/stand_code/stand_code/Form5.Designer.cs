
namespace stand_code
{
    partial class AddAdvertisementForm
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
            this.title_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.piece_name_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.piece_condition_input = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.create_ad_button = new System.Windows.Forms.Button();
            this.categoria_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // title_input
            // 
            this.title_input.Location = new System.Drawing.Point(76, 38);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(202, 20);
            this.title_input.TabIndex = 1;
            this.title_input.TextChanged += new System.EventHandler(this.title_input_TextChanged);
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(76, 91);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(202, 20);
            this.price_input.TabIndex = 3;
            this.price_input.TextChanged += new System.EventHandler(this.price_label_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // piece_name_input
            // 
            this.piece_name_input.Location = new System.Drawing.Point(115, 186);
            this.piece_name_input.Name = "piece_name_input";
            this.piece_name_input.Size = new System.Drawing.Size(202, 20);
            this.piece_name_input.TabIndex = 5;
            this.piece_name_input.TextChanged += new System.EventHandler(this.piece_name_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Piece Name:";
            // 
            // piece_condition_input
            // 
            this.piece_condition_input.FormattingEnabled = true;
            this.piece_condition_input.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.piece_condition_input.Location = new System.Drawing.Point(115, 231);
            this.piece_condition_input.Name = "piece_condition_input";
            this.piece_condition_input.Size = new System.Drawing.Size(121, 21);
            this.piece_condition_input.TabIndex = 6;
            this.piece_condition_input.SelectedIndexChanged += new System.EventHandler(this.piece_condition_input_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Piece Condition:";
            // 
            // create_ad_button
            // 
            this.create_ad_button.Location = new System.Drawing.Point(34, 328);
            this.create_ad_button.Name = "create_ad_button";
            this.create_ad_button.Size = new System.Drawing.Size(75, 23);
            this.create_ad_button.TabIndex = 8;
            this.create_ad_button.Text = "Create";
            this.create_ad_button.UseVisualStyleBackColor = true;
            this.create_ad_button.Click += new System.EventHandler(this.create_ad_button_Click);
            // 
            // categoria_input
            // 
            this.categoria_input.Location = new System.Drawing.Point(115, 270);
            this.categoria_input.Name = "categoria_input";
            this.categoria_input.Size = new System.Drawing.Size(202, 20);
            this.categoria_input.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Piece Category:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddAdvertisementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 600);
            this.Controls.Add(this.categoria_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.create_ad_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.piece_condition_input);
            this.Controls.Add(this.piece_name_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_input);
            this.Controls.Add(this.label1);
            this.Name = "AddAdvertisementForm";
            this.Text = "Add Avertisement";
            this.Load += new System.EventHandler(this.AddAdvertisementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox piece_name_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox piece_condition_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button create_ad_button;
        private System.Windows.Forms.TextBox categoria_input;
        private System.Windows.Forms.Label label5;
    }
}