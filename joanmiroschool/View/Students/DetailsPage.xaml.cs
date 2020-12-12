﻿using System;
using System.Collections.Generic;
using joanmiroschool.Abstractions;
using joanmiroschool.ViewModel;
using Refit;
using Xamarin.Forms;

namespace joanmiroschool.View.Students
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(string id)
        {
            InitializeComponent();
            BindingContext = new StudentDetailViewModel(RestService.For<IJMServices>("https://eliappjmadmin.herokuapp.com"),id);
        }
    }
}
