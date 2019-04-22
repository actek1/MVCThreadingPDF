using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandlebarsDotNet;
using IronPdf;

namespace MVCThreading.Libraries.BusinessRules.PDF
{
    public class PDFCreator
    {
        // Render any HTML fragment or document to HTML
        IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();


        public PDFCreator()
        {

        }

        public void getPDF()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            //var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            var PDF = Renderer.RenderHTMLFileAsPdf(path + "HTMLTemplate.html");
            var OutputPath = @"C:\Users\Actek\Documents\test\HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);
            // This neat trick opens our PDF file so we can see the result in our default PDF viewer
            //System.Diagnostics.Process.Start(OutputPath);
        }

        public void getMultiPDF()
        {
            var HtmlTemplate = "<p>[[NAME]]</p>";
            var Names = new[] { "John", "James", "Jenny" };
            foreach (var name in Names)
            {
                var HtmlInstance = HtmlTemplate.Replace("[[NAME]]", name);
                var Pdf = Renderer.RenderHtmlAsPdf(HtmlInstance);
                Pdf.SaveAs(name + ".pdf");
            }
        }

        public void getHandlerPDF()
        {
            string source =
                @"<div class=""entry"">
                  <h1>{{title}}</h1>
                  <div class=""body"">
                    {{body}}
                  </div>
                  <div class=""body"">
                    {{#each multi}}
                         <p>{{mBody}}</p>
                     {{/each}}
                  </div>
                </div>";

            var template = Handlebars.Compile(source);

            myHtml data = new myHtml
            {
                title = "My new post",
                body = "This is my first post!",
                multi = new List<mybody> { new mybody() { mBody = "A-sadsadsdadasd"}, new mybody() { mBody = "B-sadasdasdasd"} }
            };
            var HtmlInstance = template(data);

            var OutputPath = @"C:\Users\Actek\Documents\test\HandlerBars.pdf";
            Renderer.RenderHtmlAsPdf(HtmlInstance).SaveAs(OutputPath);
        }
    }

    public class myHtml
      {
        public string title { get; set; }
        public string body { get; set; }
        public List<mybody> multi { get; set; }
    }

    public class mybody
    {
        public string mBody { get; set; }
    }
}
