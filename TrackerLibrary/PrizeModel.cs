using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PriceAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel(string PlaceName, string PlaceNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = PlaceName;

            int PlaceNumberValue = 0;
            int.TryParse(PlaceNumber, out PlaceNumberValue);
            PlaceNumber = PlaceNumberValue;

            decimal prizeaAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeaAmountValue);
            prizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
