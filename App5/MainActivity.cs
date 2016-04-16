using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App5
{
    [Activity(Label = "App5", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            // button1.Click += delegate { button1.Text = "done"; };
            button1.Click += Button1_Click;
            button1.Hover += Button1_Hover;
        }

        private void Button1_Hover(object sender, View.HoverEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

