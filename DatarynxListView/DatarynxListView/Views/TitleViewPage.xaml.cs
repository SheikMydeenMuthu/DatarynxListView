﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatarynxListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TitleViewPage : ContentPage
    {
        public TitleViewPage()
        {
            InitializeComponent();
            //NavigationPage.SetTitleView(this, titleView);
        }
    }
}