using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad2Conversion.Models.ViewModels;

namespace Unidad1Actividad2Conversion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ConversionViewModel vm)
        {

            if (vm.TipoMoneda == "MXN" )
            {
                vm.ValorConvertido = vm.Valor * 18;
            }
            else
            {
                vm.ValorConvertido = vm.Valor / 18;
            }

            return View(vm);
        }
    }
}
