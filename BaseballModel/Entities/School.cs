using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class School
    {
        [Key]
        [Column("schoolID", TypeName = "VARCHAR (15)")]
        public string SchoolId { get; set; } = null!;
        [Column("name_full", TypeName = "VARCHAR (255)")]
        public string? NameFull { get; set; }
        [Column("city", TypeName = "VARCHAR (55)")]
        public string? City { get; set; }
        [Column("state", TypeName = "VARCHAR (55)")]
        public string? State { get; set; }
        [Column("country", TypeName = "VARCHAR (55)")]
        public string? Country { get; set; }
    }
}
