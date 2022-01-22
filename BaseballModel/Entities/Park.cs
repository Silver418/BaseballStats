using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class Park
    {
        [Key]
        [Column("parkkey", TypeName = "VARCHAR(255)")]
        public string Parkkey { get; set; } = null!;
        [Column("parkname", TypeName = "VARCHAR(255)")]
        public string? Parkname { get; set; }
        [Column("parkalias", TypeName = "VARCHAR(255)")]
        public string? Parkalias { get; set; }
        [Column("city", TypeName = "VARCHAR(255)")]
        public string? City { get; set; }
        [Column("state", TypeName = "VARCHAR(255)")]
        public string? State { get; set; }
        [Column("country", TypeName = "VARCHAR(255)")]
        public string? Country { get; set; }
    }
}
