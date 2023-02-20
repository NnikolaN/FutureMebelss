using FutureMebels.Data;
using System;
using System.Collections.Generic;

public class Type
{
    public int Id { get; set; }
    public string Description { get; set; }
   public ICollection<Articul> Articuls{ get; set; }
}
