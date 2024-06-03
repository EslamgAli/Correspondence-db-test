using Domain.Base;

namespace Domain.Models
{
    public class CorrespondenceAction : EntityBase
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;

    }
}
