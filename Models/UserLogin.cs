using System;

namespace login.Models
{
public class loginModel
  {
    public int id {get; set;}
    public string? Username {get; set;}
    public string? Password {get; set;}

  public bool ShowUsername => !string.IsNullOrEmpty(Username);
}
}