using System;

namespace Products.Models
{
public class ProductsModel
  {
    public int Product_ID {get; set;}
    public string? Product_Name {get; set;}
    public string? Product_QTY {get; set;}
    public string? Product_Price {get; set;}
    public string? Order_ID {get; set;}
    public DateOnly Order_Date {get; set;}
    
}
}