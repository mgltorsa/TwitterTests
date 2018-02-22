using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using System.IO;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using System.Threading;

namespace TwitterCase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeCredentials();
        }

        private void InitializeCredentials()
        {
            StreamReader reader = new StreamReader(KEY_PATH);
            string stringFile = reader.ReadToEnd();
            string[] keys = stringFile.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            Auth.SetUserCredentials(Decrypt(keys[0]), Decrypt(keys[1]), Decrypt(keys[2]), Decrypt(keys[3]));

            var user = User.GetAuthenticatedUser();

            reader.Close();

        }

        public void ListeningToTwitter(string track)
        {
            var stream = Tweetinvi.Stream.CreateFilteredStream();
            stream.AddTrack(track);

            stream.AddTweetLanguageFilter(LanguageFilter.Spanish);

            stream.MatchingTweetReceived += (sender, arg) =>
            {
                MessageBox.Show("New Tweet: " + arg.Tweet.Text);
            };
            stream.StartStreamMatchingAllConditions();
        }

        public void SearchTweets(string query)
        {

            ISearchResult ItwsearchResult = Search.SearchTweetsWithMetadata(query);
            IEnumerable<ITweetWithSearchMetadata> tweets = ItwsearchResult.Tweets;
            UpdateTweets(tweets);

        }

        private void UpdateTweets(IEnumerable<ITweetWithSearchMetadata> tweets)
        {
            if (tweets != null && tweets.Count() > 0)
            {
                currentTweets = tweets;

                ITweetWithSearchMetadata currentTweet = currentTweets.ElementAt(index = 0);
                UpdateCurrentTweet(currentTweet);
            }
            else
            {
                MessageBox.Show("No se encontraron Tweets");
            }
        }

        private void UpdateCurrentTweet(ITweetWithSearchMetadata tweet)
        {
            string tweetUser = tweet.CreatedBy != null ? tweet.CreatedBy.Name : "Unknown Author";
            string tweetText = tweet.FullText;
            string tweetPlace = tweet.Place != null ? tweet.Place.FullName : "Unknown Place";
            string retweetCount = tweet.RetweetCount + "";
            int length = tweet.CalculateLength(true);
            lbCharacterCount.Text = "Caracteres: " + length;
            tbTweet.Text = "Usuario:" + tweetUser + "\r\n" + tweetText + "\r\n" + "Lugar: " + tweetPlace + "\r\n" + "Retweets: " + retweetCount;

        }

        public void PublishTweet(string toTweet)
        {
            var tweet = Tweet.PublishTweet(toTweet);
        }

        private string Decrypt(string encryptString)
        {
            byte[] decrypted = Convert.FromBase64String(encryptString);
            string decryptString = Encoding.Unicode.GetString(decrypted);
            return decryptString.Trim();
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {

            Thread threadSearch = new Thread(ThreadSearchTweets());
            threadSearch.Start();
        }

        public ThreadStart ThreadSearchTweets()
        {
            return () => { SearchTweets(); };
        }
        public ThreadStart ThreadSearchTweets(string query)
        {
            return () => { SearchTweets(query); };
        }

        internal void SearchTweets()
        {
            string query = tbSearch.Text;
            if (String.IsNullOrEmpty(query))
            {
                tooltip.Show("Primero digite una palabra clave", tbSearch);
            }
            else
            {
                Thread threadSearch = new Thread(ThreadSearchTweets(query));
                threadSearch.Start();
                int i = 1;
                while (threadSearch.IsAlive)
                {
                    UpdateLoadLabel(i);
                    ++i;
                    Thread.Sleep(150);

                }
            }
        }

        private void UpdateLoadLabel(int load)
        {
            
            lock (this)
            {
                if ((load % 2) == 1) lbLoadTweets.Text = "Cargando.";
                else if ((load % 2) == 0) lbLoadTweets.Text += "Cargando..";
                else if ((load % 3) == 0) lbLoadTweets.Text += "Cargando...";
            }
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            ++index;
            if (index < currentTweets.ToArray().Length)
            {
                ITweetWithSearchMetadata currentTweet = currentTweets.ElementAt(index);
                UpdateCurrentTweet(currentTweet);
            }
            else
            {
                tooltip.SetToolTip(btNext, "Esta en el ultimo tweet");
            }

        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            --index;
            if (index >= 0)
            {
                ITweetWithSearchMetadata currentTweet = currentTweets.ElementAt(index);
                UpdateCurrentTweet(currentTweet);
            }
            else
            {
                tooltip.SetToolTip(btNext, "Esta en el primer tweet");
            }

        }
    }
}
