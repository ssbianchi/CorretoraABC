using CorretoraABC.Aplicacao;
using CorretoraABC.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CorretoraABC.MVC.Controllers
{
    public class PrecoAtivoController : Controller
    {
        private readonly IPrecoAtivoApp _precoAtivoApp;
        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        public PrecoAtivoController(IPrecoAtivoApp precoAtivoApp)
        {
            _precoAtivoApp = precoAtivoApp;
        }
        //public async Task<ActionResult> Index()
        //{
        //    var result = await _precoAtivoApp.ListarPrecoHistorico();
        //    var dataPoints = new List<DataPoint>();

        //    foreach (var item in result)
        //    {
        //        var date = DateTime.Parse(item.Date).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        //        dataPoints.Add(new DataPoint(date, item.ClosePrice));
        //    }
        //    ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

        //    return View(result);
        //}
        public async Task<ActionResult> Index()
        {
            try
            {
                var result = await _precoAtivoApp.ListarPrecoHistorico();
                var dataPoints = new List<DataPoint>();

                foreach (var item in result)
                {
                    var date = DateTime.Parse(item.Date).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                    dataPoints.Add(new DataPoint(date, item.ClosePrice));
                }
                //ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
                ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints, _jsonSetting);

                return View(result);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
        //public async Task<ContentResult> JSON()
        //{
        //          var result = await _precoAtivoApp.ListarPrecoHistorico();
        //          List<DataPoint> dataPoints = new List<DataPoint>();
        //          foreach (var item in result)
        //          {
        //              var date = DateTime.Parse(item.Date).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        //              dataPoints.Add(new DataPoint(date, item.ClosePrice));
        //          }

        //          JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        //	return Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");
        //}
        public async Task<ContentResult> JSON()
        {
            var result = await _precoAtivoApp.ListarPrecoHistorico();
            List<DataPointPrecoAtivo> dataPoints = new List<DataPointPrecoAtivo>();
            foreach (var item in result)
            {
                var date = DateTime.Parse(item.Date).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                dataPoints.Add(new DataPointPrecoAtivo(date, item.OpenPrice, item.HighPrice, item.LowPrice, item.ClosePrice, item.AdjClosePrice, item.Volume));
            }

            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            return Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");
        }
    }
}
