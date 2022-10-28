namespace Курсовая.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Contract = new HashSet<Contract>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_lot { get; set; }

        public int? id_carcase { get; set; }

        public DateTime? year_issue { get; set; }

        public int? mileage { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [StringLength(50)]
        public string color { get; set; }

        [StringLength(50)]
        public string type_engine { get; set; }

        [StringLength(50)]
        public string fuel_type { get; set; }

        public DateTime? date_issue { get; set; }

        [Required]
        [StringLength(20)]
        public string availability { get; set; }

        [StringLength(50)]
        public string model_name { get; set; }

        public decimal? engine_capacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        public virtual Model Model { get; set; }

        public virtual State State { get; set; }
    }
}
