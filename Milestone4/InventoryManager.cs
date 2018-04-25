using System.Collections.Generic;
using System.Windows.Forms;

//Dylan Svendsen
//CST-117
// 4/8/18
//this is my own work.

namespace Milestone4
{
    class InventoryManager
    {
        private List<Product> items;

        public InventoryManager( )
        {
            items = new List<Product>( );

            /* Product item1 = new Product();
             item1.Name = "Skyrim";
             item1.ReleasePrice = 60.00;
             item1.NumberInStock = 12;
             item1.Producer = "Bethesda";
             item1.CountryOfOrigin = "USA";
             item1.ReleaseDate = 2011;

             items.Add(item1);

             Product item2 = new Product();
             item2.Name = "Fallout 4";
             item2.ReleasePrice = 60.00;
             item2.NumberInStock = 25;
             item2.Producer = "Bethesda";
             item2.CountryOfOrigin = "USA";
             item2.ReleaseDate = 2015;

             items.Add(item2);

             Product item3 = new Product();
             item3.Name = "Final Fantasy XV";
             item3.ReleasePrice = 60.00;
             item3.NumberInStock = 36;
             item3.Producer = "Square Enix";
             item3.CountryOfOrigin = "USA";
             item3.ReleaseDate = 2016;

             items.Add(item3);

             Product item4 = new Product();
             item4.Name = "Sea Of Thieves";
             item4.ReleasePrice = 60.00;
             item4.NumberInStock = 500;
             item4.Producer = "Rare";
             item4.CountryOfOrigin = "USA";
             item4.ReleaseDate = 2018;

             items.Add(item4);

             Product item5 = new Product();
             item5.Name = "Tetris";
             item5.ReleasePrice = 0.00;
             item5.NumberInStock = 500;
             item5.Producer = "Alexey Pajitnov";
             item5.CountryOfOrigin = "Russia";
             item5.ReleaseDate = 1984;

             items.Add(item5);

             Product item6 = new Product();
             item6.Name = "Pacman";
             item6.ReleasePrice = 0.00;
             item6.NumberInStock = 200;
             item6.Producer = "Toru Iwatani";
             item6.CountryOfOrigin = "Japan";
             item6.ReleaseDate = 1980;

             items.Add(item6);
             */
        }
        public List<Product> getItems( )
        {
            return this.items;
        }
        public List<Product> itemsInPriceRange( double lo, double hi )
        {
            List<Product> result = new List<Product>( );

            foreach (Product itm in this.items)
            {
                if (itm.ReleasePrice >= lo && itm.ReleasePrice <= hi)
                {
                    result.Add( itm );
                }
            }
            return result;
        }
        public List<Product> itemsInCountry( string country )
        {
            List<Product> result = new List<Product>( );

            foreach (Product itm in this.items)
            {
                if (itm.CountryOfOrigin == country)
                {
                    result.Add( itm );
                }
            }
            return result;
        }
        public List<Product> doubleSearch( string country, double lo, double hi )
        {
            List<Product> result = new List<Product>( );

            foreach (Product itm in this.items)
            {
                if (itm.CountryOfOrigin == country || itm.ReleasePrice >= lo && itm.ReleasePrice <= hi)
                {
                    result.Add( itm );
                }
            }
            return result;
        }
        public Product findByName( string name )
        {
            Product result = new Product( );


            foreach (Product itm in items)
            {
                if (itm.Name == name)
                {

                    result = itm;
                }
            }
            MessageBox.Show( result.ToString( ) );
            return result;
        }
        public List<Product> itemsByCountry( string country )
        {
            List<Product> result = new List<Product>( );
            foreach (Product itm in this.items)
            {
                if (itm.CountryOfOrigin == country)
                {
                    result.Add( itm );
                }
            }
            return result;
        }
        public void addItem( Product item )
        {
            if (items.Contains( item ))
            {
                item.recieveStock( 10 );
            }
            else
            {
                items.Add( item );
            }
        }

        public bool removeItem( Product item )
        {
            MessageBox.Show( item.Name );
            MessageBox.Show( "item trying to remove: " + item );



            foreach (Product p in items)
            {
                MessageBox.Show( p.Name );
                MessageBox.Show( "items in the array " + p );
            }
            return false;
        }

        public bool reStock( Product item, int a )
        {
            int place = find( item );
            if (place != -1)
            {
                items[ place ].NumberInStock += a;
                return true;
            }
            else
                return false;

        }

        public Product findProducer( string producer )
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[ i ].Producer.Equals( producer ))
                {
                    return items[ i ];
                }
            }
            return null;
        }


        private int find( Product item )
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (item.Equals( items[ i ] ))
                    return i;
            }
            return -1;
        }

        public Product findByRelease( double releaseDate )
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[ i ].ReleaseDate == releaseDate)
                    return items[ i ];
            }
            return null;
        }



        public Product[] toArray( )
        {
            //create an array of the right size
            Product[] arr = new Product[ items.Count ];

            //copy items from list to this array
            //for (int i = 0; i == items.Count; i++)
            int i = 0;
            foreach (Product itm in items)
            {
                arr[ i++ ] = itm;

            }
            return arr;

        }


    }

}