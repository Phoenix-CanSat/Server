using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class Altitude
{
    [Key]
    [Column("altitude_id")]
    public int ID { get; set; }

    [Column("altitude_altitude")]
    public float Value { get; set; }

    [Column("altitude_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
