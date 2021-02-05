using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Xamarin_Intent.Resources.layout
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        Button BTN;
        TextView TXT;
        int Num;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "layout1" layout resource
            SetContentView(Resource.Layout.layout1);
            // Create your application here

            TXT = FindViewById<TextView>(Resource.Id.txt1);
            BTN = FindViewById<Button>(Resource.Id.btn1);
            BTN.Click += delegate
            {
                TXT.Text = "Click : " + Num;
                Num++;
            };
        }
    }
}