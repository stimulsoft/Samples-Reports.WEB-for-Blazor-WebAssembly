using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Using_SQL_Data_Sources.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(string name)
        {
            /*var tableName = "Products";
            var connectionString = @"Data Source=192.168.1.1;Initial Catalog=northwind;Integrated Security=False;User ID=root;Password=******;TrustServerCertificate=Yes";
            var connection = new SqlConnection(connectionString);
            var dataAdapter = new SqlDataAdapter($"select * from {tableName}", connection);
            var dataTable = new DataTable("Products");
            dataAdapter.Fill(dataTable);

            var jsonTable = JsonConvert.SerializeObject(dataTable);
            var jsonData = $"{{ {tableName}: {jsonTable} }}";
            return Content(jsonData);*/

            var dataPath = $"Data\\{name}.json";
            var jsonData = System.IO.File.ReadAllText(dataPath);
            return Content(jsonData);
        }
    }
}