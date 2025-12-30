using Averis.WEBMVC.Models;

namespace Averis.WEBMVC.ViewModels
{
    public class HomeVm
    {
        public List<AverisHomeCards> Cards { get; set; }
        public List<AverisSlider> Slider { get; set; }
        public AverisAbout About { get; set; }
        public List<AverisHomeCategory> HomeCategory { get; set; }
        public List<FinanceProduct> FinanceProducts { get; set; }

          public static string ToSafeClassName(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                return string.Empty;

            return categoryName.ToLower()
                .Replace("&", "ve")
                .Replace(" ", "-")
                .Replace("ə", "e")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ç", "c")
                .Replace("ş", "s")
                .Replace("ğ", "g");
        }
    }
}
