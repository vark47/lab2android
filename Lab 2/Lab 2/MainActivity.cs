using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace Lab_2
{
    [Activity(Label = "Lab_2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {


        public const string passedNumber = "Passed number";
        public const string secondPassedNumber = "Passed number";
        public int RESULT_REQUEST = 0;
        //int count = 1;


        

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button takeOneButton = FindViewById<Button>(Resource.Id.takeOneButtonID);
            Button takeTwoButton = FindViewById<Button>(Resource.Id.takeTwoButtonID);

            



            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            takeOneButton.Click += delegate {
                var activity2 = new Intent(this, typeof(TheCodeActivity));
                activity2.PutExtra(passedNumber, 1);
                StartActivity(activity2);
            };

            takeTwoButton.Click += delegate {
                var secondActivity2 = new Intent(this, typeof(TheCodeActivity));
                // Note: Intent is both a class and a property name, be sure you have a using statement

                secondActivity2.PutExtra(secondPassedNumber, 2);
                StartActivityForResult(secondActivity2, 0);
            };


            
        }
      
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == RESULT_REQUEST)
            {
                if (resultCode == Result.Ok)
                {
                    TextView text = FindViewById<TextView>(Resource.Id.mainTextArea);
                    int value = Intent.Extras.GetInt(TheCodeActivity.message);
                    text.Text = "TEST";
                }
            }
        }




    }

}

