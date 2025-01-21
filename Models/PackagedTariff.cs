namespace Tariff_Comparison.Models
{
    public class PackagedTariff : TariffBase
    {
        public decimal IncludedKwh { get; set; }

        public PackagedTariff(string name, decimal baseCost, decimal includedKwh, decimal additionalKwhCost)
        {
            Name = name;
            Type = 2;
            BaseCost = baseCost;
            IncludedKwh = includedKwh;
            AdditionalKwhCost = additionalKwhCost;
        }

        public override decimal CalculateAnnualCost(decimal consumption)
        {
            if (consumption <= IncludedKwh)
            {
                return BaseCost;
            }

            decimal additionalConsumption = consumption - IncludedKwh;
            decimal additionalCost = additionalConsumption * AdditionalKwhCost / 100;
            return BaseCost + additionalCost;
        }
    }
} 