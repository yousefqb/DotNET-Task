using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Car
    {
       
            #region attributes
            public int id { get; set; }
            public string brand { get; set; }
            public int price { get; set; }
            #endregion

            #region Constructor
            public Car(int _Id, string _brand, int _price)
            {
                id = _Id;
                brand = _brand;
                price = _price;
            }
            public Car(int _Id, string _brand) : this(_Id, _brand, 250) { }
            public Car(int _Id) : this(_Id, "Toyota", 250) { }
            #endregion

            public override string ToString()
            {
                return $" ID : {id} , BRAND : {brand} price : {price}";
            }

        
    }
}
