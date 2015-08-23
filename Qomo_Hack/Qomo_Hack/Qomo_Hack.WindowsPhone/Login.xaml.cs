using Qomo_Hack.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Qomo_Hack;
using System.Threading;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.UI.Popups;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Qomo_Hack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

       // Login rootPage = Login.Current;

        private HttpClient httpClient;
        private CancellationTokenSource cts;

        public Login()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }
        

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }

        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void login_tap(object sender, TappedRoutedEventArgs e)
        {

            Uri uri = new Uri("http://antakusuma.hol.es/wp/login.php", UriKind.Absolute);
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("sUsername", email.Text);
            pairs.Add("sPassword", password.Password.ToString());
            HttpFormUrlEncodedContent formContent =
                new HttpFormUrlEncodedContent(pairs);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(uri, formContent);
            

            string[] result = response.Content.ToString().Split('|');
            string strStatus = result[0].ToString();
            string strMemberID = result[1].ToString();
            string strError = "Password salah";
 
            if (strStatus == "0")
            {
                var dialog = new MessageDialog(strError).ShowAsync();
                //MessageBox.Show(e.Result.ToString());
                //MessageBox.Show(strError);


            }

            //else if (txtPassword.Password.ToString()=="")
            //{
            //    MessageBox.Show(strError);
            //}

            else
            //if (strStatus == "1")
            {
                //MessageBox.Show(e.Result.ToString());
                //NavigationService.Navigate(new Uri("/DetailPage.xaml?sMemberID=" + strMemberID, UriKind.Relative));
                //MessageBox.Show("berhasil");

                var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

                // Create a simple setting

                localSettings.Values["exampleSetting"] = email.Text;
                var dialog = new MessageDialog("berhasil").ShowAsync();
                Frame.Navigate(typeof(HubPage));
            }

            //{
                    //Logic login, ambil data dari database
            //}


        }
            
        

        private void signup_tap(object sender, TappedRoutedEventArgs e)
        {
            if (!Frame.Navigate(typeof(Signup)))
            {
                throw new Exception("NavigationFailedExceptionMessage");
            }
        }
        
        

        private void forgot_tap(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Forgot));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            //Frame.Navigate(typeof(kosong));
        }
=======
            Frame.Navigate(typeof(kosong));
        }

>>>>>>> 09a332c2f941e6bcc50b58ff22b49c2d6a8826e4
        private void about(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                ((Frame)Window.Current.Content).BackStack.Clear();
            }
<<<<<<< HEAD

=======
>>>>>>> 09a332c2f941e6bcc50b58ff22b49c2d6a8826e4
        }
    }
}
