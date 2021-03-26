using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Blog_Application.Models.Blog_Domain;

namespace Blog_Application.DataLayer
{
    public class BlogData
    {

        #region Add new Blog

        public int SaveBlogDetail(SaveBlog_Req _Req)
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@BlogId", _Req.blogDetail.BlogId);
            p[1] = new SqlParameter("@Content", _Req.blogDetail.Content);
            p[2] = new SqlParameter("@AuthorId", _Req.blogDetail.AuthorId);
            p[3] = new SqlParameter("@ParentPostId", _Req.blogDetail.ParentPostId);
            p[4] = new SqlParameter("@Title", _Req.blogDetail.Title);
            p[5] = new SqlParameter("@Summary", _Req.blogDetail.Summary);
            p[6] = new SqlParameter("@CreatedDate", _Req.blogDetail.CreatedDate);
            p[7] = new SqlParameter("@CreatedBy", _Req.blogDetail.CreatedBy);
            p[8] = new SqlParameter("@ModifiedDate", _Req.blogDetail.ModifiedDate);
            p[9] = new SqlParameter("@ModifiedBy", _Req.blogDetail.ModifiedBy);

            int res = SQLHelper.ExecuteNonquery(SQLHelper.conection, CommandType.StoredProcedure, "SP_SaveBlogDetail", p);
            return res;
        }
        #endregion
        #region Get Blog Detail data
       public GetBlogDetail_Res GetBlogDetail(GetBlogDetail_Req _Req)
        {
            GetBlogDetail_Res _Response = new GetBlogDetail_Res();

            return _Response;
        }

        #endregion
        #region Delete a Blog

        public int DeleteBlogDetail(DeleteBlog_Req _Req)
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@BlogId", _Req.BlogId);
            p[1] = new SqlParameter("@AuthorId", _Req.AuthorId);
            int res = SQLHelper.ExecuteNonquery(SQLHelper.conection, CommandType.StoredProcedure, "SP_DeleteBlog", p);
            return res;
        }
        #endregion
        #region List All  Blogs

        public ShowAllBlog_Res ShowAllBlogs(ShowAllBlog_Req _Req)
        {
            ShowAllBlog_Res _response = new ShowAllBlog_Res();
            return _response;
        }
        #endregion
    }
}