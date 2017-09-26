using RTTClientManagementMVC.ClientServiceReference;
using RTTClientManagementMVC.Models;
using RTTClientManagementMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RTTClientManagementMVC.Controllers
{
    public class ClientManagementController : Controller
    {
        // GET: ClientManagement
        ClientServiceReference.ClientDataServiceClient serviceRef = new ClientServiceReference.ClientDataServiceClient();
        public ActionResult Index()
        {
            DataSet ds = serviceRef.GetClientDetails();
            ViewBag.ClientList = ds.Tables[0];
            serviceRef.Close();
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(ClientDetails clientModel, AddressDetails clientAddress)
        {

            serviceRef.InsertClientDetails(clientModel, clientAddress);
            return RedirectToAction("Index", "ClientManagement");
        }

        public FileResult SaveToFile()
        {
            DataSet dataSet = serviceRef.GetClientDetails();
            var lstData = dataSet.Tables[0];
            var sb = new StringBuilder();
            foreach (System.Data.DataRow data in lstData.Rows)
            {
                
                sb.AppendLine(data["clientId"].ToString() + "," + data["name"].ToString() + ","+ data["gender"].ToString()+ ", " + data["resAddress"].ToString() + ", " + data["workAddress"].ToString() + ", " + data["posAddress"].ToString());
            }
            return File(new UTF8Encoding().GetBytes(sb.ToString()), "application/txt", "clientData_" + DateTime.Now +".txt");
        }
    }

}