using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class AverisHomeCards:BaseEntity
    {
        public AverisHomeCards(string title, string text, string iconUrl)
        {
            Title = title;
            Text = text;
            IconUrl = iconUrl;
        }

        public string Title { get;private set; }
        public string Text { get;private set; }
        public string IconUrl { get;private set; }
    }
}
