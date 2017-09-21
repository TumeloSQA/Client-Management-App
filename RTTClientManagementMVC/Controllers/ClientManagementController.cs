using RTTClientManagementMVC.ClientServiceReference;
using RTTClientManagementMVC.Models;
using RTTClientManagementMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(ClientDetails clientModel, AddressDetails clientAddress)
        {

            ClientDetails clientDetails = new ClientDetails();
            ClientViewModel clientViewModel = new ClientViewModel();

            clientViewModel.name = clientModel.Name;
            clientViewModel.gender = clientModel.Gender;
            clientViewModel.cellNumber = clientModel.CellNumber;
            clientViewModel.workTel = clientModel.WorkTel;

            clientViewModel.resAddress = clientAddress.ResAddress;
            clientViewModel.workAddress = clientAddress.WorkAddress;
            clientViewModel.posAddress = clientAddress.PosAddress;

            serviceRef.InsertClientDetails(clientModel, clientAddress);
            return RedirectToAction("Index", "ClientManagement");

        }
    }
}