using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHaiSan.Models;
using WebBanHaiSan.Models.EF;

namespace WebBanHaiSan.Areas.Admin.Controllers
{
    public class SettingSystemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/SettingSystem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Setting()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddSetting(SettingSystemViewModel req)
        {
            var checkTitle = db.SystemSettings.FirstOrDefault(x => x.SettingKey.Contains("SettingTitle"));
            if (checkTitle == null || string.IsNullOrEmpty(checkTitle.SettingValue))
            {
                SystemSetting set = new SystemSetting();
                set.SettingKey = "SettingTitle";
                set.SettingKey = req.SettingTitle;
                db.SystemSettings.Add(set);
                db.SaveChanges();
            }
            else
            {
                checkTitle.SettingValue = req.SettingTitle;
                db.Entry(checkTitle).State = System.Data.Entity.EntityState.Modified;
            }
            //logo
            var checkLogo = db.SystemSettings.FirstOrDefault(x => x.SettingKey.Contains("SettingLogo"));
            if (checkLogo == null || string.IsNullOrEmpty(checkLogo.SettingValue))
            {
                SystemSetting set = new SystemSetting();
                set.SettingKey = "SettingLogo";
                set.SettingKey = req.SettingLogo;
                db.SystemSettings.Add(set);
                db.SaveChanges();
            }
            else
            {
                checkLogo.SettingValue = req.SettingTitle;
                db.Entry(checkLogo).State = System.Data.Entity.EntityState.Modified;
            }

            
            return View("Partial_Setting");
        }
    }
}