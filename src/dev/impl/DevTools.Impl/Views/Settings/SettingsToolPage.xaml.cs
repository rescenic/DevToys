﻿#nullable enable

using DevTools.Core.Navigation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DevTools.Impl.Views.Settings
{
    public sealed partial class SettingsToolPage : Page
    {
        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                nameof(ViewModel),
                typeof(SettingsToolViewModel),
                typeof(SettingsToolPage),
                new PropertyMetadata(null));

        /// <summary>
        /// Gets the page's view model.
        /// </summary>
        public SettingsToolViewModel ViewModel
        {
            get => (SettingsToolViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        public SettingsToolPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameters = (NavigationParameter)e.Parameter;

            // Set the view model
            ViewModel = (SettingsToolViewModel)parameters.Parameter!;
            DataContext = ViewModel;

            base.OnNavigatedTo(e);
        }
    }
}