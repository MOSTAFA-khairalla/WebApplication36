using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Data;

namespace WebApplication36.Controllers
{
    public class EntrantController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EntrantController( ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var entrants = _db.Entrants.ToList();
            return View( entrants);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]


        public IActionResult Create(IFormFile brants)
        {

            if (ModelState.IsValid)
            {
                if (brants?.Length > 0)
                {
                    // convert to a stream
                    var stream = brants.OpenReadStream();

                    List<Entrant> types = new List<Entrant>();


                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage(stream))
                        {
                            var worksheet = package.Workbook.Worksheets.First();
                            var rowCount = worksheet.Dimension.Rows;

                            for (var row = 2; row <= rowCount; row++)
                            {
                                try
                                {


                                    var CategoryName1 = worksheet.Cells[row, 2].Value?.ToString();

                                    var EntrantName1 = worksheet.Cells[row, 3].Value?.ToString();
                                    var EntrantDescription1 = worksheet.Cells[row, 4].Value?.ToString();

                                    var EntrantPhotoVideoURL1 = worksheet.Cells[row, 5].Value?.ToString();
                                    var EntrantFacebookPageUrl1 = worksheet.Cells[row, 6].Value?.ToString();
                                    var EntrantTwitterHandle1 = worksheet.Cells[row, 7].Value?.ToString();
                                    var EntrantInstagramHandle = worksheet.Cells[row, 8].Value?.ToString();
                                    var EntrantYouTubeChannelUrl = worksheet.Cells[row, 9].Value?.ToString();
                                    var EntrantFullAddress1 = worksheet.Cells[row, 10].Value?.ToString();
                                    var EntrantGooglePlaceId1 = (worksheet.Cells[row, 11].Value?.ToString());
                                    var EntrantPhoneNumber1 = worksheet.Cells[row, 12].Value?.ToString();
                                    var EntrantWebsiteUrl1 = worksheet.Cells[row, 13].Value?.ToString();
                                    var NumberOfWriteIns1 = int.Parse(worksheet.Cells[row, 14].Value?.ToString());
                                    var NumberOfVotes1 = int.Parse(worksheet.Cells[row, 15].Value?.ToString());
                                    var Status1 = worksheet.Cells[row, 16].Value?.ToString();


                                    


                                    var entrant = new Entrant()
                                    {
                                 
                                        CategoryName = CategoryName1,
                                        EntrantName = EntrantName1,
                                        EntrantDescription = EntrantDescription1,


                                        EntrantPhotoVideoURL = EntrantPhotoVideoURL1,
                                        EntrantFacebookPageUrl = EntrantFacebookPageUrl1,
                                        EntrantTwitterHandle = EntrantTwitterHandle1,
                                        EntrantFullAddress = EntrantFullAddress1,
                                        EntrantGooglePlaceId = EntrantGooglePlaceId1,
                                        EntrantPhoneNumber = EntrantPhoneNumber1,
                                        NumberOfVotes = NumberOfVotes1,
                                        Status = Status1


                                    };
                                    _db.Entrants.Add(entrant);

                                    _db.SaveChanges();
                                    types.Add(entrant);

                                  // return RedirectToAction("Home","Index");


                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }

                        return View("Index", types);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return View();
        }


    }
}
