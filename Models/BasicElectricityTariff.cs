namespace Tariff_Comparison.Models
{
    public class BasicElectricityTariff : TariffBase
    {
        public BasicElectricityTariff(string name, decimal baseCost, decimal additionalKwhCost)
        {
            Name = name;
            Type = 1;
            BaseCost = baseCost;
            AdditionalKwhCost = additionalKwhCost;
        }

        public override decimal CalculateAnnualCost(decimal consumption)
        {
            decimal monthlyBaseCost = BaseCost * 12;
            decimal consumptionCost = consumption * AdditionalKwhCost / 100;
            return monthlyBaseCost + consumptionCost;
        }
    }
} 