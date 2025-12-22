using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisAbout:BaseEntity
    {
        public AverisAbout(string littleTitle, string bigTitle, string firstText, string secondText, string buttonLink, string buttonText)
        {
          
            LittleTitle = littleTitle;
            BigTitle = bigTitle;
            FirstText = firstText;
            SecondText = secondText;
            ButtonLink = buttonLink;
            ButtonText = buttonText;
           
        }

    
        public string LittleTitle { get; set; }
        public string BigTitle { get; set; }
        public string FirstText { get; set; }
        public string SecondText { get; set; }
        public string ButtonLink { get; set; }
        public string ButtonText { get; set; }
        public ICollection<AverisLiText>? LiTexts { get; set; } = new List<AverisLiText>();

    }
}
