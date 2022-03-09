using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_NgVanSi.Models;

namespace Lab2_NgVanSi.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        public static List<Rubik> listRubik;
        public RubikController()
        {
            listRubik = new List<Rubik>();
            listRubik.Add(new Rubik()
            {
                Id = 1,
                Ten = "Rubik 1",
                Loai = "3x3",
                MoTa = "Best Saler",
                Hang = "Rubik VN",
                Gia = 30000,
                Hinh = "Content/images/rubik1.jpg",
                SoLgTon = 20
            });
            listRubik.Add(new Rubik()
            {
                Id = 2,
                Ten = "Rubik 2",
                Loai = "4x4",
                MoTa = "Best Saler",
                Hang = "Rubik UK",
                Gia = 60000,
                Hinh = "Content/images/rubik2.jpg",
                SoLgTon = 10
            });
            listRubik.Add(new Rubik()
            {
                Id = 3,
                Ten = "Rubik 3",
                Loai = "8x8",
                MoTa = "Best Saler",
                Hang = "Rubik US",
                Gia = 90000,
                Hinh = "Content/images/rubik3.jpg",
                SoLgTon = 15
            });
        }
        public ActionResult Index()
        {
            ViewBag.TitlePageName = "Rubik view page";
            return View(listRubik);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.Id == id);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }

        [HttpGet]
        public ActionResult Edit(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.Id == ID);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rubik rubik)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editbook = listRubik.Find(b => b.Id == rubik.Id);
                    editbook.Ten = rubik.Ten;
                    editbook.Loai = rubik.Loai;
                    editbook.MoTa = rubik.MoTa;
                    editbook.Hang = rubik.Hang;
                    editbook.Gia = rubik.Gia;
                    editbook.Hinh = rubik.Hinh;
                    editbook.SoLgTon = rubik.SoLgTon;
                    return View("Index", listRubik);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valide!");
                return View(rubik);
            }
        }

        public ActionResult Delete(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.Id == ID);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Rubik rubik)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var delrubik = listRubik.Where(b => b.Id == rubik.Id).FirstOrDefault();
                    listRubik.Remove(delrubik);
                    
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            return View("Index", listRubik);
        }
    }
}