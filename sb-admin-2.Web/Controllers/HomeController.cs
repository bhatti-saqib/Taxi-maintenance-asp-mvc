using sb_admin_2.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.UI.WebControls;



namespace sb_admin_2.Web.Controllers
{
    public class HomeController : Controller
    {
        private DAL.TaxiContext _context;
        string userName;  // User who is logged in

        List<MTaxiDetails> plateNumbers = new List<MTaxiDetails>();
        
        private bool isPlateNumberSearched;

        private Preventive rec;   // Holds the latest returned record from Maintenance table
                                  // based on plate number



        public HomeController()
        {
            _context = new DAL.TaxiContext();            

        }


        
        public ActionResult Index()
        {
            userName = @User.Identity.Name;

            // Comment the following if statement to bypass the login
            //if (userName.Length < 1) { 
            //    return RedirectToAction("Index", "Login");
                
            //}
            //else
            //{
            //    return View();
            //}
            ///////////////////////////////////////////
            
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
            PhotoController.picPaths = null;
        }


        private Preventive GetMaintenanceTaxi()
        {
            if(Session["maintenance"] == null)
            {
                Session["maintenance"] = new Preventive();
            }

            return (Preventive)Session["maintenance"];
        }


        private void RemoveMaintenanceTaxi()
        {
            Session.Remove("maintenance");
        }


        
        //[Authorize]
        public ActionResult TaxiDetails()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TaxiDetails(TaxiDetails data, string nextBtn)
        {
            Session["TaxiPlateNumber"] = data.NT_PlateNumber;
            data.User = @User.Identity.Name;

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    NewTaxi obj = GetNewTaxi();
                    
                    obj.NT_SiteName = data.NT_SiteName;
                    obj.NT_TaxiType = data.NT_TaxiType;
                    obj.NT_PlateNumber = data.NT_PlateNumber;
                    obj.NT_MdvrNo = data.NT_MdvrNo;
                    obj.NT_Date = data.NT_Date;
                    obj.NT_Region = data.NT_Region;
                    obj.User = data.User;


                    // While adding NewTaxi record, add a record in Maintenance table
                    // as well with the typeOfMaintenance = 'N'
                    Preventive m_obj = GetMaintenanceTaxi();
                    m_obj.MT_PlateNumber = data.NT_PlateNumber;
                    m_obj.MT_Date = data.NT_Date;
                    m_obj.MT_ReplacedMDVRSerialNo = data.NT_MdvrNo;
                    m_obj.typeOfMaintenance = "N";

                    ////////////////////////////////////////////

                    return View("EquipmentDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
                
            }

                return View();
        }

        


        [HttpPost]
        public ActionResult EquipmentDetails(EquipmentDetails data, string nextBtn)
        {
            NewTaxi obj = GetNewTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    //obj.NT_ExistingMDVR = data.NT_ExistingMDVR;
                    //obj.NT_MDVRSerialNo = data.NT_MDVRSerialNo;
                    //obj.NT_Cameras = data.NT_Cameras;
                    obj.NT_CameraSerialNo = data.NT_CameraSerialNo;
                    //obj.NT_Ups = data.NT_Ups;
                    obj.NT_UpsSerialNo = data.NT_UpsSerialNo;
                    //obj.NT_Hdds = data.NT_Hdds;
                    obj.NT_HDDSerialNo = data.NT_HDDSerialNo;
                    //obj.NT_Sims = data.NT_Sims;
                    obj.NT_Emmis = data.NT_Emmis;
                    //obj.NT_CameraFovs = data.NT_CameraFovs;


                    return View("CableDetails");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }

                return View();
        }


        


        [HttpPost]
        public ActionResult CableDetails(CableDetails data, string nextBtn)
        {
            NewTaxi obj = GetNewTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    //obj.NT_PowerConnections = data.NT_PowerConnections;
                    //obj.NT_PowerCables = data.NT_PowerCables;
                    //obj.NT_CameraCables = data.NT_CameraCables;
                    //obj.NT_FourG_cables = data.NT_FourG_cables;
                    //obj.NT_Gps_cables = data.NT_Gps_cables;
                    //obj.NT_WifiCables = data.NT_WifiCables;
                    //obj.NT_Labeling = data.NT_Labeling;
                    //obj.NT_CableDressing = data.NT_CableDressing;
                    obj.NT_CameraConnector = data.NT_CameraConnector;
                    obj.NT_DiskSize = data.NT_DiskSize;


                    // Code to display checkbox on the next screen.
                    //CommonViewModel model = new CommonViewModel();
                    //model.NT = new NewTaxi();
                    //model.TC = new TaxiChannels();

                    //model.TC.Channels = this.LoadData();

                    //return View("EquipmentFunctionsDetails", model);

                    //return View("EquipmentFunctionsDetails");


                    return View("SignOffDetails", obj);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }

                
            }
            return View();
        }


        


        [HttpPost]
        public ActionResult EquipmentFunctionsDetails(EquipmentFunctionsDetails data, string nextBtn, List<SelectListItem> Channels)
        {
            NewTaxi obj = GetNewTaxi();

            if (nextBtn != null)
            {
                //if (ModelState.IsValid)
                //{
                    //obj.NT_BroncoMdvrs = data.NT_BroncoMdvrs;
                    //obj.NT_Gps = data.NT_Gps;
                    //obj.NT_Four_g = data.NT_Four_g;
                    //obj.NT_Wifi = data.NT_Wifi;
                    //obj.NT_VoltageTest = data.NT_VoltageTest;
                    //obj.NT_Channel = data.NT_Channel;

                    return View("HouseKeepingDetails");
                //}
                //else
                //{
                //    var errors = ModelState.Values.SelectMany(v => v.Errors);
                //}


            }

            return View();
        }



        

        [HttpPost]
        public ActionResult HouseKeepingDetails(HouseKeepingDetails data, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord);

            NewTaxi obj = GetNewTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    //obj.NT_TaxiHandover = data.NT_TaxiHandover;
                    //obj.NT_NoExistingAlarms = data.NT_NoExistingAlarms;
                    //obj.NT_TaxiCabin = data.NT_TaxiCabin;
                    //obj.NT_ItemsLeftInside = data.NT_ItemsLeftInside;

                    //return View("SignOffDetails", obj);
                    return View("PicDetails", obj);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
            return View();
        }
       



        [HttpPost]
        public ActionResult PicDetails(PicDetails data, string nextBtn)
        {
            NewTaxi obj = GetNewTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    return View("SignOffDetails", obj);
                    
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }

            return View();
        }



        [HttpPost]
        public ActionResult SignOffDetails(SignOffDetails data, string nextBtn)
        {
            //_context.NewTaxis.Add(newTaxiRecord6);

            NewTaxi obj = GetNewTaxi();
            Preventive m_obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.Is_NT_DepotRepApproved = data.Is_NT_DepotRepApproved;
                    obj.Is_NT_SecureTechRepApproved = data.Is_NT_SecureTechRepApproved;
                    obj.Is_NT_MccRepApproved = data.Is_NT_MccRepApproved;

                    _context.NewTaxis.Add(obj);
                    _context.Preventives.Add(m_obj);

                    try
                    {
                        _context.SaveChanges();
                        RemoveNewTaxi();
                        RemoveMaintenanceTaxi();


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



        //[Authorize]
        public ActionResult MTaxiDetails()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MTaxiDetails(MTaxiDetails data, string prevBtn, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    isPlateNumberSearched = false;

                    Preventive obj = GetMaintenanceTaxi();
                    obj.Id = data.Id;
                    
                    obj.MT_PlateNumber = data.MT_PlateNumber;
                    GetTaxi(data.MT_PlateNumber, isPlateNumberSearched);
                    
                    obj.MT_Date = data.MT_Date;
                    Regex rgx = new Regex("[^a-zA-Z0-9]");
                    Session["dateAndTime"] = rgx.Replace(data.MT_Date.ToString(), "");
                    obj.typeOfMaintenance = "P";

                    rec = GetTaxiForMaintenance(obj.MT_PlateNumber, obj.typeOfMaintenance);
                                        

                    return View("MEquipmentDetails", Session["Record"]);
                    
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }

            }

            return View();
        }



        
        [HttpPost]
        public ActionResult MEquipmentDetails(MEquipmentDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.MT_ExistingMDVR = data.MT_ExistingMDVR;
                    obj.MT_ReplacedMDVRSerialNo = data.MT_ReplacedMDVRSerialNo;
                    obj.MT_Cameras = data.MT_Cameras;
                    obj.MT_ReplacedCameraSerialNo = data.MT_ReplacedCameraSerialNo;
                    obj.MT_Ups = data.MT_Ups;
                    obj.MT_ReplacedUpsSerialNo = data.MT_ReplacedUpsSerialNo;
                    obj.MT_Hdds = data.MT_Hdds;
                    obj.MT_ReplacedHDDSerialNo = data.MT_ReplacedHDDSerialNo;
                    obj.MT_Sims = data.MT_Sims;
                    obj.MT_Emmis = data.MT_Emmis;
                    obj.MT_CameraFovs = data.MT_CameraFovs;

                    return View("MCableDetails", Session["Record"]);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }

            return View();
        }



        [HttpPost]
        public ActionResult MCableDetails(MCableDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.MT_PowerConnections = data.MT_PowerConnections;
                    obj.MT_PowerCables = data.MT_PowerCables;
                    obj.MT_CameraCables = data.MT_CameraCables;
                    obj.MT_FourG_cables = data.MT_FourG_cables;
                    obj.MT_Gps_cables = data.MT_Gps_cables;
                    obj.MT_WifiCables = data.MT_WifiCables;
                    obj.MT_Labeling = data.MT_Labeling;
                    obj.MT_CableDressing = data.MT_CableDressing;
                    
                    return View("MEquipmentFunctionsDetails", Session["Record"]);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }


            }
            return View();
        }



        [HttpPost]
        public ActionResult MEquipmentFunctionsDetails(MEquipmentFunctionsDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.MT_BroncoMdvrs = data.MT_BroncoMdvrs;
                    obj.MT_Gps = data.MT_Gps;
                    obj.MT_Four_g = data.MT_Four_g;
                    obj.MT_Wifi = data.MT_Wifi;
                    obj.MT_VoltageTest = data.MT_VoltageTest;
                    
                    return View("MHouseKeepingDetails", Session["Record"]);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }


            }

            return View();
        }



        [HttpPost]
        public ActionResult MHouseKeepingDetails(MHouseKeepingDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.MT_TaxiHandover = data.MT_TaxiHandover;
                    obj.MT_NoExistingAlarms = data.MT_NoExistingAlarms;
                    obj.MT_OverallFeedback = data.MT_OverallFeedback;
                    
                    return View("MPicDetails", obj);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
            return View();
        }


        [HttpPost]
        public ActionResult MPicDetails(MPicDetails data, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    foreach(var path in PhotoController.picPaths)
                    {
                        if(path.Contains("PlateNoPic.jpg"))
                        {
                            obj.MT_PlateNumberPic = path;
                        }
                        else if(path.Contains("MdvrNoPic.jpg"))
                        {
                            obj.MT_MdvrNoPic = path;
                        }
                        else if(path.Contains("MDVRSerialNoPic.jpg"))
                        {
                            obj.MT_MDVRSerialNoPic = path;
                        }
                        else if (path.Contains("CameraSerialNoPic.jpg"))
                        {
                            obj.MT_CameraSerialNoPic = path;
                        }
                        else if(path.Contains("UpsSerialNoPic.jpg"))
                        {
                            obj.MT_UpsSerialNoPic = path;
                        }
                        else if(path.Contains("HDDSerialNoPic.jpg"))
                        {
                            obj.MT_HDDSerialNoPic = path;
                        }
                        else if(path.Contains("PowerConnectionsPic.jpg"))
                        {
                            obj.MT_PowerConnectionsPic = path;
                        }
                        else if(path.Contains("PowerCablesPic.jpg"))
                        {
                            obj.MT_PowerCablesPic = path;
                        }    
                        else if(path.Contains("CameraCablesPic.jpg"))
                        {
                            obj.MT_CameraCablesPic = path;
                        }
                        else if(path.Contains("4GCablesPic.jpg"))
                        {
                            obj.MT_FourG_cablesPic = path;
                        }
                        else if(path.Contains("GPSCablesPic.jpg"))
                        {
                            obj.MT_Gps_cablesPic = path;
                        }
                        else if(path.Contains("WifiCablesPic.jpg"))
                        {
                            obj.MT_WifiCablesPic = path;
                        }
                        else if(path.Contains("LabelingPic.jpg"))
                        {
                            obj.MT_LabelingPic = path;
                        }
                        else if(path.Contains("CableDressingPic.jpg"))
                        {
                            obj.MT_CableDressingPic = path;
                        }

                    }


                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PlateNoPic.jpg")))
                    {
                        obj.MT_PlateNumberPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PlateNoPic.jpg");

                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "MdvrNoPic.jpg")))
                    {
                        obj.MT_MdvrNoPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "MdvrNoPic.jpg");

                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "MDVRSerialNoPic.jpg")))
                    {
                        obj.MT_MDVRSerialNoPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "MDVRSerialNoPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CameraSerialNoPic.jpg")))
                    {
                        obj.MT_CameraSerialNoPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CameraSerialNoPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "UpsSerialNoPic.jpg")))
                    {
                        obj.MT_UpsSerialNoPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "UpsSerialNoPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "HDDSerialNoPic.jpg")))
                    {
                        obj.MT_HDDSerialNoPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "HDDSerialNoPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PowerConnectionsPic.jpg")))
                    {
                        obj.MT_PowerConnectionsPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PowerConnectionsPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PowerCablesPic.jpg")))
                    {
                        obj.MT_PowerCablesPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "PowerCablesPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CameraCablesPic.jpg")))
                    {
                        obj.MT_CameraCablesPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CameraCablesPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "4GCablesPic.jpg")))
                    {
                        obj.MT_FourG_cablesPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "4GCablesPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "GPSCablesPic.jpg")))
                    {
                        obj.MT_Gps_cablesPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "GPSCablesPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "WifiCablesPic.jpg")))
                    {
                        obj.MT_WifiCablesPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "WifiCablesPic.jpg");
                    }


                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "LabelingPic.jpg")))
                    {
                        obj.MT_LabelingPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "LabelingPic.jpg");
                    }

                    if (System.IO.File.Exists(Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CableDressingPic.jpg")))
                    {
                        obj.MT_CableDressingPic = Server.MapPath("~/WebImages/" + Session["dateAndTime"] + "CableDressingPic.jpg");
                    }

                    return View("MSignOffDetails", obj);

                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }

            return View();
        }



        [HttpPost]
        public ActionResult MSignOffDetails(MSignOffDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.Is_MT_DepotRepApproved = data.Is_MT_DepotRepApproved;
                    obj.Is_MT_SecureTechRepApproved = data.Is_MT_SecureTechRepApproved;
                    obj.Is_MT_MccRepApproved = data.Is_MT_MccRepApproved;

                    //_context.NewTaxis.Add(obj);
                    _context.Preventives.Add(obj);

                    try
                    {
                        // Remove the record from Maintenance table which had been added
                        // during adding New Taxi. It's typeOfMaintenance is "N".
                        var itemToRemove = _context.Preventives.SingleOrDefault(x => x.typeOfMaintenance == "N"
                                            && x.MT_PlateNumber == obj.MT_PlateNumber);

                        if (itemToRemove != null)
                        {
                            _context.Preventives.Remove(itemToRemove);
                            //_context.SaveChanges();
                        }
                        _context.SaveChanges();
                        RemoveMaintenanceTaxi();
                        RemoveTaxiForMaintenance();
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




        //[Authorize]
        public ActionResult CTaxiDetails()
        {
            return View();
        }



        [HttpPost]
        public ActionResult CTaxiDetails(MTaxiDetails data, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    isPlateNumberSearched = false;

                    obj.Id = data.Id;

                    obj.MT_PlateNumber = data.MT_PlateNumber;
                    GetTaxi(data.MT_PlateNumber, isPlateNumberSearched);

                    obj.MT_Date = data.MT_Date;
                    Regex rgx = new Regex("[^a-zA-Z0-9]");
                    Session["dateAndTime"] = rgx.Replace(data.MT_Date.ToString(), "");
                    obj.typeOfMaintenance = "C";


                    rec = GetTaxiForMaintenance(obj.MT_PlateNumber, obj.typeOfMaintenance);

                    return View("CorrectiveMeasures", Session["Record"]);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }

            }

            return View();
        }


        public ActionResult CorrectiveMeasures()
        {
            return View();
        }



        [HttpPost]
        public ActionResult CorrectiveMeasures(CorrectiveMeasure data, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.MT_Equ_For_Corr_Measure = data.MT_Equ_For_Corr_Measure;
                    obj.MT_Corr_Measure_Taken = data.MT_Corr_Measure_Taken;
                    obj.MT_Comment_Box_For_Technicians = data.MT_Comment_Box_For_Technicians;
                    obj.MT_Old_SerialNo_If_Replaced = data.MT_Old_SerialNo_If_Replaced;

                    return View("CSignOffDetails", obj);
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
            return View();

        }



        [HttpPost]
        public ActionResult CSignOffDetails(MSignOffDetails data, string prevBtn, string nextBtn)
        {
            Preventive obj = GetMaintenanceTaxi();


            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.Is_MT_DepotRepApproved = data.Is_MT_DepotRepApproved;
                    obj.Is_MT_SecureTechRepApproved = data.Is_MT_SecureTechRepApproved;
                    obj.Is_MT_MccRepApproved = data.Is_MT_MccRepApproved;

                    //_context.NewTaxis.Add(obj);
                    _context.Preventives.Add(obj);

                    try
                    {
                        _context.SaveChanges();
                        RemoveMaintenanceTaxi();
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





        private Preventive GetTaxiForMaintenance(string pNumber, string to_maint)
        {
            // Get the records from Maintenance table based on plate number
            // and return the latest record

            var record = _context.Preventives
                .Where(a => a.MT_PlateNumber == pNumber
                && (a.typeOfMaintenance == to_maint || a.typeOfMaintenance == "N"))
                .OrderByDescending(a => a.MT_Date)
                .FirstOrDefault();

            if (Session["Record"] == null)
            {
                Session["Record"] = record;
            }


            return (Preventive)Session["Record"]; 
        }


        private void RemoveTaxiForMaintenance()
        {
            Session.Remove("Record");
        }



        public void GetTaxi(string prefix, bool isPlateNumber)
        {
            // get all the Taxi Plate Numbers and add them in the List.
            foreach (var rec in _context.NewTaxis)
            {
                plateNumbers.Add(new MTaxiDetails
                {
                    Number = rec.NT_PlateNumber.ToString(),
                });
            }

        }



        [HttpPost]
        public JsonResult Indx(string Prefix)
        {
            isPlateNumberSearched = true;
            GetTaxi(Prefix, isPlateNumberSearched);

            //Searching records from list using LINQ query
            var No = (from N in plateNumbers
                      where N.Number.StartsWith(Prefix)
                      select new { N.Number, });

            return Json(No, JsonRequestBehavior.AllowGet);

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



        //[Authorize]
        public ActionResult SearchTaxi()
        {
            return View("Tables", _context.NewTaxis.ToList());
        }


        public ActionResult Details(string id)
        {
            // NewTaxi taxi = _context.NewTaxis.Find(id);
            NewTaxi taxi = _context.NewTaxis.FirstOrDefault(n => n.NT_PlateNumber == id);
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