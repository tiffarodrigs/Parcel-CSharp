using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    {
    List<Parcel> allParcels = Parcel.GetAll();
    return View(allParcels);
    }
  }
}