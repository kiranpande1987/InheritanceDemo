using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InheritanceDemo
{
    public partial class SubPage : MainPage
    {
        public SubPage()
        {
            InitializeComponent();

            Click.Clicked += Click_Clicked;
        }

        private void Click_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new SecondPage());
        }
    }
}
