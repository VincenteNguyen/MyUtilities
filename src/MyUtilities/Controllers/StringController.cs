using Microsoft.AspNetCore.Mvc;
using MyUtilities.Models;
using MyUtilities.Services;
using System.Collections.Generic;

namespace MyUtilities.Controllers
{
    public class StringController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new StringExtensionViewModel();
            viewModel.StringExtensionModels = new List<StringExtensionModel>
            {
                StringServices.GetStringExtension("Between"),
                StringServices.GetStringExtension("Before"),
                StringServices.GetStringExtension("After"),
                StringServices.GetStringExtension("Contains"),
                StringServices.GetStringExtension("Substring"),
                StringServices.GetStringExtension("RemoveDiacritics"),
            };
            return View(viewModel);
        }

        public IActionResult Method(string name)
        {
            var model = StringServices.GetStringExtension(name);
            return View("~/Views/String/PartialViews/StringExtensionTestingPartial.cshtml", model);
        }

        [HttpPost]
        public IActionResult Execute(StringExtensionModel model)
        {
            model.Result = StringServices.ExecuteMethod(model);
            return View("~/Views/String/PartialViews/StringExtensionTestingPartial.cshtml", model);
        }
    }
}