using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOP.Models
{
  public class Sale
  {
    [Key]
    public Guid Id { get; set; }
    public List<Product> Products { get; set; }
    public double Total { get; set; }
    public double Payback { get; set; }
  }
}