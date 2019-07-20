using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace SimpleCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public double Number1, Number2, Result;
        public char OP;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Tools
            TextView txtCalculate = FindViewById<TextView>(Resource.Id.Result);
            //
            Button btn0 = FindViewById<Button>(Resource.Id.btn0);
            //
            Button btn1 = FindViewById<Button>(Resource.Id.btn1);
            //
            Button btn2 = FindViewById<Button>(Resource.Id.btn2);
            //
            Button btn3 = FindViewById<Button>(Resource.Id.btn3);
            //
            Button btn4 = FindViewById<Button>(Resource.Id.btn4);
            //
            Button btn5 = FindViewById<Button>(Resource.Id.btn5);
            //
            Button btn6 = FindViewById<Button>(Resource.Id.btn6);
            //
            Button btn7 = FindViewById<Button>(Resource.Id.btn7);
            //
            Button btn8 = FindViewById<Button>(Resource.Id.btn8);
            //
            Button btn9 = FindViewById<Button>(Resource.Id.btn9);
            //
            Button btndot = FindViewById<Button>(Resource.Id.btndot);
            //
            Button btnclear = FindViewById<Button>(Resource.Id.btnclear);
            //
            Button btnequal = FindViewById<Button>(Resource.Id.btnequal);
            //
            Button btnsum = FindViewById<Button>(Resource.Id.btnsum);
            //
            Button btnminus = FindViewById<Button>(Resource.Id.btnminus);
            //
            Button btnmultiplication = FindViewById<Button>(Resource.Id.btnmultiplication);
            //
            Button btndivide = FindViewById<Button>(Resource.Id.btndivide);

            //Events
            btn0.Click += delegate
            {
                txtCalculate.Text += "0";
            };
            //
            btn1.Click += delegate
            {
                txtCalculate.Text += "1";
            };
            //
            btn2.Click += delegate
            {
                txtCalculate.Text += "2";
            };
            //
            btn3.Click += delegate
            {
                txtCalculate.Text += "3";
            };
            //
            btn4.Click += delegate
            {
                txtCalculate.Text += "4";
            };
            //
            btn5.Click += delegate
            {
                txtCalculate.Text += "5";
            };
            //
            btn6.Click += delegate
            {
                txtCalculate.Text += "6";
            };
            //
            btn7.Click += delegate
            {
                txtCalculate.Text += "7";
            };
            //
            btn8.Click += delegate
            {
                txtCalculate.Text += "8";
            };
            //
            btn9.Click += delegate
            {
                txtCalculate.Text += "9";
            };
            //
            btndot.Click += delegate
            {
                txtCalculate.Text += ".";
            };
            //
            btnclear.Click += delegate
            {
                txtCalculate.Text = "";
            };
            //
            btnsum.Click += delegate
            {
                this.Number1 = Convert.ToDouble(txtCalculate.Text);
                txtCalculate.Text = "";
                this.OP = '+';
            };
            //
            btnminus.Click += delegate
            {
                this.Number1 = Convert.ToDouble(txtCalculate.Text);
                txtCalculate.Text = "";
                this.OP = '-';
            };
            //
            btnmultiplication.Click += delegate
            {
                this.Number1 = Convert.ToDouble(txtCalculate.Text);
                txtCalculate.Text = "";
                this.OP = '*';
            };
            //
            btndivide.Click += delegate
            {
                this.Number1 = Convert.ToDouble(txtCalculate.Text);
                txtCalculate.Text = "";
                this.OP = '/';
            };
            //
            btnequal.Click += delegate
            {
                this.Number2 = Convert.ToDouble(txtCalculate.Text);
                switch(this.OP)
                {
                    case '+':
                        this.Result = this.Number1 + this.Number2;
                        break;
                    case '-':
                        this.Result = this.Number1 - this.Number2;
                        break;
                    case '*':
                        this.Result = this.Number1 * this.Number2;
                        break;
                    case '/':
                        this.Result = this.Number1 / this.Number2;
                        break;
                }
                txtCalculate.Text = Convert.ToString(this.Result);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}