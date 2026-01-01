using Averis.WEBMVC.Core;

namespace Averis.WEBMVC.Models
{
    public class FinanceProduct:BaseEntity
    {
        public FinanceProduct(string name, string description, string link,string imageUrl, DateTime cratedAt, string client, string projectUrl, string detailTitle, string detailText,string categoryId)
        {
            Name = name;
            Description = description;      
            Link = link;
            ImageUrl = imageUrl;
            CratedAt = cratedAt;
            Client = client;
            ProjectUrl = projectUrl;
            DetailTitle = detailTitle;
            DetailText = detailText;
            CategoryId = categoryId;
        }

        public string Name { get;private set; }
        public string Description { get;private set; }
        public string Link { get;private set; }
        public string ImageUrl { get;private set; }
        public DateTime CratedAt { get;private set; }=
        public string Client { get;private set; }
        public string ProjectUrl { get;private set; }
        public string DetailTitle { get;private set; }
        public string DetailText { get;private set; }
        public string CategoryId { get; set; }
        public AverisHomeCategory Category { get; set; }
        public ICollection<AverisDetailProductImages> ProductImages { get;private set; } = new List<AverisDetailProductImages>();
    }
}
