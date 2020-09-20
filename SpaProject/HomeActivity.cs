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

namespace SpaProject
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var UserID = Intent.Extras.GetInt("UserID");
            // Create your application here
            SetContentView(Resource.Layout.Home);

            Button DichvuBtn = FindViewById<Button>(Resource.Id.dichvubtn);

            DichvuBtn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(DichVuActivity));
                StartActivity(intent);
            };
        }
    }
}