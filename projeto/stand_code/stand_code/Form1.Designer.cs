
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
            this.add_anuncio_button = new System.Windows.Forms.Button();
            this.Veiculos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.preco_veiculo_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.condition_input = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.preco_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.table_pecas = new System.Windows.Forms.DataGridView();
            this.search_peca_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_car = new System.Windows.Forms.Button();
            this.add_favourites_button = new System.Windows.Forms.Button();
            this.buy_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).BeginInit();
            this.Veiculos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_pecas)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(19, 30);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(96, 44);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(121, 30);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(101, 44);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Registo";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(228, 30);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(105, 44);
            this.profile_button.TabIndex = 2;
            this.profile_button.Text = "Perfil";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procurar:";
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(98, 29);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(318, 20);
            this.search_input.TabIndex = 4;
            this.search_input.TextChanged += new System.EventHandler(this.search_input_TextChanged);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(462, 29);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(97, 51);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "Procurar";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_result_table
            // 
            this.search_result_table.AllowUserToAddRows = false;
            this.search_result_table.AllowUserToDeleteRows = false;
            this.search_result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_result_table.Location = new System.Drawing.Point(6, 308);
            this.search_result_table.Name = "search_result_table";
            this.search_result_table.ReadOnly = true;
            this.search_result_table.Size = new System.Drawing.Size(1109, 270);
            this.search_result_table.TabIndex = 6;
            this.search_result_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_result_table_CellClick);
            this.search_result_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_result_table_CellContentClick);
            // 
            // filter_fuel
            // 
            this.filter_fuel.Items.AddRange(new object[] {
            "",
            "Gasolina",
            "Gasoleo",
            "Eletrico"});
            this.filter_fuel.Location = new System.Drawing.Point(98, 74);
            this.filter_fuel.Name = "filter_fuel";
            this.filter_fuel.Size = new System.Drawing.Size(121, 21);
            this.filter_fuel.TabIndex = 7;
            this.filter_fuel.SelectedIndexChanged += new System.EventHandler(this.filter_fuel_SelectedIndexChanged);
            // 
            // fuel_label
            // 
            this.fuel_label.AutoSize = true;
            this.fuel_label.Location = new System.Drawing.Point(14, 77);
            this.fuel_label.Name = "fuel_label";
            this.fuel_label.Size = new System.Drawing.Size(64, 13);
            this.fuel_label.TabIndex = 8;
            this.fuel_label.Text = "Combustivel";
            this.fuel_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Km:";
            // 
            // km_input
            // 
            this.km_input.Location = new System.Drawing.Point(98, 119);
            this.km_input.Name = "km_input";
            this.km_input.Size = new System.Drawing.Size(121, 20);
            this.km_input.TabIndex = 10;
            this.km_input.TextChanged += new System.EventHandler(this.km_input_TextChanged);
            // 
            // add_anuncio_button
            // 
            this.add_anuncio_button.Location = new System.Drawing.Point(784, 30);
            this.add_anuncio_button.Name = "add_anuncio_button";
            this.add_anuncio_button.Size = new System.Drawing.Size(160, 44);
            this.add_anuncio_button.TabIndex = 11;
            this.add_anuncio_button.Text = "Adicionar anuncio de peça";
            this.add_anuncio_button.UseVisualStyleBackColor = true;
            this.add_anuncio_button.Click += new System.EventHandler(this.add_anuncio_button_Click);
            // 
            // Veiculos
            // 
            this.Veiculos.Controls.Add(this.tabPage1);
            this.Veiculos.Controls.Add(this.tabPage2);
            this.Veiculos.Location = new System.Drawing.Point(19, 89);
            this.Veiculos.Name = "Veiculos";
            this.Veiculos.SelectedIndex = 0;
            this.Veiculos.Size = new System.Drawing.Size(1235, 610);
            this.Veiculos.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.preco_veiculo_input);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.search_button);
            this.tabPage1.Controls.Add(this.search_result_table);
            this.tabPage1.Controls.Add(this.km_input);
            this.tabPage1.Controls.Add(this.search_input);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.fuel_label);
            this.tabPage1.Controls.Add(this.filter_fuel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1227, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(582, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // preco_veiculo_input
            // 
            this.preco_veiculo_input.Location = new System.Drawing.Point(98, 163);
            this.preco_veiculo_input.Name = "preco_veiculo_input";
            this.preco_veiculo_input.Size = new System.Drawing.Size(121, 20);
            this.preco_veiculo_input.TabIndex = 12;
            this.preco_veiculo_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.condition_input);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.preco_input);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.table_pecas);
            this.tabPage2.Controls.Add(this.search_peca_input);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1227, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Peça";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(558, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 279);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // condition_input
            // 
            this.condition_input.FormattingEnabled = true;
            this.condition_input.Items.AddRange(new object[] {
            "",
            "Novo",
            "Usado"});
            this.condition_input.Location = new System.Drawing.Point(98, 109);
            this.condition_input.Name = "condition_input";
            this.condition_input.Size = new System.Drawing.Size(121, 21);
            this.condition_input.TabIndex = 19;
            this.condition_input.SelectedIndexChanged += new System.EventHandler(this.condition_input_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Condicao:";
            // 
            // preco_input
            // 
            this.preco_input.Location = new System.Drawing.Point(87, 66);
            this.preco_input.Name = "preco_input";
            this.preco_input.Size = new System.Drawing.Size(121, 20);
            this.preco_input.TabIndex = 17;
            this.preco_input.TextChanged += new System.EventHandler(this.preco_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_pecas
            // 
            this.table_pecas.AllowUserToAddRows = false;
            this.table_pecas.AllowUserToDeleteRows = false;
            this.table_pecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_pecas.Location = new System.Drawing.Point(6, 308);
            this.table_pecas.Name = "table_pecas";
            this.table_pecas.ReadOnly = true;
            this.table_pecas.Size = new System.Drawing.Size(1104, 270);
            this.table_pecas.TabIndex = 14;
            this.table_pecas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_pecas_CellClick);
            // 
            // search_peca_input
            // 
            this.search_peca_input.Location = new System.Drawing.Point(87, 25);
            this.search_peca_input.Name = "search_peca_input";
            this.search_peca_input.Size = new System.Drawing.Size(318, 20);
            this.search_peca_input.TabIndex = 12;
            this.search_peca_input.TextChanged += new System.EventHandler(this.search_peca_input_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_car
            // 
            this.add_car.Location = new System.Drawing.Point(561, 30);
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(160, 44);
            this.add_car.TabIndex = 13;
            this.add_car.Text = "Adicionar anuncio de carro";
            this.add_car.UseVisualStyleBackColor = true;
            this.add_car.Click += new System.EventHandler(this.add_car_Click_1);
            // 
            // add_favourites_button
            // 
            this.add_favourites_button.Location = new System.Drawing.Point(12, 705);
            this.add_favourites_button.Name = "add_favourites_button";
            this.add_favourites_button.Size = new System.Drawing.Size(164, 67);
            this.add_favourites_button.TabIndex = 16;
            this.add_favourites_button.Text = "Adicionar aos favoritos";
            this.add_favourites_button.UseVisualStyleBackColor = true;
            this.add_favourites_button.Click += new System.EventHandler(this.add_favourites_button_Click);
            // 
            // buy_button
            // 
            this.buy_button.Location = new System.Drawing.Point(217, 705);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(164, 67);
            this.buy_button.TabIndex = 17;
            this.buy_button.Text = "Comprar Anúncio:";
            this.buy_button.UseVisualStyleBackColor = true;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 784);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.add_favourites_button);
            this.Controls.Add(this.add_car);
            this.Controls.Add(this.Veiculos);
            this.Controls.Add(this.add_anuncio_button);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_result_table)).EndInit();
            this.Veiculos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_pecas)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button add_anuncio_button;
        private System.Windows.Forms.TabControl Veiculos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView table_pecas;
        private System.Windows.Forms.TextBox search_peca_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preco_veiculo_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preco_input;
        private System.Windows.Forms.ComboBox condition_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_car;
        private System.Windows.Forms.Button add_favourites_button;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

