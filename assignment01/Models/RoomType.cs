using System;
using System.Collections.Generic;

namespace assignment01.Models;

public partial class RoomType
{
    public int RoomTypeId { get; set; }

    public string RoomTypeName { get; set; } = null!;

    public string? TypeDescription { get; set; }

    public string? TypenNote { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
