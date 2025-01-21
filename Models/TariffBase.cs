namespace Tariff_Comparison.Models
{
    public abstract class TariffBase
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public decimal BaseCost { get; set; }
        public decimal AdditionalKwhCost { get; set; }

        public abstract decimal CalculateAnnualCost(decimal consumption);
    }
} 