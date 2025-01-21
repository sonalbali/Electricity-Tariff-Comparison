namespace Tariff_Comparison.Models
{
    public class TariffResult
    {
        public required string TariffName { get; set; }
        public decimal BaseCost { get; set; }
        public decimal AdditionalConsumptionCost { get; set; }
        public decimal AnnualCost { get; set; }
    }
}
