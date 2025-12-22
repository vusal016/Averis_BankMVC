using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisSlider:BaseEntity
    {
        public AverisSlider(string title, string content, string imageUrl, string buttonLink, string buttonText)
        {
          
            Title = title;
            Content = content;
            ImageUrl = imageUrl;
            ButtonLink = buttonLink;
            ButtonText = buttonText;
        }

    
        public string Title { get;private set; }
        public string Content { get;private set; }
        public string ImageUrl { get;private set; }
        public string ButtonLink { get;private set; }
        public string ButtonText { get;private set; }
    }
}
