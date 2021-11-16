using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        private readonly string[] _prefixos;

        public WebApplication(string[] prefixos)
        {
            _prefixos = prefixos ?? throw new ArgumentNullException(nameof(prefixos));
        }

        public void Start()
        {
            while(true)
                ManipularRequisicao();
        }

        private void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach(var prefixo in _prefixos)
                httpListener.Prefixes.Add(prefixo);

            httpListener.Start();

            var context = httpListener.GetContext();
            var request = context.Request;
            var response = context.Response;

            var path = request.Url.AbsolutePath;

            if(path == "/Assets/css/styles.css")
            {
                var assembly = Assembly.GetExecutingAssembly();
                var nameResource = "MyBank.Portal.Assets.css.styles.css";

                var resourceStream = assembly.GetManifestResourceStream(nameResource);
                var bytesResource = new byte[resourceStream.Length];

                resourceStream.Read(bytesResource, 0, ( int )resourceStream.Length);

                response.ContentType = "text/css; charset=utf-8";
                response.StatusCode = 200;
                response.ContentLength64 = resourceStream.Length;

                response.OutputStream.Write(bytesResource, 0, bytesResource.Length);

                response.OutputStream.Close();
            }
            else if(path == "/Assets/js/main.js")
            {
                var assembly = Assembly.GetExecutingAssembly();
                var nameResource = "MyBank.Portal.Assets.js.main.js";

                var resourceStream = assembly.GetManifestResourceStream(nameResource);
                var bytesResource = new byte[resourceStream.Length];

                resourceStream.Read(bytesResource, 0, ( int )resourceStream.Length);

                response.ContentType = "application/js; charset=utf-8";
                response.StatusCode = 200;
                response.ContentLength64 = resourceStream.Length;

                response.OutputStream.Write(bytesResource, 0, bytesResource.Length);

                response.OutputStream.Close();
            }

            httpListener.Close();
        }
    }
}
