﻿using Swagger.Net.Annotations;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    public class SvgImageController : ApiController
    {
        [SwaggerResponse(200, "image.svg", mediaType: "image/svg")]
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(
                "<svg><circle cx='50' cy='50' r='40' fill='red' /></svg>",
                Encoding.UTF8, "text/html"
            );
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/svg");
            return response;
        }
    }
}
