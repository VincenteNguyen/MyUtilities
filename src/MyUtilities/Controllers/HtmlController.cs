using Microsoft.AspNetCore.Mvc;
using MyUtilities.Models;
using MyUtilities.Services;

namespace MyUtilities.Controllers
{
    public class HtmlController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HttpBuilderModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult ParseHtmlForm(HttpBuilderModel model)
        {
            string result2 = HtmlService.ParsingHtmlForm(model);
            ViewBag.Result = result2;
            return View();
        }

        public IActionResult ConvertHtmlToTree()
        {
            var model = new HtmlToTreeModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult ConvertHtmlToTree(HtmlToTreeModel model)
        {
            model.Result = HtmlService.ParsingXmlToTree(model.SourceValue);
            return View("~/Views/Html/TreeResultDisplay.cshtml", model);
        }

        public IActionResult XmlExample()
        {
            var model = new HtmlToTreeModel();
            model.Result = HtmlService.ParsingXmlToTree(model.SourceValue);
            return View("~/Views/Html/TreeResultDisplay.cshtml", model);
        }
    }
}
