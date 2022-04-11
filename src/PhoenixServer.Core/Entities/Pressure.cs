using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class Pressure
{
    [Key]
    [Column("pressure_id")]
    public int ID { get; set; }

    [Column("pressure_pressure")]
    public float Value { get; set; }

    [Column("pressure_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
