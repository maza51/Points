#pragma checksum "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4abfcf28df58493492a2ca36432aff2110400def"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Point_Index), @"mvc.1.0.view", @"/Views/Point/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/_ViewImports.cshtml"
using Points.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/_ViewImports.cshtml"
using Points.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
using Points.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4abfcf28df58493492a2ca36432aff2110400def", @"/Views/Point/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c959ae5bc352400da78977afc3004d114ffe84ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Point_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Point>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Point", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#FFD700", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#FF4500", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#FFFFFF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def6635", async() => {
                WriteLiteral("\n    <title>title</title>\n    <script src=\"https://unpkg.com/konva@8/konva.min.js\"></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def7679", async() => {
                WriteLiteral("\n<div>\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def7942", async() => {
                    WriteLiteral("Создать точку");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n  <hr/>\n  \n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def9463", async() => {
                    WriteLiteral("\n    <p><label>Добавить коментарий к точке id:</label>\n      <select name=\"id\">\n");
#nullable restore
#line 22 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
         foreach (Point point in Model)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def10067", async() => {
#nullable restore
#line 24 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                               Write(point.Id);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
             WriteLiteral(point.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n");
#nullable restore
#line 25 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("      </select>\n    </p>\n    <p>\n      <label>Комментарий:</label>\n      <input type=\"text\" name=\"comment\"/>\n    </p>\n    <p>\n      <label>Цвет</label>\n        <select name=\"color\">\n          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def12367", async() => {
                        WriteLiteral("Желтый");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def13647", async() => {
                        WriteLiteral("Красный");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4abfcf28df58493492a2ca36432aff2110400def14928", async() => {
                        WriteLiteral("Белый");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        </select>\n    </p>\n    <input type=\"submit\" value=\"Отправить\">\n  ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n  <script type=\"text/javascript\">\n    \n      window.onload = function() {\n      var stage = new Konva.Stage({\n        container: \'container\',\n        width: window.innerWidth,\n        height: window.innerHeight,\n      });\n        \n");
#nullable restore
#line 52 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
       foreach (Point point in Model)
      {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n          \n          var layer = new PointLayer(");
#nullable restore
#line 56 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                                Write(point.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\n            ");
#nullable restore
#line 57 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
       Write(point.PositionX);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\n            ");
#nullable restore
#line 58 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
       Write(point.PositionY);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\n            ");
#nullable restore
#line 59 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
       Write(point.Radius);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\n            \'");
#nullable restore
#line 60 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
        Write(point.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').getLayer();\n          \n");
#nullable restore
#line 62 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
           for (int i = 0; i < point.Comments.Count(); i++)
          {
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            \n            var comment = new Konva.Text({\n              x: 0,\n              y: 20 + ");
#nullable restore
#line 68 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                 Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" * 30,\n              text: \'");
#nullable restore
#line 69 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                Write(point.Comments[@i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\n              fontSize: 20,\n              fontFamily: \'Calibri\',\n              fill: \'");
#nullable restore
#line 72 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                Write(point.Comments[@i].BackgroundColor);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' === '#FFFFFF' ? '#000000' : '#FFFFFF',
              contentEditable: true
            });
          
            var rect = new Konva.Rect({
              x: comment.x() - 2,
              y: comment.y() - 2,
              stroke: '#555',
              strokeWidth: 2,
              fill: '");
#nullable restore
#line 81 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                Write(point.Comments[@i].BackgroundColor);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\n              width: comment.width() + 4,\n              height: comment.height() + 4,\n              cornerRadius: 2,\n            });\n            \n            layer.add(rect);\n            layer.add(comment);\n            \n            ");
#nullable restore
#line 90 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                   
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("          \n          stage.add(layer);\n          \n          ");
#nullable restore
#line 95 "/Users/admin/Documents/Projects/AspNetCore/Points/Points.Web/Views/Point/Index.cshtml"
                 
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    }
    
    class Comment {
    
      }
    
    class PointLayer {
      posX;
      posY;
      radius;
      color;
      id;
      
      #layer;
      #circle;
      
      constructor(id, posX, posY, radius, color) {
        this.id = id;
        this.posX = posX;
        this.posY = posY;
        this.radius = radius;
        this.color = color;
      }
      
      getLayer() {
        this.#layer = new Konva.Layer({
          draggable: true,
          x: this.posX,
          y: this.posY,
          id: this.id,
        });
                  
        this.#circle = new Konva.Circle({
          name: 'circle',
          radius: this.radius,
          fill: this.color,
          stroke: 'black',
          strokeWidth: 4,
        });
                        
        this.#layer.on('dragend', () => {
          this.SaveInDb();
        });
        this.#circle.on('click', () => {
          let tmpColor = getRandomColor();
          this.#circle.setFill(tmpColor);
          this.SaveInDb();
        });");
                WriteLiteral(@"
        this.#circle.on('dblclick', () => {
          this.#layer.setX(-100);
          this.#layer.setY(-100);
          this.SaveInDb();
        });
        
        this.#layer.add(this.#circle);
        return this.#layer;
      }
      
      SaveInDb() {
        let point = {
          positionX: this.#layer.x(),
          positionY: this.#layer.y(),
          id: this.#layer.id(),
          radius: this.#circle.radius(),
          color: this.#circle.fill()
        }
              
        fetch(""https://"" + document.location.host + '/api/point', {
          method: ""PUT"",
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(point)
        });
      }
    }
    
    function getRandomColor() {
      let letters = '0123456789ABCDEF';
      let color = '#';
      for (let i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
      }
      return color;
    }
    </script>
    
    <div id=""container""></div>
</div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Point>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
