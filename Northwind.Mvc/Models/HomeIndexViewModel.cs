using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Packt.Shared;

namespace Northwind.Mvc.Models;

public record HomeIndexViewModel
(
    int VisitorCount,
    IList<Category> Categories,
    IList<Product> Products
);