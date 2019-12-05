using BoardData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BoardWebApplication.Controllers
{
    [EnableCors("http://localhost:4200","*","*")]
    public partial class UsersController : ApiController
    {
        BoardRepository boardRepo;
        public UsersController()
        {
            boardRepo = new BoardRepository();
        }

        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            DataTable dt = new DataTable();
            dt = boardRepo.GetAllUsers();

            //return dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return dt.AsEnumerable().Select(x => new User()
            {
                UserId = x.Field<int>("UserId"),
                UserName = x.Field<string>("UserName"),
                PhoneNumber = x.Field<string>("PhoneNumber")
            });


            ////return dt.AsEnumerable().SelectMany(x => new string[]
            ////{
            ////     x.Field<int>("UserId").ToString(),
            ////     x.Field<string>("UserName"),
            ////     x.Field<string>("PhoneNumber")
            ////}).ToArray();
        }

    }
}
