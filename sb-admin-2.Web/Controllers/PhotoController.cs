using System;
using System.Web.Mvc;
using System.IO;

namespace sb_admin_2.Web.Controllers
{
    public class PhotoController : Controller
    {
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
        public ActionResult Changephoto()
        {
            if (Convert.ToString(Session["val"]) != string.Empty)
            {
                ViewBag.pic = "http://localhost:29128/WebImages/" + Session["val"].ToString();
                return View("/Views/Home/TaxiDetails.cshtml");
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
            string path = "http://localhost:29128/WebImages/" + Session["val"].ToString();
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

                var path = Server.MapPath("~/WebImages/" + date + "test.jpg");

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