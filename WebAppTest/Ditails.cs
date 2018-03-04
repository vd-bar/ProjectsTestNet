namespace WebAppTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ditails
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string NameIdCode { get; set; }

        [Required]
        [StringLength(20)]
        public string NameDetails { get; set; }

        public int? Quantity { get; set; }

        public int StoreKeeper { get; set; }

        public DateTime DateAdd { get; set; }

        public DateTime? DateDelete { get; set; }

        public virtual StoreKeeper StoreKeeper1 { get; set; }
    }
}
