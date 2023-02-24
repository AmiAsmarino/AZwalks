
using System.Net.NetworkInformation;

namespace AZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDeficultyID { get; set; }

        //Navigation Property
        public Region Region { get; set; }
        public WalkDeficulty WalkDeficulty { get; set; }


    }
}
