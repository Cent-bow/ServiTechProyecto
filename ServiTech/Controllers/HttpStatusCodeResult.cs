using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ServiTech.Controllers
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private HttpStatusCode badRequest;

        public HttpStatusCodeResult(HttpStatusCode badRequest)
        {
            this.badRequest = badRequest;
        }
    }
}