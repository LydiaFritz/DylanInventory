namespace Milestone4
{
    partial class Form1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_restock = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbo_items = new System.Windows.Forms.ComboBox();
            this.tab_addItem = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_producer = new System.Windows.Forms.TextBox();
            this.tab_remove = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tab_search = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_highP = new System.Windows.Forms.TextBox();
            this.txt_lowP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tab_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_restock.SuspendLayout();
            this.tab_addItem.SuspendLayout();
            this.tab_remove.SuspendLayout();
            this.tab_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_home);
            this.tabs.Controls.Add(this.tab_restock);
            this.tabs.Controls.Add(this.tab_addItem);
            this.tabs.Controls.Add(this.tab_remove);
            this.tabs.Controls.Add(this.tab_search);
            this.tabs.Location = new System.Drawing.Point(1, 1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(801, 445);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tab_home
            // 
            this.tab_home.Controls.Add(this.dataGridView1);
            this.tab_home.Location = new System.Drawing.Point(4, 22);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(793, 419);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_restock
            // 
            this.tab_restock.Controls.Add(this.label11);
            this.tab_restock.Controls.Add(this.label8);
            this.tab_restock.Controls.Add(this.txt_amount);
            this.tab_restock.Controls.Add(this.button1);
            this.tab_restock.Controls.Add(this.cmbo_items);
            this.tab_restock.Location = new System.Drawing.Point(4, 22);
            this.tab_restock.Name = "tab_restock";
            this.tab_restock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_restock.Size = new System.Drawing.Size(793, 419);
            this.tab_restock.TabIndex = 1;
            this.tab_restock.Text = "Restock";
            this.tab_restock.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Amount to Restock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Item to Restock";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(261, 171);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(152, 20);
            this.txt_amount.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbo_items
            // 
            this.cmbo_items.FormattingEnabled = true;
            this.cmbo_items.Location = new System.Drawing.Point(261, 97);
            this.cmbo_items.Name = "cmbo_items";
            this.cmbo_items.Size = new System.Drawing.Size(255, 21);
            this.cmbo_items.TabIndex = 0;
            // 
            // tab_addItem
            // 
            this.tab_addItem.Controls.Add(this.label7);
            this.tab_addItem.Controls.Add(this.btn_add);
            this.tab_addItem.Controls.Add(this.combo_country);
            this.tab_addItem.Controls.Add(this.label6);
            this.tab_addItem.Controls.Add(this.label5);
            this.tab_addItem.Controls.Add(this.label4);
            this.tab_addItem.Controls.Add(this.label3);
            this.tab_addItem.Controls.Add(this.label2);
            this.tab_addItem.Controls.Add(this.txt_name);
            this.tab_addItem.Controls.Add(this.txt_stock);
            this.tab_addItem.Controls.Add(this.txt_price);
            this.tab_addItem.Controls.Add(this.txt_date);
            this.tab_addItem.Controls.Add(this.txt_producer);
            this.tab_addItem.Location = new System.Drawing.Point(4, 22);
            this.tab_addItem.Name = "tab_addItem";
            this.tab_addItem.Size = new System.Drawing.Size(793, 419);
            this.tab_addItem.TabIndex = 2;
            this.tab_addItem.Text = "Add New Item";
            this.tab_addItem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Item Name";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(412, 163);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 36;
            this.btn_add.Text = "Add item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combo_country
            // 
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Location = new System.Drawing.Point(139, 145);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(100, 21);
            this.combo_country.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Amount in Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Release Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Country of Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Release Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Producer";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(139, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 6;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(402, 75);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(402, 38);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 4;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(139, 110);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 2;
            // 
            // txt_producer
            // 
            this.txt_producer.Location = new System.Drawing.Point(139, 75);
            this.txt_producer.Name = "txt_producer";
            this.txt_producer.Size = new System.Drawing.Size(100, 20);
            this.txt_producer.TabIndex = 1;
            // 
            // tab_remove
            // 
            this.tab_remove.Controls.Add(this.listBox1);
            this.tab_remove.Controls.Add(this.btn_remove);
            this.tab_remove.Location = new System.Drawing.Point(4, 22);
            this.tab_remove.Name = "tab_remove";
            this.tab_remove.Size = new System.Drawing.Size(793, 419);
            this.tab_remove.TabIndex = 3;
            this.tab_remove.Text = "Remove Item";
            this.tab_remove.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(780, 368);
            this.listBox1.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(7, 378);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(776, 37);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Remove Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tab_search
            // 
            this.tab_search.Controls.Add(this.dataGridView2);
            this.tab_search.Controls.Add(this.btn_search);
            this.tab_search.Controls.Add(this.comboBox1);
            this.tab_search.Controls.Add(this.txt_highP);
            this.tab_search.Controls.Add(this.txt_lowP);
            this.tab_search.Controls.Add(this.label10);
            this.tab_search.Controls.Add(this.label9);
            this.tab_search.Controls.Add(this.label1);
            this.tab_search.Location = new System.Drawing.Point(4, 22);
            this.tab_search.Name = "tab_search";
            this.tab_search.Padding = new System.Windows.Forms.Padding(3);
            this.tab_search.Size = new System.Drawing.Size(793, 419);
            this.tab_search.TabIndex = 4;
            this.tab_search.Text = "Search";
            this.tab_search.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(257, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(530, 407);
            this.dataGridView2.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(26, 374);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txt_highP
            // 
            this.txt_highP.Location = new System.Drawing.Point(116, 118);
            this.txt_highP.Name = "txt_highP";
            this.txt_highP.Size = new System.Drawing.Size(100, 20);
            this.txt_highP.TabIndex = 6;
            // 
            // txt_lowP
            // 
            this.txt_lowP.Location = new System.Drawing.Point(116, 64);
            this.txt_lowP.Name = "txt_lowP";
            this.txt_lowP.Size = new System.Drawing.Size(100, 20);
            this.txt_lowP.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "High Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Country Of Origin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_restock.ResumeLayout(false);
            this.tab_restock.PerformLayout();
            this.tab_addItem.ResumeLayout(false);
            this.tab_addItem.PerformLayout();
            this.tab_remove.ResumeLayout(false);
            this.tab_search.ResumeLayout(false);
            this.tab_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_restock;
        private System.Windows.Forms.TabPage tab_addItem;
        private System.Windows.Forms.TabPage tab_remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_producer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TabPage tab_search;
        private System.Windows.Forms.TextBox txt_highP;
        private System.Windows.Forms.TextBox txt_lowP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbo_items;
        private System.Windows.Forms.ListBox listBox1;
    }
}

