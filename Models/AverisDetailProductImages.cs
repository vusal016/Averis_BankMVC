using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisDetailProductImages:BaseEntity
    {
        public AverisDetailProductImages(string imageUrl, string financeProductId)
        {
            ImageUrl = imageUrl;
            FinanceProductId = financeProductId;
        }

        public string  ImageUrl { get;private set; }
        public string FinanceProductId { get;private set; }
        public FinanceProduct FinanceProduct { get;private set; }

    }
}
