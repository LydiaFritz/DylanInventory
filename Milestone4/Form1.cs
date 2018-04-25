using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class Form1 : Form
    {
        private InventoryManager im = new InventoryManager( );
        private DataTable dt_inventory;
        private DataTable countryTable;

        public Form1( )
        {
            InitializeComponent( );
            LoadManager( );
            GetDataTable( );
            this.dataGridView1.DataSource = dt_inventory;
            this.countryTable = this.getCountryTable( );
            foreach (DataRow dr in countryTable.Rows)
            {
                this.combo_country.Items.Add( dr[ "Name" ].ToString( ) );
            }
        }

        private void GetDataTable( )
        {
            //fils data table
            dt_inventory = new DataTable( );

            //Step 1: get an array representation of the inventory manager
            Product[] itm_arr = im.toArray( );

            dt_inventory.Columns.Add( "Name", typeof( string ) );
            dt_inventory.Columns.Add( "Producer", typeof( string ) );
            dt_inventory.Columns.Add( "Release Date", typeof( string ) );
            dt_inventory.Columns.Add( "Country of Origin", typeof( string ) );
            dt_inventory.Columns.Add( "Release Price", typeof( string ) );
            dt_inventory.Columns.Add( "Number in Stock", typeof( string ) );

            foreach (Product itm in itm_arr)
            {
                dt_inventory.Rows.Add( itm.Name, itm.Producer, itm.ReleaseDate, itm.CountryOfOrigin, itm.ReleasePrice, itm.NumberInStock );
            }

            //update home grid

        }

        private void tabs_SelectedIndexChanged( object sender, EventArgs e )
        {


            if (tabs.SelectedTab == tab_remove)
            {
                this.listBox1.Items.Clear( );
                Product[] itm_arr = im.toArray( );
                foreach (Product itm in itm_arr)
                {
                    this.listBox1.Items.Add( itm.Name );
                }
            }

            if (tabs.SelectedTab == tab_search)
            {
                this.dataGridView2.DataSource = null;
                this.comboBox1.Items.Clear( );
                this.countryTable = this.getCountryTable( );
                foreach (DataRow dr in countryTable.Rows)
                {
                    this.comboBox1.Items.Add( dr[ 0 ].ToString( ) );
                }
            }
            if (tabs.SelectedTab == tab_restock)
            {
                this.cmbo_items.Items.Clear( );
                Product[] itm_arr = im.toArray( );
                foreach (Product itm in itm_arr)
                {
                    this.cmbo_items.Items.Add( itm );
                }
            }



        }
        private DataTable getCountryTable( )
        {
            DataTable tbl = new DataTable( );
            tbl.Columns.Add( "Name" );

            StreamReader sr = new StreamReader( "TextFile1.txt" );

            string str;
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine( );
                tbl.Rows.Add( str );
            }
            return tbl;
        }

        private void btn_add_Click( object sender, EventArgs e )
        {
            Product newItem = new Product( );

            newItem.Name = txt_name.Text;
            newItem.Producer = txt_producer.Text;
            newItem.CountryOfOrigin = combo_country.SelectedItem.ToString( );

            try
            {
                double price = double.Parse( txt_price.Text );
                newItem.ReleasePrice = price;
                try
                {
                    double stock = double.Parse( txt_stock.Text );
                    newItem.NumberInStock = stock;
                    try
                    {
                        double date = double.Parse( txt_date.Text );
                        newItem.ReleaseDate = date;


                        this.im.addItem( newItem );

                        GetDataTable( );



                        this.dataGridView1.DataSource = this.dt_inventory;


                    }
                    catch
                    {
                        MessageBox.Show( "Please Enter an Appropriate Year of release" );
                    }
                }
                catch
                {
                    MessageBox.Show( "Please Enter a number for" );
                }
            }
            catch
            {
                MessageBox.Show( "Please Enter an numeric value for the price" );
            }
            MessageBox.Show( "Item Added Successfully" );

        }
        private void btn_remove_Click( object sender, EventArgs e )
        {
            Product thing = new Product( );
            string name = listBox1.SelectedItem.ToString().Trim();
            MessageBox.Show( name + " = " + name.Length );

            thing = im.findByName( name );

            MessageBox.Show( thing.Name + " = " + thing.Name.Length );

            if (im.removeItem( thing ))
            {
              

                MessageBox.Show( "Successfully Removed Item" );
                listBox1.Items.Clear( );
                Product[] itm_arr = im.toArray( );
                foreach (Product itm in itm_arr)
                {
                    listBox1.Items.Add( itm.Name );
                }
                listBox1.Refresh( );
                GetDataTable( );
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = dt_inventory;

            }

        }


        /* private void btn_remove_Click(object sender, EventArgs e)
         {

             Product str = (Product)listBox1.SelectedItem;
            // Product p = new Product();


             im.removeItem(str);
             GetDataTable();
             this.dataGridView1.DataSource = this.dt_inventory;
             this.listBox1.Items.Clear();

             Product[] itm_arr = im.toArray();
             foreach (Product itm in itm_arr)
             {
                 this.listBox1.Items.Add(itm);
             }
             /*string thing = this.listBox1.SelectedItem.ToString();

             Product itm = Product.getByName(thing);

             if(itm != null)
             {
                 im.removeItem(itm);
                 listBox1.Items.Remove(itemName);
             }


             GetDataTable();
             this.dataGridView1.DataSource = this.dt_inventory;
             this.listBox1.Items.Clear();

             Product[] itm_arr = im.toArray();
             foreach(Product items in itm_arr)
             {
                 this.listBox1.Items.Add(items);
             }
         }*/

        private void btn_search_Click( object sender, EventArgs e )
        {
            if (this.txt_highP.Text != "" && this.txt_lowP.Text != "")
            {
                double loPrice = double.Parse( this.txt_lowP.Text );
                double hiPrice = double.Parse( this.txt_highP.Text );

                List<Product> itemsInRange = im.itemsInPriceRange( loPrice, hiPrice );

                DataTable priceDT = new DataTable( );

                priceDT.Columns.Add( "Name" );
                priceDT.Columns.Add( "Price" );
                priceDT.Columns.Add( "Country of Origin" );


                foreach (Product itm in itemsInRange)
                {
                    priceDT.Rows.Add( itm.Name, itm.ReleasePrice, itm.CountryOfOrigin );
                }
                this.dataGridView2.DataSource = priceDT;
            }
            else if (this.comboBox1.SelectedItem.ToString( ) != "")
            {
                string country = this.comboBox1.SelectedItem.ToString( );

                List<Product> itemsInCountry = im.itemsInCountry( country );

                DataTable priceDT = new DataTable( );

                priceDT.Columns.Add( "Name" );
                priceDT.Columns.Add( "Price" );
                priceDT.Columns.Add( "Country of Origin" );
                foreach (Product itm in itemsInCountry)
                {
                    priceDT.Rows.Add( itm.Name, itm.ReleasePrice, itm.CountryOfOrigin );
                }
                this.dataGridView2.DataSource = priceDT;
            }


        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            List<string> fileUpdateLines = new List<string>( );
            foreach (Product itm in this.im.toArray( ))
            {
                fileUpdateLines.Add( itm.ToString( ) );
            }
            File.WriteAllLines( "inventory.txt", fileUpdateLines );

        }

        private void LoadManager( )
        {
            StreamReader sr = new StreamReader( "inventory.txt" );
            im = new InventoryManager( );
            Product itm = new Product( );

            string str;

            while (!sr.EndOfStream)
            {
                str = sr.ReadLine( );
                itm.Name = str.Trim( );

                str = sr.ReadLine( );
                itm.Producer = str.Trim( );

                str = sr.ReadLine( );
                itm.ReleaseDate = double.Parse( str.Trim( ) );

                str = sr.ReadLine( );
                itm.CountryOfOrigin = str.Trim( );

                str = sr.ReadLine( );
                itm.ReleasePrice = double.Parse( str );

                str = sr.ReadLine( );
                itm.NumberInStock = double.Parse( str );

                im.addItem( itm );

                itm = new Product( );
            }

        }

        private void button1_Click( object sender, EventArgs e )
        {
            Product item = (Product)cmbo_items.SelectedItem;
            try
            {
                int currentStock = int.Parse( txt_amount.Text );
                item.recieveStock( currentStock );
                MessageBox.Show( "Item has been Restocked" );
                GetDataTable( );
                this.dataGridView1.DataSource = this.dt_inventory;
                Product[] itm_arr = im.toArray( );
                foreach (Product thing in itm_arr)
                {
                    this.cmbo_items.Items.Add( thing );
                }
                cmbo_items.SelectedItem = "";
                txt_amount.Text = "";
            }
            catch
            {
                MessageBox.Show( "Error. Make sure an item is selected, and you have an integer to restock" );
            }
        }
    }

}
