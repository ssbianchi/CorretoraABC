using CorretoraABC.Aplicacao;
using CorretoraABC.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CorretoraABC.MVC.Controllers
{
    public class PrecoAtivoController : Controller
    {
        private readonly IPrecoAtivoApp _precoAtivoApp;
        public PrecoAtivoController(IPrecoAtivoApp precoAtivoApp)
        {
            _precoAtivoApp = precoAtivoApp;
        }
        public async Task<ActionResult> Index()
        {
            var result = await _precoAtivoApp.ListarPrecoHistorico();
            var dataPoints = new List<DataPoint>();

            foreach (var item in result)
            {
                var date = DateTime.Parse(item.Date).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                dataPoints.Add(new DataPoint(date, item.ClosePrice));
            }
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View(result);
        }
	}
}
