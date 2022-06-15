
namespace stand_code
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
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_input = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.search_result_table = new System.Windows.Forms.DataGridView();
            this.filter_fuel = new System.Windows.Forms.ComboBox();
            this.fuel_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.km_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(40, 30);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(121, 30);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(202, 30);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(75, 23);
            this.profile_button.TabIndex = 2;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(526, 37);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(318, 20);
            this.search_input.TabIndex = 4;
            this.search_input.TextChanged += new System.EventHandler(this.search_input_TextChanged);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(896, 35);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_result_table
            // 
            this.search_result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_result_table.Location = new System.Drawing.Point(305, 317);
            this.search_result_table.Name = "search_result_table";
            this.search_result_table.Size = new System.Drawing.Size(904, 270);
            this.search_result_table.TabIndex = 6;
            // 
            // filter_fuel
            // 
            this.filter_fuel.FormattingEnabled = true;
            this.filter_fuel.Items.AddRange(new object[] {
            "",
            "Eletrico",
            "Gasolina",
            "Gasoleo"});
            this.filter_fuel.Location = new System.Drawing.Point(526, 115);
            this.filter_fuel.Name = "filter_fuel";
            this.filter_fuel.Size = new System.Drawing.Size(121, 21);
            this.filter_fuel.TabIndex = 7;
            this.filter_fuel.SelectedIndexChanged += new System.EventHandler(this.filter_fuel_SelectedIndexChanged);
            // 
            // fuel_label
            // 
            this.fuel_label.AutoSize = true;
            this.fuel_label.Location = new System.Drawing.Point(465, 115);
            this.fuel_label.Name = "fuel_label";
            this.fuel_label.Size = new System.Drawing.Size(30, 13);
            this.fuel_label.TabIndex = 8;
            this.fuel_label.Text = "Fuel:";
            this.fuel_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Km:";
            // 
            // km_input
            // 
            this.km_input.Location = new System.Drawing.Point(526, 165);
            this.km_input.Name = "km_input";
            this.km_input.Size = new System.Drawing.Size(121, 20);
            this.km_input.TabIndex = 10;
            this.km_input.TextChanged += new System.EventHandler(this.km_input_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 766);
            this.Controls.Add(this.km_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuel_label);
            this.Controls.Add(this.filter_fuel);
            this.Controls.Add(this.search_result_table);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView search_result_table;
        private System.Windows.Forms.ComboBox filter_fuel;
        private System.Windows.Forms.Label fuel_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox km_input;
    }
}

