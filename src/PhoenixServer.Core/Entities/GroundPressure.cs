using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class GroundPressure
{
    [Key]
    [Column("ground_pressure_id")]
    public int ID { get; set; }

    [Column("ground_pressure_pressure")]
    public float Value { get; set; }

    [Column("ground_pressure_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
