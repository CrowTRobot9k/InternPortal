using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.ViewModels
{
    public class HomePageViewModel
    {
       public AspNetUser DomainUser { get; set; }
       public User User { get; set; }
    }
}