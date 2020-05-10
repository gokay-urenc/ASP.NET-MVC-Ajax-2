using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_34_Ajax_2.Models.DTO
{
    public class UrunDTO
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<short> StokMiktari { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
// Data Transfer Object(DTO): Genellikle ajax veya script işlemlerinde ilişkili olan tabloların verileri json olarak döndürülmeye çalışıldığında bu veriler ilişkili tablolardan çekilemez ve bir serilization hatası meydana gelir. Bu hatayı önlemek için asıl verinin çekileceği tablonun ilişkilerinden arındırılmış halinin bir kopyasını çıkarma mantığıdır.