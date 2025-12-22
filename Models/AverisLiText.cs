using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisLiText:BaseEntity
    {
        public AverisLiText(string litext, string? averisAboutId)
        {
            Litext = litext;
            AverisAboutId = averisAboutId;
           
        }

     
        public string Litext { get;private set; }
        public string? AverisAboutId { get;private set; }
        public AverisAbout? AverisAbout { get;private set; }
    }
}
