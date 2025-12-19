namespace Averis.WEBMVC.Models
{
    public class AverisAbout
    {
        public string Id { get; set; }
        public string LittleTitle { get; set; }
        public string BigTitle { get; set; }
        public string FirstText { get; set; }
        public string SecondText { get; set; }
        public ICollection<string> Litexts { get; set; }
        public string ButtonLink { get; set; }
        public string ButtonText { get; set; }
    }
}
