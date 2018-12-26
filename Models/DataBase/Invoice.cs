using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int? CropId { get; set; }
        public DateTime Date { get; set; }
        public decimal? Sum { get; set; }

        public Crop Crop { get; set; }
    }
}
