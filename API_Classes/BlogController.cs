using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Blog_Application.Business_Layer;
using static Blog_Application.Models.Blog_Domain;

namespace Blog_Application.Controllers
{
    public class BlogController : ApiController
    {
        #region variable Declaration
        IBlogService _blogService;
        #endregion
        #region Add new Blog
        [HttpPost]
        public IHttpActionResult SaveBlogDetail(SaveBlog_Req _Req)
        {
            var _response = _blogService.SaveBlogDetail(_Req);
            return Ok(_response);
        }
        #endregion
        #region Get Blog Detail data
        [HttpGet]
        public IHttpActionResult GetBlogDetail(GetBlogDetail_Req _Req)
        {
            GetBlogDetail_Res _Response = new GetBlogDetail_Res();
            var _response = _blogService.GetBlogDetail(_Req);
            return Ok(_response);
        }

        #endregion
        #region Delete a Blog
        [HttpDelete]
        public IHttpActionResult DeleteBlogDetail(DeleteBlog_Req _Req)
        {
            var _response = _blogService.DeleteBlogDetail(_Req);
            return Ok(_response);
        }
        #endregion
        #region List All  Blogs
        [HttpGet]
        public IHttpActionResult ShowAllBlogs(ShowAllBlog_Req _Req)
        {
            ShowAllBlog_Res _response = new ShowAllBlog_Res();
            _response = _blogService.ShowAllBlogs(_Req);
            return Ok(_response);
        }
        #endregion
    }
}
