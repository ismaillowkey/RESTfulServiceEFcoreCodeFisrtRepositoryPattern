using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("randomdata")]
    public class RandomData
    {
        [Key]
        [Column("id")]
        [Required(ErrorMessage = "Id Required")]
        public string Id { get; set; }

        [Column("date")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        [Required(ErrorMessage = "Date Required")]
        public DateTime Date { get; set; }

        [Column("timestamp")]
        [Required(ErrorMessage = "Timestamp Required")]
        public DateTime Timestamp {get;set;}

        [Column("valuerandom")]
        [Required(ErrorMessage = "ValueRandom Required")]
        public string ValueRandom { get; set; }
    }
}
