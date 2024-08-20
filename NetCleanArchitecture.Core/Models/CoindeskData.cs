
namespace NetCleanArchitecture.Core.Models
{
    public class CoindeskData
    {
        public Time Time { get; set; }
        public string Disclaimer { get; set; }
        public string ChartName { get; set; }
        public Bpi Bpi { get; set; }
    }

    public class Time
    {
        public string Updated { get; set; }
        public DateTime UpdatedISO { get; set; }
        public string UpdatedUk { get; set; }
    }

    public class Bpi
    {
        public Usd USD { get; set; }
        public Gbp GBP { get; set; }
        public Eur EUR { get; set; }
    }

    public class Usd
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public float RateFloat { get; set; }
    }

    public class Gbp
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public float RateFloat { get; set; }
    }

    public class Eur
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public float RateFloat { get; set; }
    }


}
