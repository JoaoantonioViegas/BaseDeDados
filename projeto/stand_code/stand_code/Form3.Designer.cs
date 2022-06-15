
namespace stand_code
{
    partial class ProfileForm
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
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.tel_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.table_anuncios_utilizador_carros = new System.Windows.Forms.DataGridView();
            this.table_anuncios_utilizador_pecas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_carros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_pecas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone:";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(102, 20);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(0, 13);
            this.fname_label.TabIndex = 4;
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(105, 52);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(0, 13);
            this.lname_label.TabIndex = 5;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(409, 20);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(0, 13);
            this.email_label.TabIndex = 6;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Location = new System.Drawing.Point(409, 53);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(0, 13);
            this.tel_label.TabIndex = 7;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(706, 10);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // table_anuncios_utilizador_carros
            // 
            this.table_anuncios_utilizador_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_anuncios_utilizador_carros.Location = new System.Drawing.Point(12, 95);
            this.table_anuncios_utilizador_carros.Name = "table_anuncios_utilizador_carros";
            this.table_anuncios_utilizador_carros.Size = new System.Drawing.Size(1201, 246);
            this.table_anuncios_utilizador_carros.TabIndex = 9;
            // 
            // table_anuncios_utilizador_pecas
            // 
            this.table_anuncios_utilizador_pecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_anuncios_utilizador_pecas.Location = new System.Drawing.Point(12, 387);
            this.table_anuncios_utilizador_pecas.Name = "table_anuncios_utilizador_pecas";
            this.table_anuncios_utilizador_pecas.Size = new System.Drawing.Size(1201, 246);
            this.table_anuncios_utilizador_pecas.TabIndex = 10;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 654);
            this.Controls.Add(this.table_anuncios_utilizador_pecas);
            this.Controls.Add(this.table_anuncios_utilizador_carros);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_carros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_pecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DataGridView table_anuncios_utilizador_carros;
        private System.Windows.Forms.DataGridView table_anuncios_utilizador_pecas;
    }
}