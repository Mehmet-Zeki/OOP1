using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //ProductManager Ürün ile ilgili operasyonlar bulunur
    // Ekleme,Silme,Güncelleme,Listeleme,Arama,Filtreleme
    //Operasyonlar içerir
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+"güncellendi");
        }
    }
}
