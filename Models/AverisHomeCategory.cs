using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisHomeCategory:BaseEntity
    {
        public AverisHomeCategory(string name)
        {
            Name = name;
        }

        public string Name { get;private set; }
        public List<FinanceProduct> FinanceProducts { get;private set; }
    }
}
