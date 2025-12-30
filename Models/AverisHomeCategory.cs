using Averis.WEBMVC.Core;
using System.Text.RegularExpressions;

namespace Averis.WEBMVC.Models
{
    public class AverisHomeCategory : BaseEntity
    {
        public AverisHomeCategory(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public List<FinanceProduct> FinanceProducts { get; private set; }

  
    }
}
