using System.Runtime.InteropServices;

namespace BTC_Client.Dtos;

public class BitcoinResponse
{
    public class TimeDS
    {
        public string Updated { get; set; }
        public DateTime UpdatedISO { get; set; }
        public string Updateduk { get; set; }
    }
    public class BpiDS
    {
        public class USDDs
        {
            public string Code { get; set; }
            public string Symbol { get; set; }
            public string Rate { get; set; }
            public string Description { get; set; }
            public float Rate_float { get; set; }
        }
        public class GBPDs
        {
            public string Code { get; set; }
            public string Symbol { get; set; }
            public string Rate { get; set; }
            public string Description { get; set; }
            public float Rate_float { get; set; }
        }
        public class EURDs
        {
            public string Code { get; set; }
            public string Symbol { get; set; }
            public string Rate { get; set; }
            public string Description { get; set; }
            public float Rate_float { get; set; }
        }
        
        public USDDs USD { get; set; }
        public GBPDs GBP { get; set; }
        public EURDs EUR { get; set; }
    }
    public TimeDS Time { get; set; }
    public BpiDS Bpi { get; set; }
    public string Disclaimer { get; set; }
    public string ChartName { get; set; }
}