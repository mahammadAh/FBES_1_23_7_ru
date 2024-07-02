﻿using FuzzyLogic.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace FuzzyLogic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModelLocator viewModelLocator = new ViewModelLocator();
            MainScreen mainScreen = new MainScreen();
            mainScreen.DataContext = viewModelLocator.GetMainScreenVM();
            mainScreen.ShowDialog();
        }
    }
}