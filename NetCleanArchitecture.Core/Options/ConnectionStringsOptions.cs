
namespace NetCleanArchitecture.Core.Options
{
    public class ConnectionStringsOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection { get; set; } = null!;
    }
}
