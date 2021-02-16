using System;
using System.ComponentModel.DataAnnotations;

namespace OOP.Models
{
  [Serializable]
  public class Product
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
    public int Quantity { get; set; }
  }
}