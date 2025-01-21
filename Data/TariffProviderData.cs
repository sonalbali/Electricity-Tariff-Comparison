using Tariff_Comparison.Models;

namespace Tariff_Comparison.Data
{
    public class TariffProviderData
    {
        public List<TariffBase> GetTariffs()
        {
            return new List<TariffBase>
            {
                new BasicElectricityTariff(
                    name: "Product A",
                    baseCost: 5,
                    additionalKwhCost: 22
                ),
                new PackagedTariff(
                    name: "Product B",
                    baseCost: 800,
                    includedKwh: 4000,
                    additionalKwhCost: 30
                )
            };
        }
    }
}
