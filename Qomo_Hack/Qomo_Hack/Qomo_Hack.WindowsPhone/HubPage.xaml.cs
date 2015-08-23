using Qomo_Hack.Common;
using Qomo_Hack.Data;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Net;
using System.Net.NetworkInformation;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using TweetSharp;
using System.Net.Http;

using System.Xml.Linq;
using Qomo_Hack.DataModel;

// The Universal Hub Application project template is documented at http://go.microsoft.com/fwlink/?LinkID=391955

namespace Qomo_Hack
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HubPage : Page
    {
        private readonly NavigationHelper navigationHelper;
        private readonly ObservableDictionary defaultViewModel = new ObservableDictionary();
        private readonly ResourceLoader resourceLoader = ResourceLoader.GetForCurrentView("Resources");

        //The Windows.Web.Http.HttpClient class provides the main class for 
        // sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
        private HttpClient httpClient;
        private HttpResponseMessage response;

        // This is the feed address that will be parsed and displayed
        private String feedAddress = "http://www.bisnis.com/rss/index?c=194";


        public HubPage()
        {
            this.InitializeComponent();

            httpClient = new HttpClient();
            // Add a user-agent header
            var headers = httpClient.DefaultRequestHeaders;
            headers.UserAgent.ParseAdd("ie");
            headers.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");


            // Hub is only supported in Portrait orientation
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

            this.NavigationCacheMode = NavigationCacheMode.Required;

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
        /// <see cref="Frame.Navigate(Type, object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Create an appropriate data model for your problem domain to replace the sample data
            var sampleDataGroups = await SampleDataSource.GetGroupsAsync();
            this.DefaultViewModel["Groups"] = sampleDataGroups;
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
            // TODO: Save the unique state of the page here.
        }

        /// <summary>
        /// Shows the details of a clicked group in the <see cref="SectionPage"/>.
        /// </summary>
        /// <param name="sender">The source of the click event.</param>
        /// <param name="e">Details about the click event.</param>
        private void GroupSection_ItemClick(object sender, ItemClickEventArgs e)
        {
            var groupId = ((SampleDataGroup)e.ClickedItem).UniqueId;
            if (!Frame.Navigate(typeof(SectionPage), groupId))
            {
                throw new Exception(this.resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        /// <summary>
        /// Shows the details of an item clicked on in the <see cref="ItemPage"/>
        /// </summary>
        /// <param name="sender">The source of the click event.</param>
        /// <param name="e">Defaults about the click event.</param>
        private void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            if (!Frame.Navigate(typeof(ItemPage), itemId))
            {
                throw new Exception(this.resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
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
        /// <param name="e">Event data that describes how this page was reached.</param>

        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
<<<<<<< HEAD
=======
        }

         void RefreshData()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            string value = Convert.ToString(localSettings.Values["exampleSetting"]);
            var dialog = new MessageDialog(value).ShowAsync();
>>>>>>> 91b576bcfc924834afa37d191ae0b5fc4ee6f832
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        //private void log(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(Login));
        //}

        //private void lapor(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(Lapor));
        //}

        private void komo_search(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(listDaerah));
        }

        //private void profil(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(userProfile));
        //}

        private void lapor_tap(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lapor));
        }

        private void profile_tap(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(userProfile));
        }

        private void about_tap(object sender, TappedRoutedEventArgs e)
        {
           Frame.Navigate(typeof(About));
        }

       

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                ((Frame)Window.Current.Content).BackStack.Clear();
            }

            if (NetworkInterface.GetIsNetworkAvailable())
            {
                //Obtain keys by registering your app on https://dev.twitter.com/apps
                var service = new TwitterService("SEuJKVyiLrpntSmX76mLLK5rV", "2oLc3FgsOC1heh6vyiKlBXDWKnLo2dO9UAgHDxgS6WPnwbh2Rq");
                service.AuthenticateWith("197426566-jB7G6TbKGPVHS84rQ2LezVyZp2WJxR5kabaR5sHN", "ntb1049lvRbdX0k5aZkxlWeEvbAZtZm35ekazZnlwBj05");

                //ScreenName is the profile name of the twitter user.
                service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { ScreenName = "PerumBULOG" }, (ts, rep) =>
                {
                    if (rep.StatusCode == HttpStatusCode.OK)
                    {
                        //bind
                        this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => { tweetList.ItemsSource = ts; } );
                    }
                });
            }
            else
            {

                var dialog = new MessageDialog ("Please check your internet connestion.").ShowAsync();
                
            }
        }

<<<<<<< HEAD
        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            response = new HttpResponseMessage();

            // if 'feedAddress' value changed the new URI must be tested --------------------------------
            // if the new 'feedAddress' doesn't work, 'feedStatus' informs the user about the incorrect input.

            feedStatus.Text = "Test if URI is valid";

            Uri resourceUri;
            if (!Uri.TryCreate(feedAddress.Trim(), UriKind.Absolute, out resourceUri))
            {
                feedStatus.Text = "Invalid URI, please re-enter a valid URI";
                return;
            }
            if (resourceUri.Scheme != "http" && resourceUri.Scheme != "https")
            {
                feedStatus.Text = "Only 'http' and 'https' schemes supported. Please re-enter URI";
                return;
            }
            // ---------- end of test---------------------------------------------------------------------

            string responseText;
            feedStatus.Text = "Waiting for response ...";

            try
            {
                response = await httpClient.GetAsync(resourceUri);

                response.EnsureSuccessStatusCode();

                responseText = await response.Content.ReadAsStringAsync();
                statusPanel.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            catch (Exception ex)
            {
                // Need to convert int HResult to hex string
                feedStatus.Text = "Error = " + ex.HResult.ToString("X") +
                    "  Message: " + ex.Message;
                responseText = "";
            }
            feedStatus.Text = response.StatusCode + " " + response.ReasonPhrase;

            // now 'responseText' contains the feed as a verified text.
            // next 'responseText' is converted as the rssItems class model definition to be displayed as a list

            List<rssItems> lstData = new List<rssItems>();
            XElement _xml = XElement.Parse(responseText);
            foreach (XElement value in _xml.Elements("channel").Elements("item"))
            {
                rssItems _item = new rssItems();

                _item.Title = value.Element("title").Value;

                _item.Description = value.Element("description").Value;

                _item.Link = value.Element("link").Value;

                _item.Category = value.Element("category").Value;

                lstData.Add(_item);


            }

            // lstRSS is bound to the lstData: the final result of the RSS parsing
            lstRSS.DataContext = lstData;

        }

        private void lstRSS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // if item clicked navigate to the webpage

            var selected = lstRSS.SelectedItem as rssItems;

            WebView webBrowserTask = new WebView();
            Uri targetUri = new Uri(selected.Link);

            //webbrowser task launcher for Windows 8.1
            //http://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh701480.aspx
            //var success = await 
            Windows.System.Launcher.LaunchUriAsync(targetUri);
=======
        private void button_Click(object sender, RoutedEventArgs e)
        {
            RefreshData();
>>>>>>> 91b576bcfc924834afa37d191ae0b5fc4ee6f832
        }
    }
}