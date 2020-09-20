using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SpaProject.Models
{
    class User
    {
        public string USERNAME { get; set; }
        public string PASSWORDS { get; set; }
    }
    class LoginReturn
    {
        public string ID { get; set; }
    }
    class LoginReturns
    {
        public List<LoginReturn> OBJ { get; set; }
    }
}