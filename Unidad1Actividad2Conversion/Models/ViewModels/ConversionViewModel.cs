namespace Unidad1Actividad2Conversion.Models.ViewModels
{
    public class ConversionViewModel
    {
        public decimal Valor { get; set; }
        public string TipoMoneda { get; set; } = null!;
        public decimal ValorConvertido { get; set; }
    }
}
