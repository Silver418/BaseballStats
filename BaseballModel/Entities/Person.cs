using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Index(nameof(BbrefId), Name = "idx_bbrefID")]
    [Index(nameof(RetroId), Name = "idx_retroID")]
    public partial class Person
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (255)")]
        public string PlayerId { get; set; } = null!;
        [Column("birthYear")]
        public long? BirthYear { get; set; }
        [Column("birthMonth")]
        public long? BirthMonth { get; set; }
        [Column("birthDay")]
        public long? BirthDay { get; set; }
        [Column("birthCountry", TypeName = "VARCHAR (255)")]
        public string? BirthCountry { get; set; }
        [Column("birthState", TypeName = "VARCHAR (255)")]
        public string? BirthState { get; set; }
        [Column("birthCity", TypeName = "VARCHAR (255)")]
        public string? BirthCity { get; set; }
        [Column("deathYear", TypeName = "SMALLINT")]
        public long? DeathYear { get; set; }
        [Column("deathMonth", TypeName = "SMALLINT")]
        public long? DeathMonth { get; set; }
        [Column("deathDay", TypeName = "SMALLINT")]
        public long? DeathDay { get; set; }
        [Column("deathCountry", TypeName = "VARCHAR (255)")]
        public string? DeathCountry { get; set; }
        [Column("deathState", TypeName = "VARCHAR (255)")]
        public string? DeathState { get; set; }
        [Column("deathCity", TypeName = "VARCHAR (255)")]
        public string? DeathCity { get; set; }
        [Column("nameFirst", TypeName = "VARCHAR (255)")]
        public string? NameFirst { get; set; }
        [Column("nameLast", TypeName = "VARCHAR (255)")]
        public string? NameLast { get; set; }
        [Column("nameGiven", TypeName = "VARCHAR (255)")]
        public string? NameGiven { get; set; }
        [Column("weight", TypeName = "SMALLINT")]
        public long? Weight { get; set; }
        [Column("height", TypeName = "SMALLINT")]
        public long? Height { get; set; }
        [Column("bats", TypeName = "VARCHAR (255)")]
        public string? Bats { get; set; }
        [Column("throws", TypeName = "VARCHAR (255)")]
        public string? Throws { get; set; }
        [Column("debut", TypeName = "VARCHAR (255)")]
        public string? Debut { get; set; }
        [Column("finalGame", TypeName = "VARCHAR (255)")]
        public string? FinalGame { get; set; }
        [Column("retroID", TypeName = "VARCHAR (255)")]
        public string? RetroId { get; set; }
        [Column("bbrefID", TypeName = "VARCHAR (255)")]
        public string? BbrefId { get; set; }
    }

    //method to return data as a string array array here?
    //or just pass (a copy of) the list entirely?
}
