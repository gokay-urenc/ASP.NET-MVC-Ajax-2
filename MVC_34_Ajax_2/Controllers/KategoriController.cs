using MVC_34_Ajax_2.Models;
using MVC_34_Ajax_2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_34_Ajax_2.Controllers
{
    public class KategoriController : Controller
    {
        NORTHWND db = new NORTHWND();
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Urunler(int id) // id bizim için kategori id olarak index sayfasından geliyor.
        {
            // Seçilen kategoriye ait ürünleri buluyoruz.
            // Serilize işlemi yapıp DTO nesnesi ile geri döndüreceğimiz için ToList çalışmaz. Her bulunan veri tek tek eşitlenmelidir.
            List<UrunDTO> urunListesi = db.Products.Where(x => x.CategoryID == id).Select(x => new UrunDTO
            {
                UrunID = x.ProductID,
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                StokMiktari = x.UnitsInStock,
                KategoriID = x.CategoryID,
                TedarikciID = x.SupplierID
            }).ToList();
            return Json(urunListesi, JsonRequestBehavior.AllowGet);
        }
    }
}