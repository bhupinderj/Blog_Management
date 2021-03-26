using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog_Application.DataLayer;
using static Blog_Application.Models.Blog_Domain;

namespace Blog_Application.Business_Layer
{
    public class BlogService: IBlogService
    {
        BlogData _blogData;
        #region Add new Blog

        int IBlogService.SaveBlogDetail(SaveBlog_Req _Req)
        {
            return _blogData.SaveBlogDetail(_Req);
        }
        #endregion
        #region Get Blog Detail data
        GetBlogDetail_Res IBlogService.GetBlogDetail(GetBlogDetail_Req _Req)
        {
            GetBlogDetail_Res _Response = new GetBlogDetail_Res();
            _Response = _blogData.GetBlogDetail(_Req);
            return _Response;
        }

        #endregion
        #region Delete a Blog

        int IBlogService.DeleteBlogDetail(DeleteBlog_Req _Req)
        {
            return _blogData.DeleteBlogDetail(_Req);
        }
        #endregion
        #region List All  Blogs

        ShowAllBlog_Res IBlogService.ShowAllBlogs(ShowAllBlog_Req _Req)
        {
            ShowAllBlog_Res _response = new ShowAllBlog_Res();
            _response= _blogData.ShowAllBlogs(_Req);
            return _response;
        }
        #endregion
    }
}