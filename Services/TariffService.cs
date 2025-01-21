using Tariff_Comparison.Data;
using Tariff_Comparison.Models;

namespace Tariff_Comparison.Services
{
    public class TariffService
    {
        private readonly List<TariffBase> _tariffs;

        public TariffService(TariffProviderData tariffProvider)
        {
            _tariffs = tariffProvider.GetTariffs();
        }

        public IEnumerable<TariffResult> CalculateAnnualCost(decimal consumption)
        {
            var results = _tariffs.Select(tariff => new TariffResult
            {
                TariffName = tariff.Name,
                BaseCost = tariff.BaseCost,
                AnnualCost = tariff.CalculateAnnualCost(consumption),
                AdditionalConsumptionCost = CalculateAdditionalCost(tariff, consumption)
            });

            return results.OrderBy(r => r.AnnualCost);
        }

        private decimal CalculateAdditionalCost(TariffBase tariff, decimal consumption)
        {
            if (tariff is BasicElectricityTariff)
            {
                return consumption * tariff.AdditionalKwhCost / 100;
            }
            else if (tariff is PackagedTariff packagedTariff)
            {
                if (consumption <= packagedTariff.IncludedKwh)
                    return 0;
                
                return (consumption - packagedTariff.IncludedKwh) * tariff.AdditionalKwhCost / 100;
            }

            return 0;
        }
    }
}

