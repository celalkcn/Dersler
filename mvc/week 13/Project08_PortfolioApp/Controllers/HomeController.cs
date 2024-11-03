using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using Project08_PortfolioApp.model;

namespace Project08_PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var connectionString = "Server=DESKTOP-B9RLPNB; Database=PortfolioDb; Integrated Security=True;";
            var connection = new SqlConnection(connectionString);
            var queryAppSetting = "select * from AppSettings";
            var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();

            return View();
        }
        }
}
