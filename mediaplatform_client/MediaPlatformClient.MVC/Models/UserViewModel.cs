using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class UserViewModel
    {
      public long ID {get;set;}
      public string Name {get;set;}
      public string Username {get;set;}
      public string Password {get;set;}

      public UserViewModel() {}
    }
}