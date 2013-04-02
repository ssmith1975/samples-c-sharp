using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_DefiningProperties
{
    class Wine
    {
        private string Name;
        private int year;
        private string Apellation;
        private decimal wholesalePrice;
        private const decimal retailMarkup = 1.35m;

        public decimal Price
        {
            get
            {
                return wholesalePrice * retailMarkup;
            }

            set
            {
                wholesalePrice = value;
            }
        }

        
        public string MenuDescription
        {
            // read only
            get
            {
                return year.ToString() + " " + Name + ", " + Apellation; 
            }
        }

        public Wine(int y, string sName, string sApp, decimal wp)
        {
            Name = sName;
            year = y;
            Apellation = sApp;
            wholesalePrice = wp;
        }

    }
}
