﻿using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using BuyingAssistant;
namespace BuyingAssistant
{
    public partial class MainTabbedLayout : Xamarin.Forms.TabbedPage
    {
        public MainTabbedLayout()
        {
            Children.Add(new MainPage());
            Children.Add(new UpdateBankInfoPage(false));
            NavigationPage.SetHasNavigationBar(this,false);
            //Children.Add(new Rankings());
            //Children.Add(new PitScouting());
            InitializeComponent();

        }
    }
}