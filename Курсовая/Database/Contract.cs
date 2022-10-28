namespace Курсовая.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_contract { get; set; }

        public DateTime date_transaction { get; set; }

        public int id_client { get; set; }

        public int id_dealer { get; set; }

        public int id_lot { get; set; }

        [Column(TypeName = "money")]
        public decimal actual_price { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual Dealer Dealer { get; set; }
    }
}
