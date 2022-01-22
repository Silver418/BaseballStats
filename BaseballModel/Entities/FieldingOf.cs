using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("FieldingOF")]
    public partial class FieldingOf
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("stint", TypeName = "SMALLINT")]
        public long Stint { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Glf { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Gcf { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Grf { get; set; }
    }
}
