using System;
using System.Collections.Generic;

namespace DatabaseFirstAppPK.Models;

public partial class CarTable
{
    public int CarId { get; set; }

    public string? CarBrand { get; set; }

    public string? CarModel { get; set; }

    public string? CarPrice { get; set; }
}
