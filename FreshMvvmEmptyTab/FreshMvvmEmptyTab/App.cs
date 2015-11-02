using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;
using FreshMvvmEmptyTab.PageModels;
using FreshMvvmEmptyTab.Pages;
using Xamarin.Forms;

namespace FreshMvvmEmptyTab
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = FreshPageModelResolver.ResolvePageModel<MainPageModel>();

            // TODO This DOES work
            //var page = new FreshTabbedNavigationContainer();
            //page.AddTab<Tab1PageModel>("Tab 1", null);
            //page.AddTab<Tab2PageModel>("Tab 2", null);

            //MainPage = page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
