using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using TweetSharp.Model;
using TweetSharp;
using System.IO;


namespace TwitterCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadKeysAndTokens();
        }

        private void LoadKeysAndTokens()
        {
            StreamReader reader = new StreamReader(KEYS_PATH);
            string fileString = reader.ReadToEnd();
            string[] keys = fileString.Split(new[] { "\n" },
            StringSplitOptions.RemoveEmptyEntries).ToArray();
            consumerKey = keys[0].Split(':')[1].Trim();
            consumerSecret = keys[1].Split(':')[1].Trim();
            tokenAccess = keys[2].Split(':')[1].Trim();
            tokenSecret = keys[3].Split(':')[1].Trim() ;


        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            var service = new TwitterService(consumerKey, consumerSecret);

            service.AuthenticateWith(tokenAccess, tokenSecret);
            string keyword = tbUser.Text;



            SearchOptions options = new SearchOptions { Q = "#" + keyword, Count = 20, Resulttype = TwitterSearchResultType.Mixed };

            TwitterSearchResult twitterSearchResult = service.Search(options);
            this.tweetEnum= twitterSearchResult.Statuses;
            

            RefreshTweetBox(tweetEnum);




        }

        private void SearchKeyWord()
        {
            string keyword = tbKeyWordk.Text;


            if (!String.IsNullOrEmpty(keyword))
            {
                var service = new TwitterService(consumerKey, consumerSecret);
                service.AuthenticateWith(tokenAccess, tokenSecret);

                string maxid = "1000000";
                tweetCount = 0;
                string count = "50";

                tweetEnum = SearchTweetsBySearchText(100, keyword, service);
                //SaveTweets(service, maxid, count, "Pride");
                
                RefreshTweetBox(tweetEnum);
                


            }
        }

        private void RefreshTweetBox(IEnumerable<TwitterStatus> enumerator)
        {
            if (index < enumerator.Count())
            {
                tbTweet.Text = tweetEnum.ElementAt(index).Text;
                index++;
            }
           

        }



        public List<TwitterStatus> SearchTweetsBySearchText(int intTotalRec, string keyword, TwitterService service)
        {
            List<TwitterStatus> lstTwitterStatusRet = new List<TwitterStatus>();
                      
            try
            {
                SearchOptions options = new SearchOptions { Q = "#" + keyword, Count = intTotalRec, Resulttype = TwitterSearchResultType.Mixed };

                var twitterSearchResult = service.Search(options);
                

                
                    lstTwitterStatusRet = ((List<TwitterStatus>)twitterSearchResult.Statuses);
                    foreach (TwitterStatus objTwitterStatus in lstTwitterStatusRet)
                    {
                        objTwitterStatus.CreatedDate = objTwitterStatus.CreatedDate.AddHours(-4);
                    }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }


           

            return lstTwitterStatusRet;

        }

        public void SaveTweets(TwitterService service, string maxid, string count, string keyword)
        {
            if (maxid != null)
            {
                SearchOptions options = new SearchOptions
                {
                    Q = keyword
                };
                TwitterSearchResult tweetsSearch = service.Search(options);
                List<TwitterStatus> resultList = new List<TwitterStatus>(tweetsSearch.Statuses);
                maxid = resultList.Last().IdStr;

                //SaveTweets(tweetsSearch);

                //RefreshTweetList(service, keyword, resultList, tweetsSearch, maxid, count);


            }
        }

        private void BtKeyWord_Click(object sender, EventArgs e)
        {
            SearchKeyWord();

        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            RefreshTweetBox(tweetEnum);
        }

        //private void RefreshTweetList(TwitterService service, string keyword, List<TwitterStatus> resultList, TwitterSearchResult tweetsSearch, string maxid, string count)
        //{
        //    while (maxid != null && tweetCount < Convert.ToInt32(count))
        //    {
        //        maxid = resultList.Last().IdStr;
        //        tweetsSearch = service.Search(new SearchOptions { Q = keyword, MaxId = Convert.ToInt64(maxid) });
        //        resultList = new List<TwitterStatus>(tweetsSearch.Statuses);
        //        foreach (var tweet in tweetsSearch.Statuses)
        //        {
        //            try
        //            {
        //                resultSearch.Add(new KeyValuePair<String, String>(tweet.Id.ToString(), tweet.Text));
        //                tweetCount++;
        //            }
        //            catch { }
        //        }
        //    }
        //}

        //private void SaveTweets(TwitterSearchResult tweetsSearch)
        //{
        //    foreach (var tweet in tweetsSearch.Statuses)
        //    {
        //        try
        //        {
        //            resultSearch.Add(new KeyValuePair<String, String>(tweet.Id.ToString(), tweet.Text));
        //            tweetCount++;
        //        }
        //        catch { }
        //    }
        //}
    }
}
