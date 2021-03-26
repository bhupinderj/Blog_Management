using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Blog_Application.Models.Blogs_DTO;

namespace Blog_Application.Models
{
    public class Blog_Domain
    {
        #region Request/response class for Save Blog
        public class SaveBlog_Req
        {
            public BlogDetail blogDetail { get; set; }
        }
        #endregion

        #region Request/Response class for Get Blog Detail
        public class GetBlogDetail_Req
        {
            public int BlogId { get; set; }
            public int AuthorId { get; set; }
        }


        public class GetBlogDetail_Res
        {
            public BlogDetail saveBlogDetail { get; set; }
        }
        #endregion

        #region Request/response class for Delete a Blog
        public class DeleteBlog_Req
        {
            public int BlogId { get; set; }
            public int AuthorId { get; set; }
        }
        #endregion

        #region Request/Response class for Get All Blogs
        public class ShowAllBlog_Req
        {
            public int AuthorId { get; set; }
        }


        public class ShowAllBlog_Res
        {
            public List<BlogDetail> saveBlogDetail { get; set; }
        }
        #endregion
    }
}