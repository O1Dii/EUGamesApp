﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Expandable;

using EUGamesApp.Models;
using EUGamesApp.Views;
using EUGamesApp.ViewModels;
using System.Diagnostics;


namespace EUGamesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimetablePage : ContentPage
    {
        public MainPage mainPage;
        public EventsViewModel model;

        public TimetablePage(MainPage mainPage)
        {
            this.mainPage = mainPage;
            InitializeComponent();
            model = new EventsViewModel();
            BindingContext = model;
            App.TimetablePage = this;
            EventsList.HeightRequest = model.Items.Count * 81;
            EventsList.MinimumHeightRequest = model.Items.Count * 81;
        }

        public void ChangeSize(double expanded)
        {
            if (expanded != 0)
            {
                EventsList.HeightRequest = model.Items.Count * 81 + expanded;
                EventsList.MinimumHeightRequest = model.Items.Count * 81 + expanded;
            }
            else
            {
                EventsList.HeightRequest = model.Items.Count * 81;
                EventsList.MinimumHeightRequest = model.Items.Count * 81;
            }
        }
    }
}