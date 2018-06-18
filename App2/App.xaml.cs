using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new CarouselPage
            {
                Children=
                {
                    new MainPage(),
                    new Page1(),
                    new Page2(),
                    new Page3()
                }

            };
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
