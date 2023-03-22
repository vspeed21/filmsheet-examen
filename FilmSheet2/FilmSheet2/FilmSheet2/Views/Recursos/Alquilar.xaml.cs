﻿using FilmSheet.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmSheet.Views.Recursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alquilar : ContentPage
    {
        public Alquilar()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new VMAlquilar();
        }

    }
}