using System.Net.NetworkInformation;

namespace AZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public String Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long  Population { get; set; }


        //Navigation Property
        public IEnumerable<Walk> Walks { get; set; }

    }
}
