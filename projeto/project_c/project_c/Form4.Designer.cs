
namespace project_c
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
            this.email_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.table_anuncios_utilizador_carros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.table_anuncios_utilizador_pecas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_carros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_pecas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(90, 18);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(0, 17);
            this.email_label.TabIndex = 1;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(531, 18);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(0, 17);
            this.fname_label.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fname:";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(849, 18);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(0, 17);
            this.lname_label.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lname:";
            // 
            // table_anuncios_utilizador_carros
            // 
            this.table_anuncios_utilizador_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_anuncios_utilizador_carros.Location = new System.Drawing.Point(12, 85);
            this.table_anuncios_utilizador_carros.Name = "table_anuncios_utilizador_carros";
            this.table_anuncios_utilizador_carros.RowHeadersWidth = 51;
            this.table_anuncios_utilizador_carros.RowTemplate.Height = 24;
            this.table_anuncios_utilizador_carros.Size = new System.Drawing.Size(1558, 341);
            this.table_anuncios_utilizador_carros.TabIndex = 6;
            this.table_anuncios_utilizador_carros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Anounces:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(1495, 856);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Your Anounces:";
            // 
            // table_anuncios_utilizador_pecas
            // 
            this.table_anuncios_utilizador_pecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_anuncios_utilizador_pecas.Location = new System.Drawing.Point(12, 471);
            this.table_anuncios_utilizador_pecas.Name = "table_anuncios_utilizador_pecas";
            this.table_anuncios_utilizador_pecas.RowHeadersWidth = 51;
            this.table_anuncios_utilizador_pecas.RowTemplate.Height = 24;
            this.table_anuncios_utilizador_pecas.Size = new System.Drawing.Size(1558, 341);
            this.table_anuncios_utilizador_pecas.TabIndex = 9;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 924);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.table_anuncios_utilizador_pecas);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table_anuncios_utilizador_carros);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_carros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_anuncios_utilizador_pecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView table_anuncios_utilizador_carros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView table_anuncios_utilizador_pecas;
    }
}