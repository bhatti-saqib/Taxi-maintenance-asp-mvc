using sb_admin_2.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_admin_2.Web.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationDbContext _context;
        private DAL.TaxiContext _context;


        public HomeController()
        {
            _context = new DAL.TaxiContext();
        }


        public ActionResult Index()
        {
            return View();
        }


        private NewTaxi GetNewTaxi()
        {
            if (Session["newTaxi"] == null)
            {
                Session["newTaxi"] = new NewTaxi();
            }

            return (NewTaxi)Session["newTaxi"];
        }


        private void RemoveNewTaxi()
        {
            Session.Remove("newTaxi");
        }


        public ActionResult TaxiDetails()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TaxiDetails(TaxiDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    NewTaxi obj = GetNewTaxi();
                    obj.Id = data.Id;
                    obj.NT_SiteName = data.NT_SiteName;
                    obj.NT_TaxiType = data.NT_TaxiType;
                    obj.NT_PlateNumber = data.NT_PlateNumber;
                    obj.NT_MdvrNo = data.NT_MdvrNo;
                    obj.NT_Date = data.NT_Date;
                    obj.NT_Region = data.NT_Region;

                    return View("EquipmentDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
                
            }

                return View();
        }

        //public ActionResult AddNewTaxi2()
        //{
        //    return View("AddNewTaxi2");
        //}


        [HttpPost]
        public ActionResult EquipmentDetails(EquipmentDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            NewTaxi obj = GetNewTaxi();

            if (prevBtn != null)
            {
                TaxiDetails td = new TaxiDetails();

                td.Id = obj.Id;
                td.NT_SiteName = obj.NT_SiteName;
                td.NT_TaxiType = obj.NT_TaxiType;
                td.NT_PlateNumber = obj.NT_PlateNumber;
                td.NT_MdvrNo = obj.NT_MdvrNo;
                td.NT_Date = obj.NT_Date;
                td.NT_Region = obj.NT_Region;

                return View("TaxiDetails", td);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.NT_ExistingMDVR = data.NT_ExistingMDVR;
                    obj.NT_MDVRSerialNo = data.NT_MDVRSerialNo;
                    obj.NT_Cameras = data.NT_Cameras;
                    obj.NT_CameraSerialNo = data.NT_CameraSerialNo;
                    obj.NT_Ups = data.NT_Ups;
                    obj.NT_UpsSerialNo = data.NT_UpsSerialNo;
                    obj.NT_Hdds = data.NT_Hdds;
                    obj.NT_HDDSerialNo = data.NT_HDDSerialNo;
                    obj.NT_Sims = data.NT_Sims;
                    obj.NT_Emmis = data.NT_Emmis;
                    obj.NT_CameraFovs = data.NT_CameraFovs;

                    return View("CableDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }

                return View();
        }


        //public ActionResult AddNewTaxi3()
        //{
        //    return View("AddNewTaxi3");
        //}


        [HttpPost]
        public ActionResult CableDetails(CableDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            NewTaxi obj = GetNewTaxi();

            if (prevBtn != null)
            {
                EquipmentDetails ed = new EquipmentDetails();

                ed.NT_ExistingMDVR = obj.NT_ExistingMDVR;
                ed.NT_MDVRSerialNo = obj.NT_MDVRSerialNo;
                ed.NT_Cameras = obj.NT_Cameras;
                ed.NT_CameraSerialNo = obj.NT_CameraSerialNo;
                ed.NT_Ups = obj.NT_Ups;
                ed.NT_UpsSerialNo = obj.NT_UpsSerialNo;
                ed.NT_Hdds = obj.NT_Hdds;
                ed.NT_HDDSerialNo = obj.NT_HDDSerialNo;
                ed.NT_Sims = obj.NT_Sims;
                ed.NT_Emmis = obj.NT_Emmis;
                ed.NT_CameraFovs = obj.NT_CameraFovs;

                return View("EquipmentDetails", ed);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.NT_PowerConnections = data.NT_PowerConnections;
                    obj.NT_PowerCables = data.NT_PowerCables;
                    obj.NT_CameraCables = data.NT_CameraCables;
                    obj.NT_FourG_cables = data.NT_FourG_cables;
                    obj.NT_Gps_cables = data.NT_Gps_cables;
                    obj.NT_WifiCables = data.NT_WifiCables;
                    obj.NT_Labeling = data.NT_Labeling;
                    obj.NT_CableDressing = data.NT_CableDressing;
                    obj.NT_CameraConnector = data.NT_CameraConnector;
                    obj.NT_DiskSize = data.NT_DiskSize;

                    return View("EquipmentFunctionsDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }

                
            }
            return View();
        }


        //public ActionResult AddNewTaxi4()
        //{
        //    return View("AddNewTaxi4");
        //}


        [HttpPost]
        public ActionResult EquipmentFunctionsDetails(EquipmentFunctionsDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            NewTaxi obj = GetNewTaxi();

            if (prevBtn != null)
            {
                CableDetails cd = new CableDetails();

                cd.NT_PowerConnections = obj.NT_PowerConnections;
                cd.NT_PowerCables = obj.NT_PowerCables;
                cd.NT_CameraCables = obj.NT_CameraCables;
                cd.NT_FourG_cables = obj.NT_FourG_cables;
                cd.NT_Gps_cables = obj.NT_Gps_cables;
                cd.NT_WifiCables = obj.NT_WifiCables;
                cd.NT_Labeling = obj.NT_Labeling;
                cd.NT_CableDressing = obj.NT_CableDressing;
                cd.NT_CameraConnector = obj.NT_CameraConnector;
                cd.NT_DiskSize = obj.NT_DiskSize;

                return View("CableDetails", cd);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.NT_BroncoMdvrs = data.NT_BroncoMdvrs;
                    obj.NT_Gps = data.NT_Gps;
                    obj.NT_Four_g = data.NT_Four_g;
                    obj.NT_Wifi = data.NT_Wifi;
                    obj.NT_VoltageTest = data.NT_VoltageTest;
                    obj.NT_Channel = data.NT_Channel;

                    return View("HouseKeepingDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }


            }

            return View();
        }



        //public ActionResult AddNewTaxi5()
        //{
        //    return View("AddNewTaxi5");
        //}



        [HttpPost]
        public ActionResult HouseKeepingDetails(HouseKeepingDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            NewTaxi obj = GetNewTaxi();

            if (prevBtn != null)
            {
                EquipmentFunctionsDetails ed = new EquipmentFunctionsDetails();

                ed.NT_BroncoMdvrs = obj.NT_BroncoMdvrs;
                ed.NT_Gps = obj.NT_Gps;
                ed.NT_Four_g = obj.NT_Four_g;
                ed.NT_Wifi = obj.NT_Wifi;
                ed.NT_VoltageTest = obj.NT_VoltageTest;
                ed.NT_Channel = obj.NT_Channel;

                return View("EquipmentFunctionsDetails", ed);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.NT_TaxiHandover = data.NT_TaxiHandover;
                    obj.NT_NoExistingAlarms = data.NT_NoExistingAlarms;
                    obj.NT_TaxiCabin = data.NT_TaxiCabin;
                    obj.NT_ItemsLeftInside = data.NT_ItemsLeftInside;

                    return View("SignOffDetails",obj);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
            return View();
        }
       


        //public ActionResult SignOffDetails()
        //{
        //    return View("AddNewTaxi6");
        //}


        [HttpPost]
        public ActionResult SignOffDetails(SignOffDetails data, string prevBtn, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord6);

            NewTaxi obj = GetNewTaxi();

            if (prevBtn != null)
            {
                HouseKeepingDetails hd = new HouseKeepingDetails();

                hd.NT_TaxiHandover = obj.NT_TaxiHandover;
                hd.NT_NoExistingAlarms = obj.NT_NoExistingAlarms;
                hd.NT_TaxiCabin = obj.NT_TaxiCabin;
                hd.NT_ItemsLeftInside = obj.NT_ItemsLeftInside;

                return View("HouseKeepingDetails", hd);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.Is_NT_DepotRepApproved = data.Is_NT_DepotRepApproved;
                    obj.Is_NT_SecureTechRepApproved = data.Is_NT_SecureTechRepApproved;
                    obj.Is_NT_MccRepApproved = data.Is_NT_MccRepApproved;

                    _context.NewTaxis.Add(obj);

                    try
                    {
                        _context.SaveChanges();
                        RemoveNewTaxi();
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }


                    return View("Thankyou");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
                     
            return View("Thankyou");
        }

        public ActionResult SiteTaxiDetails()
        {
            return View();
        }

        
        public ActionResult Equipment()
        {
            return View("Equipment");
        }

        public ActionResult Cables()
        {
            return View("Cables");
        }

        public ActionResult EquipmentFunctions()
        {
            return View("EquipmentFunctions");
        }

        public ActionResult HouseKeeping()
        {
            return View("HouseKeeping");
        }

        public ActionResult SignOff()
        {
            return View("SignOff");
        }

        public ActionResult Thankyou()
        {
            return View("Thankyou");
        }

        public ActionResult CSiteTaxiDetails()
        {
            return View();
        }

        public ActionResult CorrectiveMeasures()
        {
            return View();
        }


        public ActionResult FlotCharts()
        {
            return View("FlotCharts");
        }

        public ActionResult MorrisCharts()
        {
            return View("MorrisCharts");
        }


        public ActionResult LoadTaxiData()
        {
            try
            {
                // Getting all Taxi's data    
                //var taxiData = (from tempTaxi in _context.NewTaxis
                //                select tempTaxi);


                return View(_context.NewTaxis.ToList());
            }
            catch (Exception)
            {
                throw;
            }
            
            //return View();
        }


        public ActionResult Tables()
        {
            return View("Tables", _context.NewTaxis.ToList());
        }


        public ActionResult Details(int id)
        {
            NewTaxi taxi = _context.NewTaxis.Find(id);
            return View(taxi);
        }


        public ActionResult Forms()
        {
            return View("Forms");
        }

        public ActionResult Panels()
        {
            return View("Panels");
        }

        public ActionResult Buttons()
        {
            return View("Buttons");
        }

        public ActionResult Notifications()
        {
            return View("Notifications");
        }

        public ActionResult Typography()
        {
            return View("Typography");
        }

        public ActionResult Icons()
        {
            return View("Icons");
        }

        public ActionResult Grid()
        {
            return View("Grid");
        }

        public ActionResult Blank()
        {
            return View("Blank");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

    }
}