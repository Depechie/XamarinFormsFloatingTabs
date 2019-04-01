using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFloatingTabs.Controls;
using XamarinFloatingTabs.Framework;
using XamarinFloatingTabs.Models;

namespace XamarinFloatingTabs.Views
{
    public partial class BasePage : ContentPage
    {
        public IList<View> BasePageContent => BaseContentGrid.Children;

        public static readonly BindableProperty BasePageTitleProperty =
            BindableProperty.Create(nameof(BasePageTitle), typeof(string), typeof(BasePage), string.Empty, defaultBindingMode: BindingMode.OneWay, propertyChanged: OnBasePageTitleChanged);

        public static readonly BindableProperty HideTabbarProperty =
            BindableProperty.Create(nameof(HideTabbar), typeof(bool), typeof(BasePage), false);

        public static readonly BindableProperty PageTabModeProperty =
            BindableProperty.Create(nameof(PageTabMode), typeof(PageTabMode), typeof(BasePage), PageTabMode.None, propertyChanged: OnPageTabModePropertyChanged);

        public string BasePageTitle
        {
            get => (string)GetValue(BasePageTitleProperty);
            set => SetValue(BasePageTitleProperty, value);
        }

        public bool HideTabbar
        {
            get => (bool)GetValue(HideTabbarProperty);
            set => SetValue(HideTabbarProperty, value);
        }

        public PageTabMode PageTabMode
        {
            get => (PageTabMode)GetValue(PageTabModeProperty);
            set => SetValue(PageTabModeProperty, value);
        }

        private static void OnBasePageTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.TitleLabel.Text = (string)newValue;
        }

        private static void OnPageTabModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.SetPageTabMode((PageTabMode)newValue);
        }

        public BasePage()
        {
            InitializeComponent();

            //Hide the Xamarin Forms build in navigation header
            NavigationPage.SetHasNavigationBar(this, false);

            //Fix top page marging requirement depending on the current device running the app
            StatusRowDefinition.Height = DependencyService.Get<IDeviceInfo>().StatusbarHeight;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var mainPage = App.Current.MainPage as CustomTabbedPage;
            mainPage.IsHidden = HideTabbar;

            SetPageTabMode(PageTabMode);
        }

        private void SetPageTabMode(PageTabMode pageTabMode)
        {
            if (App.Current.MainPage is CustomTabbedPage mainPage)
                mainPage.PageTabMode = pageTabMode;
        }
    }
}