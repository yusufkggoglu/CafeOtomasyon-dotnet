using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ComplexTypes
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int Masa { get; set; }
        public string Ürün { get; set; }
        public decimal Fiyat { get; set; }
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanıcı { get; set; }
        public string Not { get; set; }
    }
}
