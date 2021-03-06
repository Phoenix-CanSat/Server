using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class GroundTemperature
{
    [Key]
    [Column("ground_temperature_id")]
    public int ID { get; set; }

    [Column("ground_temperature_temperature")]
    public float Value { get; set; }

    [Column("ground_temperature_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
