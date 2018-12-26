using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Crop
    {
        public Crop()
        {
            Invoice = new HashSet<Invoice>();
            Roadmap = new HashSet<Roadmap>();
        }

        public int CropId { get; set; }
        public string Name { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Roadmap> Roadmap { get; set; }
    }
}
