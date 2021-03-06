﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    [Table("scores")]
    public class Score
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("player_id")]
        public Guid PlayerId { get; set; }

        [Column("distance")]
        public int Distance { get; set; }

        [Column("duration")]
        public int DurationInSeconds { get; set; }

        [Column("coins_collected")]
        public int CoinsCollected { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
