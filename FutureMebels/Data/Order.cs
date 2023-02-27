using FutureMebels.Data;
using System;
using System.Collections.Generic;

public class Order
{
    public int Id { get; set; }

    public int ArticulId { get; set; }

    public Articul Articuls{ get; set; }

    public int CustomerId { get; set; }

    public int Quantity { get; set; }

    public DateTime RegisterOn{ get; set; }


}
