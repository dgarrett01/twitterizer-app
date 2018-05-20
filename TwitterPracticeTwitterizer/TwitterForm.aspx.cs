using System;
using Tweetinvi;
using System.Windows.Forms;

namespace TwitterPracticeTwitterizer
{
    public partial class TwitterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnTweet_Click(object sender, EventArgs e)
        {
            // Private key information from Twitter required in order to post to your account
            string ConsumerKey = "*********";
            string ConsumerSecret = "*******************************";
            string Token = "**********************************";
            string TokenSecret = "***********************************";

            // Set up your credentials (https://apps.twitter.com)
            Auth.SetUserCredentials(ConsumerKey, ConsumerSecret, Token, TokenSecret);

            // Publish the Tweet "Hello World" on your Timeline
            Tweet.PublishTweet(tbTweet.Text.ToString());
        }

        protected void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}