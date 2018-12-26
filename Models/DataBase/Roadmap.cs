using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Roadmap
    {
        public int RoadmapId { get; set; }
        public double? Scope { get; set; }
        public DateTime Date { get; set; }
        public decimal? Sum { get; set; }
        public int? CropId { get; set; }
        public int? CarId { get; set; }

        public Agrotechnic Car { get; set; }
        public Crop Crop { get; set; }
    }
}
