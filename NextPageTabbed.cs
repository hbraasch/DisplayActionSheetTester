using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayActionSheetTester
{
    internal class NextPageTabbed : TabbedPage
    {
        public NextPageTabbed()
        {
            Children.Add(new NextPageTab1());
            Children.Add(new NextPageTab2());

            ToolbarItems.Add(new ToolbarItem("Tap me", "", async () => {
                await Application.Current.MainPage.DisplayActionSheet($"Menu ...", "Cancel", null, new string[] {"Action1", "Action2"});
            },ToolbarItemOrder.Primary));

            Title = "TabbedPage";
        }
    }
}
