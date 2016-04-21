using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class RsvpController : ApiController
    {
        [HttpGet]
        public List<GuestResponse> GetAttendees()
        {
            return Repository.Responses.Where(x => x.WillAttend == true).ToList();
        }

        [HttpPost]
        public void HebeleHubele([FromBody] GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
            }
        }
    }
}
