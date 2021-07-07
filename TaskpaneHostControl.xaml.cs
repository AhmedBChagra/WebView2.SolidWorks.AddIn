using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebView2.SolidWorks.AddIn
{
    /// <summary>
    /// Interaction logic for TaskpaneHostControl.xaml
    /// </summary>
    public partial class TaskpaneHostControl : UserControl
    {
        public TaskpaneHostControl()
        {
            InitializeComponent();
            InitializeBrowser("https://www.google.com/");
        }

        private async void InitializeBrowser(string url = null)
        {
            var userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SLDWORKS";
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder);
            await webView.EnsureCoreWebView2Async(env);
            webView.CoreWebView2.Navigate(url);
        }
    }
}
