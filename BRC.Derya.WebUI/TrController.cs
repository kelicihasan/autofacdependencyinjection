using BRC.Derya.Business.Abstract;
using BRC.Derya.Entities;
using BRC.Derya.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BRC.Derya.WebUI.Controllers
{
    public class TrController : Controller
    {
        IIletisimService _iletisimService;
        public TrController(IIletisimService iletisimService)
        {
            _iletisimService = iletisimService;

        }
        // GET: Tr
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
           // ViewBag.Message = "Yapım Aşamasında";
            return View();
        }
        public ActionResult Contact(string ad,string email,string mesaj,int telefon)
        {
            var il = _iletisimService.GetAll();
            IletisimListViewModel model = new IletisimListViewModel{
                Iletisims = il
            };
            _iletisimService.Add(new Iletisim{
                ad_soyad = ad,
                email = email,
                mesaj = mesaj,
                telefon = telefon
            });
            return View(model);
        }
        public ActionResult Products()
        {
           // ViewBag.Message = "Yapım Aşamasında";
            return View();
        }
        public ActionResult Gallery()
        {
            //ViewBag.Message = "Yapım Aşamasında";
            return View();
        }
        public ActionResult Media()
        {
         //   ViewBag.Message = "Yapım Aşamasında";
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
    }
}