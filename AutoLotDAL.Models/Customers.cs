namespace AutoLotDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using AutoLotDAL.Models.Base;

    public partial class Customers : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
        }

        //[Key]
        //public int CustID { get; set; }

        [StringLength(50)]
        public string FirstNAme { get; set; }

        [StringLength(50)]
        public string LastNAme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        [NotMapped]
        public string FullName => FirstNAme + " " + LastNAme;
    }
}
