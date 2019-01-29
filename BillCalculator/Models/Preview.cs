using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using Windows.System;
using Windows.UI.Popups;

namespace BillCalculator.Models
{
    public class Preview
    {
        public static async Task RateApp()
        {
            MessageDialog RateDialog = new MessageDialog("رأيك يهمنا. هل ترغب في تقييم التطبيق؟");
            RateDialog.Commands.Add(new UICommand("التقييم الآن", async (command) =>
            {
                await Launcher.LaunchUriAsync(new Uri(string.Format("ms-windows-store:REVIEW?PFN={0}", Windows.ApplicationModel.Package.Current.Id.FamilyName)));
            }));
            RateDialog.Commands.Add(new UICommand("لاحقاً"));
            RateDialog.DefaultCommandIndex = 0;
            RateDialog.CancelCommandIndex = 1;
            await RateDialog.ShowAsync();
        }

        public static bool CheckInternetConnectivity()
        {
            var internetProfile = NetworkInformation.GetInternetConnectionProfile();
            if (internetProfile == null)
                return false;

            return (internetProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
        }
    }
}
