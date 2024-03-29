namespace AutoLotDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using AutoLotDAL.Models.Base;

    public partial class Order:EntityBase
    {

        public int CustomerId { get; set; }

        public int CarId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customers Customer { get; set; }

        [ForeignKey(nameof(CarId))]
        public virtual Inventory Car { get; set; }
    }
}
