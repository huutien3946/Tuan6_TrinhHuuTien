using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tuan6_TrinhHuuTien.Models;

namespace Tuan6_TrinhHuuTien.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{ Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName =
                "Nguyễn Nhật Ánh", Price = 1, Content = "Truyện kể về tuổi thơ..." },
            new Sach{ Id = 2, Title = "Pro ASP.NET MVC", AuthorName =
                "Adam Freeman", Price = 3.75M, Content = "The ASP.NET Framwork is the latest evolution of Microsoft's" +
                " ASP.NET web platform" },
            new Sach{ Id = 3, Title = "Khi bạn đang mơ thì người khác đang nổ lực", AuthorName =
                "Vĩ Nhân", Price = 3M, Content = "Cuốn sách dành cho các bạn trẻ đang ấp ủ bao ước mơ hoài bảo..." },
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }

    }
}
