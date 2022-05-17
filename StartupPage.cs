using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayActionSheetTester
{
    internal class StartupPage: ContentPage
    {
        public StartupPage()
        {
            ToolbarItems.Add(new ToolbarItem("Tap me", "", async () => {
                await Navigation.PushModalAsync(new NavigationPage(new NextPage()) { BarTextColor = Colors.Black, BarBackgroundColor = Colors.Aqua });
            }, ToolbarItemOrder.Primary));


            Title = "StartupPage";

            Content = new Label { Text = "StartupPage" };
        }
    }
}
