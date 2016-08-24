using Microsoft.AspNetCore.Mvc;
using MyUtilities.Extensions;
using MyUtilities.Models;
using MyUtilities.Services;
using System;
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
                GetStringExtension("Between"),
                GetStringExtension("Before"),
                GetStringExtension("After"),
                GetStringExtension("Contains"),
                GetStringExtension("Substring"),
            };
            return View(viewModel);
        }
        private StringExtensionModel GetStringExtension(string methodName)
        {
            var model = new StringExtensionModel { Name = methodName };
            switch (methodName)
            {
                case "Between":
                    model.SourceCode = StringServices.Between;
                    break;
                case "Before":
                    model.SourceCode = StringServices.Before;
                    break;
                case "After":
                    model.SourceCode = StringServices.After;
                    break;
                case "Contains":
                    model.SourceCode = StringServices.Contains;
                    break;
                case "Substring":
                    model.SourceCode = StringServices.Substring;
                    break;
                default:
                    return null;
            }
            return model;
        }

        public IActionResult Method(string name)
        {
            var model = GetStringExtension(name);
            return View("~/Views/String/PartialViews/StringExtensionTestingPartial.cshtml", model);
        }

        [HttpPost]
        public IActionResult Execute(StringExtensionModel model)
        {
            ExecuteMethod(model);
            return View("~/Views/String/PartialViews/StringExtensionTestingPartial.cshtml", model);
        }

        private void ExecuteMethod(StringExtensionModel model)
        {
            switch (model.Name)
            {
                case "Between":
                    model.Result = model.SourceValue.Between(model.FromA, model.ToB);
                    break;
                case "Before":
                    model.Result = model.SourceValue.Before(model.TextToCheck);
                    break;
                case "After":
                    model.Result = model.SourceValue.After(model.TextToCheck);
                    break;
                case "Contains":
                    model.Result = model.SourceValue.Contains(model.TextToCheck, StringComparison.OrdinalIgnoreCase) ? "Yes" : "No";
                    break;
                case "Substring":
                    model.Result = model.SourceValue.Substring(model.FromA, model.ToB);
                    break;
                default:
                    return;
            }
        }
    }
}