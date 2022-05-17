using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayActionSheetTester
{
    internal class NextPage : ContentPage
    {
        public NextPage()
        {
            ToolbarItems.Add(new ToolbarItem("Alert", "", async () => {
                await Application.Current.MainPage.DisplayAlert($"Hi", "I'm showing", "Cancel");
            }, ToolbarItemOrder.Primary));

            ToolbarItems.Add(new ToolbarItem("ActionSheet", "", async () => {
                await Application.Current.MainPage.DisplayActionSheet($"Menu ...", "Cancel", null, new string[] { "Action1", "Action2" });
            }, ToolbarItemOrder.Primary));

            Title = "NextPage";

            Content = new Label { Text = "NextPage" };
        }
    }
}
