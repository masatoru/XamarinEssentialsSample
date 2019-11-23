using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinEssentialsSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickCheckFolder(object sender, EventArgs e)
        {
            var essentialCacheDirectory = FileSystem.CacheDirectory;
            var appDataDirectory = FileSystem.AppDataDirectory;

            string BR= Environment.NewLine;
            lblFolder.Text = $"FileSystem.CacheDirectory:{BR}{essentialCacheDirectory}{BR}{BR}"
                + $"FileSystem.AppDataDirectory:{BR}{appDataDirectory}{BR}{BR}";
        }
    }
}
