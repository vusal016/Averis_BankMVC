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

    
        public string LittleTitle { get;private set; }
        public string BigTitle { get;private set; }
        public string FirstText { get;private set; }
        public string SecondText { get;private set; }
        public string ButtonLink { get;private set; }
        public string ButtonText { get;private set; }
        public ICollection<AverisLiText>? LiTexts { get;private set; } = new List<AverisLiText>();

    }
}
