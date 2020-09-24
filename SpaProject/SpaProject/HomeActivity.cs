using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;

namespace SpaProject
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var UserID = Intent.Extras.GetString("UserID");
            // Create your application here
            SetContentView(Resource.Layout.Home);

            Button DichvuBtn = FindViewById<Button>(Resource.Id.dichvubtn);
            Button GioHangBtn = FindViewById<Button>(Resource.Id.giohangbtn);

            DichvuBtn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(DichVuActivity));
                intent.PutExtra("UserID", UserID);
                StartActivity(intent);
            };
            GioHangBtn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(GiohangActivity));
                intent.PutExtra("UserID", UserID);
                StartActivity(intent);
            };
        }
    }
}