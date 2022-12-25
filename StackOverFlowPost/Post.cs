using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    internal class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime Date { get; set; } = DateTime.Now;
        private int votes { get; set; }

        public Post(string title, string description)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
                throw new Exception("There's no post to be created.");

            this.Title = title;
            this.Description = description;
        }

        public string ShowPost()
        {
            return $"Title : {this.Title}\n" +
                $"Post: {this.Description}.\n" +
                $"Date Created: {this.Date}. \n" +
                $"Number of Votes: {GetVotes()}";
        }
        public void VotesUp()
        {
            votes++;
        }

        public void VotesDown()
        {
            votes--;
        }

        public int GetVotes()
        {
            return votes;
        }
    }
}
