using System;
using System.Web.Mvc;
using System.IO;
using System.Collections.Generic;

namespace sb_admin_2.Web.Controllers
{
    public class PhotoController : Controller
    {
        public static string btnName;
        
        // List to store pic paths
        public static List<string> picPaths = new List<string>();

        // GET: Photo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        // In this method you can write code for saving the image name in the database too.
        [HttpPost]
        public ActionResult Index(string ImageName)
        {
            ViewBag.pic = "http://localhost:29128/WebImages/" + Session["val"].ToString();

            return View();
        }


        
        // Code to display index View in a new window.
        [HttpGet]
        public ActionResult Changephoto(string linktext)
        {
            if(linktext != null)
            {
                btnName = linktext +".jpg";
                
            }
            if (Convert.ToString(Session["val"]) != string.Empty)
            {
                //ViewBag.pic = "http://localhost:29128/WebImages/" + Session["val"].ToString();
                ViewBag.pic = "http://localhost:29128/WebImages/" + btnName.ToString();
                Session.Remove("val");

                
                return View("/Views/Home/PicDetails.cshtml");
                
            }
            else
            {
                ViewBag.pic = "../../WebImages/person.jpg";

            }

            //return View();
            return View("~/Views/Photo/Changephoto.cshtml");
        }



        // This method returns the path of the image that we captured.
        public JsonResult Rebind()
        {
            //string path = "http://localhost:29128/WebImages/" + Session["val"].ToString();
            //string path = "http://localhost:29128/WebImages/" + Session["dateAndTime"] + btnName.ToString();
            string path = "http://localhost:29128/WebImages/" + Session["TaxiPlateNumber"] + btnName.ToString();
            picPaths.Add(path);
            return Json(path, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Capture()
        {
            var stream = Request.InputStream;
            string dump;

            using (var reader = new StreamReader(stream))
            {
                dump = reader.ReadToEnd();

                DateTime nm = DateTime.Now;

                string date = nm.ToString("yyyymmddMMss");

                //var path = Server.MapPath("~/WebImages/" + date + "test.jpg");
                //Session["dateAndTime"] = DateTime.Now.ToFileTime().ToString();
                //var path = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + btnName);
                var path = Server.MapPath("~/WebImages/" + Session["TaxiPlateNumber"] + btnName);

                System.IO.File.WriteAllBytes(path, String_To_Bytes2(dump));

                ViewData["path"] = date + "test.jpg";

                Session["val"] = date + "test.jpg";
            }

            return View("Index");

        }


        private byte[] String_To_Bytes2(string strInput)
        {
            int numBytes = (strInput.Length) / 2;
            byte[] bytes = new byte[numBytes];

            for (int x = 0; x < numBytes; ++x)
            {
                bytes[x] = Convert.ToByte(strInput.Substring(x * 2, 2), 16);
            }

            return bytes;
        }
    }
    
}