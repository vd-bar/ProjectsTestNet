namespace WebAppTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreKeeper")]
    public partial class StoreKeeper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreKeeper()
        {
            Ditails = new HashSet<Ditails>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string LastFierstName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ditails> Ditails { get; set; }
    }
}
