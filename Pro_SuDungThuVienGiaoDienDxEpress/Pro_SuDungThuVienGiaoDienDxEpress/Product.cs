using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pro_SuDungThuVienGiaoDienDxEpress
{
    public class Product
    {
        int sTT;
        public int STT { 
            get => sTT; 
            set => sTT = value; 
        }

        string productName;
        public string ProductName { 
            get => productName; 
            set => productName = value; 
        }

        double price;
        public double Price
        {
            get => price;
            set => price = value;
        }

        string category;
        public string Category { get => category; set => category = value; }

        
    }
    
}