using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Keyless]
    public partial class HomeGame
    {
        [Column("yearkey")]
        public long? Yearkey { get; set; }
        [Column("leaguekey", TypeName = "VARCHAR (255)")]
        public string? Leaguekey { get; set; }
        [Column("teamkey", TypeName = "VARCHAR (255)")]
        public string? Teamkey { get; set; }
        [Column("parkkey", TypeName = "VARCHAR (255)")]
        public string? Parkkey { get; set; }
        [Column("spanfirst", TypeName = "VARCHAR (255)")]
        public string? Spanfirst { get; set; }
        [Column("spanlast", TypeName = "VARCHAR (255)")]
        public string? Spanlast { get; set; }
        [Column("games")]
        public long? Games { get; set; }
        [Column("openings")]
        public long? Openings { get; set; }
        [Column("attendance")]
        public long? Attendance { get; set; }
    }
}
