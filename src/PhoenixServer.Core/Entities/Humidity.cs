using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class Humidity
{
    [Key]
    [Column("humidity_id")]
    public int ID { get; set; }

    [Column("humidity_humidity")]
    public float Value { get; set; }

    [Column("humidity_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
