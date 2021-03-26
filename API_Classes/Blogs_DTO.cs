using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Application.Models
{
    public class Blogs_DTO
    {
        public class Author
        {
            public int AuthorId { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string CreatedDate { get; set; }
            public string Intro { get; set; }
            public string Profile { get; set; }

        }
        public class BlogDetail
        {
            public int BlogId { get; set; }
            public int AuthorId { get; set; }
            public string ParentPostId { get; set; }
            public string Title { get; set; }
            public string Summary { get; set; }
            public string CreatedDate { get; set; }
            public int CreatedBy { get; set; }
            public string ModifiedDate { get; set; }
            public int ModifiedBy { get; set; }
            public string Content { get; set; }
        }
        public class BlogComments
        {

            public int CommentId { get; set; }
            public int BlogId { get; set; }
            public string Title { get; set; }
            public string CreatedDate { get; set; }
            public string Content { get; set; }
        }

    }
}