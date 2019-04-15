using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace TesterAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    
    public class MainActivity : AppCompatActivity
    {
        private EditText num1, num2;
        TextView display;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            display = FindViewById<TextView>(Resource.Id.display);
            num1 = FindViewById<EditText>(Resource.Id.num1);
            num2 = FindViewById<EditText>(Resource.Id.num2);
            Button execute = FindViewById<Button>(Resource.Id.execute);
            Button next = FindViewById<Button>(Resource.Id.btnNext);

            //string val = string.Format(first);
            next.Click += (sender, e) => {
                Toast.MakeText(this, "Second Activity", ToastLength.Long).Show();
                StartActivity(typeof(SecondActivity));
            };
            int count = 0;
            execute.Click += (sender, e) => {
                try  {
                    Summation();
                }
                catch (FormatException a)
                {
                    Console.WriteLine("Error" +a.Message);

                }
                count++;
                ((Button)sender).Text = $"You clicked {count} times.";
            };

        }
        public void Summation()
        {
            string numberOne = num1.Text;
            string numberTwo = num2.Text;

            int first = int.Parse(numberOne);
            int second = int.Parse(numberTwo);

            int sum = first + second;
            display.Text = $"The Sum of Two Numbers: {sum} ";
            //StartActivity(typeof(SecondActivity));

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}