using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DatarynxListView.Views;

namespace DatarynxListView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage() { };
            //var masterDetailpage = new MainPage
            //{
            //    Icon = "menuIcon.png",
            //    Master = new Page { Title = "Sample" },
            //    Detail = new Page()
            //};

            //MainPage = new NavigationPage(masterDetailpage) { Title = "Sample", Icon = "MenuIcon.png" };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
