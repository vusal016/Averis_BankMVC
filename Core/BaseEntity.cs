namespace Averis.WEBMVC.Core
{
    public class BaseEntity
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();
    }
}
