#pragma checksum "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef8e5155eb6565dec7d1d2410188e62ba9f8fe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef8e5155eb6565dec7d1d2410188e62ba9f8fe7", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Produto -> Visualizar</h3>\r\n\r\nRAZOR:\r\n<br/>\r\n");
#nullable restore
#line 7 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
   
    string nome = "Bruno Costa"; //Codigo c# pode ser usado dentro do Razor com chaves

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Sem as chaves o razor pode ser usado para escrever-->\r\n<br/>\r\n<h3>Produto: </h3>\r\n\r\n<b>ID: </b>");
#nullable restore
#line 15 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<b>Nome: </b>");
#nullable restore
#line 16 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<b>Descricao: </b>");
#nullable restore
#line 17 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<b>Valor: </b>");
#nullable restore
#line 18 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br/>\r\nTodos os direitos reservados &copy; ");
#nullable restore
#line 21 "D:\GitHub\AspNetCoreMVCLojaVirtual\Seção 07\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
