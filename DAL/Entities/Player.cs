using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    [Table("players")]
    public class Player
    {

        [Column("id")]
        public Guid Id { get; set; }

        [Column("device_id")]
        public string Name { get; set; }

        [Column("name")]
        public string DeviceId { get; set; }

        [Column("country")]
        public string Country { get; set; }


        // Foreign keys
        public virtual IEnumerable<Score> Scores { get; set; }
    }
}
