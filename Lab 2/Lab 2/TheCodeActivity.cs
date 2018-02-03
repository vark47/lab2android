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

namespace Lab_2
{
    [Activity(Label = "Activity2")]
    public class TheCodeActivity : Activity
    {
        public const string message = "bugs in the app";
        public int count = 99;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TheCode);

            // Create your application here

            int value = Intent.Extras.GetInt(MainActivity.passedNumber);
            Button patchAroundButton = FindViewById<Button>(Resource.Id.patchAroundButton);

            TextView secondTextArea = FindViewById<TextView>(Resource.Id.secondTextArea);
            secondTextArea.Text = message + " " + count;

            patchAroundButton.Click += delegate {
                count--;
                secondTextArea.Text = message + " " + count;

                var activity1 = new Intent(this, typeof(MainActivity));
                activity1.PutExtra(message, count);
                StartActivity(activity1);
            };

          










        }
    }
}