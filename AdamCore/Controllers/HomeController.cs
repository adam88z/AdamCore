using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdamCore.Models;
using System.Data.SqlClient;
using System.Data;

namespace AdamCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult DatabaseConnection()
        {
            //A method that opens a connection to the SQL database then immediately closes the connection for testing.
            string connStr = "Server = A2NWPLSK14SQL-v05.shr.prod.iad2.secureserver.net; Database = MyDatabase; User Id = datadude; Password = dav9T5*6;";

            using (SqlConnection connection  = new SqlConnection(connStr))
            {
                try
                {
                    //SqlDataAdapter da = new SqlDataAdapter();
                    //DataSet ds = new DataSet();

                    var sqlquery = "SELECT * FROM Users";
                    List<string> dataResults = new List<string>();

                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlquery, connection);

                    //using (SqlDataReader dr = command.ExecuteReader())
                    //{
                    //    if (dr.HasRows)
                    //    {
                    //        // Read advances to the next row.
                    //        while (dr.Read())
                    //        {

                    //            var me = dr.GetString(dr.GetOrdinal("Firstname"));
                    //        }
                    //    }
                    //}
                    // the dataset automatically recieves and stores the data in-memory in a table like fashion.
                    // working on retrieving the data and passing it to the front end with JSON in an ajax call.
                    DataSet dataset = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataset);
                    }
                    connection.Close();
                    List<string> results = new List<string>();
                    IndexViewModel model = new IndexViewModel();
                    for (var i = 0; i <= dataset.Tables[0].Rows.Count - 1; i++)
                    {

                        results.Add(dataset.Tables[0].Rows[i].ItemArray[0] + " -- " + dataset.Tables[0].Rows[i].ItemArray[1]);

                    }
                    return Json(new { response = results});
                }
                catch
                {
                    return Json(new { response = "adam fail" });
                }
            }
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Users model)
        {
            
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult About()
        {

            return View();
        }

        [HttpGet]
        public IActionResult ASCE()
        {

            return View();
        }

        [HttpGet]
        public IActionResult RussellStandard()
        {

            return View();
        }

        [HttpGet]
        public String[] ImageUploadGet()
        {

            string[] images = { "images/construction_lights.jpg", "images/maddi_web2.jpg", "images/tuccs.jpg" };

            //string x = "images/cool-bridge.jpg";
            //string y = "images/oakland_street.jpg";

            return images;
        }

    }
}
