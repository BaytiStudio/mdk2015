using Qomo_Hack.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

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
using Windows.UI.Popups;

using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using TweetSharp;
using Windows.Web.Http;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Qomo_Hack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lapor : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        public TwitterService service { get; set; }
        public Lapor()
        {
            this.InitializeComponent();

            //TwitterService tweetservice = new TwitterService("SEuJKVyiLrpntSmX76mLLK5rV", "2oLc3FgsOC1heh6vyiKlBXDWKnLo2dO9UAgHDxgS6WPnwbh2Rq");
            
            TwitterService service = new TwitterService("SEuJKVyiLrpntSmX76mLLK5rV", "2oLc3FgsOC1heh6vyiKlBXDWKnLo2dO9UAgHDxgS6WPnwbh2Rq");
            service.AuthenticateWith("197426566-jB7G6TbKGPVHS84rQ2LezVyZp2WJxR5kabaR5sHN", "ntb1049lvRbdX0k5aZkxlWeEvbAZtZm35ekazZnlwBj05");
            //TwitterStatus result = service.SendTweet(new SendTweetOptions
            //{
            //    Status = "Hello, world!"
            //});

            //TwitterClientInfo twitterClientInfo = new TwitterClientInfo();
            //twitterClientInfo.ConsumerKey = "SEuJKVyiLrpntSmX76mLLK5rV"; 
            //twitterClientInfo.ConsumerSecret = "2oLc3FgsOC1heh6vyiKlBXDWKnLo2dO9UAgHDxgS6WPnwbh2Rq";

            //TwitterService twitterService = new TwitterService(twitterClientInfo);

            //if (string.IsNullOrEmpty("197426566-jB7G6TbKGPVHS84rQ2LezVyZp2WJxR5kabaR5sHN") || string.IsNullOrEmpty("ntb1049lvRbdX0k5aZkxlWeEvbAZtZm35ekazZnlwBj05"))
            //{
            //    //Now we need the Token and TokenSecret

            //    //Firstly we need the RequestToken and the AuthorisationUrl
            //    OAuthRequestToken requestToken = twitterService.GetRequestToken();
            //    string authUrl = twitterService.GetAuthorizationUri(requestToken).ToString();

            //    //authUrl is just a URL we can open IE and paste it in if we want
            //    var dialog = new MessageDialog("Please Allow This App to send Tweets on your behalf").ShowAsync();
            //    //Process.Start(authUrl); //Launches a browser that'll go to the AuthUrl.

            //    //Allow the App
            //    //Console.WriteLine("Enter the PIN from the Browser:");
            //    //string pin = Console.ReadLine();

            //    OAuthAccessToken accessToken = twitterService.GetAccessToken(requestToken, pin);

            //    string token = accessToken.Token; //Attach the Debugger and put a break point here
            //    string tokenSecret = accessToken.TokenSecret; //And another Breakpoint here

            //    Console.WriteLine("Write Down The AccessToken: " + token);
            //    Console.WriteLine("Write Down the AccessTokenSecret: " + tokenSecret);
            //}

            //twitterService.AuthenticateWith(AccessToken, AccessTokenSecret);

            //Console.WriteLine("Enter a Tweet");
            //string tweetMessage;
            //tweetMessage = Console.ReadLine();
            //TwitterStatus twitterStatus = twitterService.SendTweet(tweetMessage);


            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        private  void signin(object sender, Windows.UI.Xaml.RoutedEventArgs args)
        {
            //OAuthRequestToken requestToken = service.GetRequestToken();

            //await service.GainAccessToTwitter();
            //_statusTextBlock.Text = service.Status;
        }

        //private async void tweet_click(object sender, Windows.UI.Xaml.RoutedEventArgs args)
        //{
        //    //await service.("Hello From TwitterRt " + DateTime.Now);
        //    //_statusTextBlock.Text = service.Status;
        //}

        //public TwitterService service { get; private set; }
        

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

        private async void tweet_click(object sender, RoutedEventArgs e)
        {
            //SendTweetOptions options = new SendTweetOptions();
            //options.Status = "This is the message I want to Tweet";
            ////var twitterStatus = service.SendTweet(text);
            //var responseText = service.Response.Response;
            //service.SendTweet(options);
            
            Uri uri = new Uri("http://antakusuma.hol.es/db/lapor.php", UriKind.Absolute);
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("jenis_komoditas", jenis_kom.Text);
            pairs.Add("harga", hrg_kom.Text);
            //pairs.Add("sUsername", email.Text);
            //pairs.Add("sPassword", password.Password.ToString());
            HttpFormUrlEncodedContent formContent =
                new HttpFormUrlEncodedContent(pairs);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(uri, formContent);
            
            //TwitterStatus result = service.SendTweet(new SendTweetOptions
            //{
            //    Status = "Hello, world!"
            //});
        }

        private void sms_click(object sender, RoutedEventArgs e)
        {

        }

        private void getLoc(object sender, TappedRoutedEventArgs e)
        {

        }

        private void komoditas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        string pilihan;
        private void pilihan_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == produsen)
            {
                pilihan = "produsen";
            }
            else if ( sender == distributor)
            {
                pilihan = "distributor";
            }
            else
            {
                pilihan = "konsumen";
            }
        }

        //async Task<string> GetAddressFromCoordinatesAsync(Geoposition geoposition)
        //{
        //    var mapLocationFinderResult = await MapLocationFinder.FindLocationsAtAsync(geoposition.Coordinate.Point);
        //    if (mapLocationFinderResult.Status == MapLocationFinderStatus.Success)
        //    {
        //        // hard-coding to only view the first returned possible address ([0]). You might get more than one result, in which case check them against your requirements.
        //        return mapLocationFinderResult.Locations[0].Address.StreetNumber + " " + mapLocationFinderResult.Locations[0].Address.Street;
        //    }

        //    return "not found";
        //}
    }
}
