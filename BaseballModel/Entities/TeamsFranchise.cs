using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class TeamsFranchise
    {
        [Key]
        [Column("franchID", TypeName = "VARCHAR (3)")]
        public string FranchId { get; set; } = null!;
        [Column("franchName", TypeName = "VARCHAR (50)")]
        public string? FranchName { get; set; }
        [Column("active", TypeName = "VARCHAR (2)")]
        public string? Active { get; set; }
        [Column("NAassoc", TypeName = "VARCHAR (3)")]
        public string? Naassoc { get; set; }
    }
}
