
namespace project_c
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.filter_fuel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.km_input = new System.Windows.Forms.TextBox();
            this.search_result_table = new System.Windows.Forms.DataGridView();
            this.profile_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(12, 26);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(813, 96);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(455, 22);
            this.search_input.TabIndex = 8;
            this.search_input.TextChanged += new System.EventHandler(this.search_input_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1296, 95);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 10;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // filter_fuel
            // 
            this.filter_fuel.FormattingEnabled = true;
            this.filter_fuel.Items.AddRange(new object[] {
            "",
            "Gasolina",
            "Eletrico",
            "Gasoleo"});
            this.filter_fuel.Location = new System.Drawing.Point(813, 154);
            this.filter_fuel.Name = "filter_fuel";
            this.filter_fuel.Size = new System.Drawing.Size(204, 24);
            this.filter_fuel.TabIndex = 11;
            this.filter_fuel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fuel Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kilometers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // km_input
            // 
            this.km_input.Location = new System.Drawing.Point(813, 237);
            this.km_input.Name = "km_input";
            this.km_input.Size = new System.Drawing.Size(166, 22);
            this.km_input.TabIndex = 15;
            this.km_input.TextChanged += new System.EventHandler(this.km_input_TextChanged);
            // 
            // search_result_table
            // 
            this.search_result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_result_table.Location = new System.Drawing.Point(3, 309);
            this.search_result_table.Name = "search_result_table";
            this.search_result_table.RowHeadersWidth = 51;
            this.search_result_table.RowTemplate.Height = 24;
            this.search_result_table.Size = new System.Drawing.Size(1640, 480);
            this.search_result_table.TabIndex = 16;
            this.search_result_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(174, 26);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(75, 23);
            this.profile_button.TabIndex = 17;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 790);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.search_result_table);
            this.Controls.Add(this.km_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filter_fuel);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.button3);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ComboBox filter_fuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox km_input;
        private System.Windows.Forms.DataGridView search_result_table;
        private System.Windows.Forms.Button profile_button;
    }
}

