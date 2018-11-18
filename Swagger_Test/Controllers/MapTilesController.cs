﻿//using Swagger.Net.Annotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    [RoutePrefix("MapTiles")]
    public class MapTilesController : ImageBaseController
    {
        [Route("{z}/{x}/{y}")]
        //[SwaggerResponse(200, mediaType: "image/png")]
        public HttpResponseMessage Get(int z, int x, int y)
        {
            var response = new HttpResponseMessage();
            var color = Color.FromArgb(80, 100 + z*4, x%250, y%250);
            response.Content = ImageStream(color, color, 256, 256);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            return response;
        }
    }
}
