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

            ToolbarItems.Add(new ToolbarItem("Prompt", "", async () => {
                await Application.Current.MainPage.DisplayPromptAsync("Prompt", "Enter a number < 9999", "OK", "Cancel", keyboard: Keyboard.Numeric);
            }, ToolbarItemOrder.Primary));

            Content = new Label { Text = "NextPage" };
        }
    }
}
