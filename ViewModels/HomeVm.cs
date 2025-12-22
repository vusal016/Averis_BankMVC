using Averis.WEBMVC.Models;

namespace Averis.WEBMVC.ViewModels
{
    public class HomeVm
    {
        public List<AverisHomeCards> Cards { get; set; }
        public List<AverisSlider> Slider { get; set; }
        public AverisAbout About { get; set; }
    }
}
