using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Keyless]
    [Table("AllstarFull")]
    [Index(nameof(GameId), Name = "idx_gameID")]
    [Index(nameof(GameNum), Name = "idx_gameNum")]
    [Index(nameof(LgId), Name = "idx_lgID")]
    [Index(nameof(PlayerId), Name = "idx_playerID")]
    [Index(nameof(TeamId), Name = "idx_teamID")]
    [Index(nameof(YearId), Name = "idx_yearID")]
    public partial class AllstarFull
    {
        [Column("playerID", TypeName = "VARCHAR (255)")]
        public string? PlayerId { get; set; }
        [Column("yearID")]
        public long? YearId { get; set; }
        [Column("gameNum")]
        public long? GameNum { get; set; }
        [Column("gameID", TypeName = "VARCHAR (255)")]
        public string? GameId { get; set; }
        [Column("teamID", TypeName = "VARCHAR (255)")]
        public string? TeamId { get; set; }
        [Column("lgID", TypeName = "VARCHAR (255)")]
        public string? LgId { get; set; }
        [Column("GP")]
        public long? Gp { get; set; }
        [Column("startingPos", TypeName = "VARCHAR (255)")]
        public string? StartingPos { get; set; }
    }
}
