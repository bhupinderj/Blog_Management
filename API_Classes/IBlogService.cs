using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Blog_Application.Models.Blog_Domain;

namespace Blog_Application.Business_Layer
{
    interface IBlogService
    {
        GetBlogDetail_Res GetBlogDetail(GetBlogDetail_Req _Req);
        int SaveBlogDetail(SaveBlog_Req _Req);
        int DeleteBlogDetail(DeleteBlog_Req _Req);
        ShowAllBlog_Res ShowAllBlogs(ShowAllBlog_Req _Req);
    }
}
