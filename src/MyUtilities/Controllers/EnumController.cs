using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyUtilities.Models;
using System.Text;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyUtilities.Controllers
{
    public class EnumController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Methods = new List<BaseModel>
            {
                new BaseModel
                {
                    Name = "Enum to SelectList",
                    SourceCode = EnumToSelectList
                },
                new BaseModel
                {
                    Name = "Get Enum Description",
                    SourceCode = GetEnumDescription
                },
            };
            return View();
        }

        private static string EnumToSelectList
        {
            get
            {
                return @"        public static List<SelectListItem> EnumToSelectList<T>()
        {
            return Enum.GetValues(typeof (T)).Cast<T>().Select(v => new SelectListItem
            {
                Text = GetEnumDescription(v),
                Value = Convert.ToInt32(v).ToString()
            }).ToList();
        }";
            }
        }

        private static string GetEnumDescription
        {
            get
            {
                return @"        public static string GetEnumDescription<TEnum>(TEnum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }";
            }
        }

        //Enum generator
        public IActionResult Generator()
        {
            var model = new EnumGeneratorViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Generator(EnumGeneratorViewModel model)
        {
            var enumDefineBuilder = new StringBuilder();
            enumDefineBuilder.AppendFormat(@"    public enum {0}", model.Name);
            enumDefineBuilder.Append(@"
    { ");
            var index = 0;
            for(int i = 0; i < model.dynamicName.Count(); i++)
            {
                var name = model.dynamicName[i];
                if (string.IsNullOrWhiteSpace(name))
                    continue;
                var value = model.dynamicValue[i];
                enumDefineBuilder.AppendFormat(@"
        {0} = {1},", name, value);
            }
            enumDefineBuilder.Append(@"
    }");
            model.SourceCode = enumDefineBuilder.ToString();
            return View(model);
        }
    }
}
