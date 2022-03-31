using System.Runtime.Serialization;

namespace CorretoraABC.MVC.Models
{
    [DataContract]
    public class DataPointPrecoAtivo
    {
        public DataPointPrecoAtivo(double date, decimal openPrice, decimal highPrice, decimal lowPrice, decimal closePrice, decimal adjClosePrice, decimal volume)
        {
            this.Date = date;
            this.OpenPrice = openPrice;
            this.HighPrice = highPrice;
            this.LowPrice = lowPrice;
            this.ClosePrice = closePrice;
            this.AdjClosePrice = adjClosePrice;
            this.Volume = volume;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "Date")]
        public double? Date = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "OpenPrice")]
        public decimal? OpenPrice = null;

        [DataMember(Name = "HighPrice")]
        public decimal? HighPrice = null;

        [DataMember(Name = "LowPrice")]
        public decimal? LowPrice = null;

        [DataMember(Name = "ClosePrice")]
        public decimal? ClosePrice = null;

        [DataMember(Name = "AdjClosePrice")]
        public decimal? AdjClosePrice = null;

        [DataMember(Name = "Volume")]
        public decimal? Volume = null;
    }
}
