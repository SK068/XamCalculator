using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace XamCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txtNum1;
        private TextView txtNum2;
        private TextView PlainText1;
        private TextView PlainText2;

        private double Num1;
        private double Num2;
        private double Number1;
        private double Number2;
        private double Result;

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDivide;
        private Button btnPlusCal;
        private Button btnMinusCal;
        private Button btnMulCal;
        private Button btnDivideCal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Calculator);
            InttializeControls();
        }
        void InttializeControls()
        {
            //btnPlus = FindViewById<Button>(Resource.Id.btnPlus);
            btnMinus = FindViewById<Button>(Resource.Id.btnminus);
            btnMul = FindViewById<Button>(Resource.Id.btnmul);
            btnDivide = FindViewById<Button>(Resource.Id.btnDivide);
            btnPlusCal = FindViewById<Button>(Resource.Id.btnPlusCal);
            btnMinusCal = FindViewById<Button>(Resource.Id.btnMinusCal);
            btnMulCal = FindViewById<Button>(Resource.Id.btnMulCal);
            btnDivideCal = FindViewById<Button>(Resource.Id.btnDivideCal);
            txtNum1 = FindViewById<TextView>(Resource.Id.txtNum1);
            txtNum2 = FindViewById<TextView>(Resource.Id.txtNum2);
            PlainText1 = FindViewById<TextView>(Resource.Id.PlainText1);
            PlainText2 = FindViewById<TextView>(Resource.Id.PlainText2);
            //btnPlus.Click += onBtnPlus_Click;
            //btnMinus.Click += onBtnMinus_Click;
            //btnMul.Click += onBtnMul_Click;
            //btnDivide.Click += onBtnDivide_Click;
            btnPlusCal.Click += onbtnPlusCal_Click;
            btnMinusCal.Click += onbtnMinusCal_Click;
            btnMulCal.Click += onbtnMulCal_Click;
            btnDivideCal.Click += onbtnDivideCal_Click;

        }

        private void onbtnDivideCal_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(PlainText1.Text);
            Number2 = Convert.ToDouble(PlainText2.Text);
            Result = Number1 / Number1;
            string result = (Number2 + " /" +
                "" +
                " " + Number2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onbtnMulCal_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(PlainText1.Text);
            Number2 = Convert.ToDouble(PlainText2.Text);
            Result = Number1 * Number1;
            string result = (Number2 + " *" +
                "" +
                " " + Number2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onbtnMinusCal_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(PlainText1.Text);
            Number2 = Convert.ToDouble(PlainText2.Text);
            Result = Number1 - Number1;
            string result = (Number2 + " -" +
                "" +
                " " + Number2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onbtnPlusCal_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(PlainText1.Text);
            Number2 = Convert.ToDouble(PlainText2.Text);
            Result = Number1 + Number1;
            string result = (Number2 + " +" +
                "" +
                " " + Number2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        

        private void onBtnDivide_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 / Num2;
            string result = (Num1 + " / " + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnMul_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 * Num2;
            string result = (Num1 + " * " + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnMinus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 - Num2;
            string result = (Num1 + " - " + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnPlus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 + Num2;
            string result = (Num1 + " +" +
                "" +
                " " + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}