using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
  public class AccountViewModel
  {
    [Required]
    public string Username {get;set;}
    [Required]
    [DataType(DataType.Password)]
    public string Password {get;set;}

    public AccountViewModel() {}
  }
}
