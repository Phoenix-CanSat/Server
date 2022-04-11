using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoenixServer.Core.Entities;
public sealed class Position
{
    [Key]
    [Column("position_id")]
    public int ID { get; set; }

    [Column("position_longitude")]
    public float Longitude { get; set; }

    [Column("position_latitude")]
    public float Latitude { get; set; }

    [Column("position_date")]
    public DateTime Datetime { get; set; } = DateTime.Now;
}
