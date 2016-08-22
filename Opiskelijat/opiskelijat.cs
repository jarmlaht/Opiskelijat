namespace Opiskelijat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("opiskelijat")]
    public partial class opiskelijat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Opiskelija { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Tila { get; set; }
    }
}
