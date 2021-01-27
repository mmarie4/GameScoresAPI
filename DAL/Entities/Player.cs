using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    [Table("players")]
    public class Player
    {
        [Key]
        [Column("device_id")]
        public string DeviceId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("country")]
        public string Country { get; set; }


        // Foreign keys
        public virtual IEnumerable<Score> Scores { get; set; }
    }
}
