using System;

namespace Extractisor.Models
{
    public class Review
    {
        public string ReviewerFullName { get; set; }
        public string ReviewerProfileUrl { get; set; }
        public string ReviewerAvatarUrl { get; set; }
        public string ReviewerCity { get; set; }
        public string ReviewerCountry { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime DateOfExperience { get; set; }
        public string Link { get; set; }
    }

}

