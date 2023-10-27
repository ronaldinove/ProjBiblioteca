#pragma checksum "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d557f8410bbd70ce52b190e946e0e8f22407cc05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d557f8410bbd70ce52b190e946e0e8f22407cc05", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Lista de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""row justify-content-md-center"">Usuários Cadastrados no Sistema</h1>


<div class=""row justify-content-md-center"">
    <div class=""col-md-12"">
        <table class=""table table-striped""> 

                <thead>
                    <tr><th>Id</th>
                    <th scope=""row"">Nome</th>
                    <th scope=""row"">Login</th>
                    <th scope=""row"">Tipo</th>
                    </tr>
                </thead>
                <tbody>
        

");
#nullable restore
#line 22 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                     foreach(Usuario u in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n");
#nullable restore
#line 29 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                             if(@u.Tipo ==Usuario.ADMIN)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Administrador</td>\r\n");
#nullable restore
#line 32 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Padrão</td>\r\n");
#nullable restore
#line 35 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1211, 2);
            WriteAttributeValue("", 1179, "/Usuario/EditarUsuario/?Id=", 1179, 27, true);
#nullable restore
#line 37 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1206, u.Id, 1206, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1296, 2);
            WriteAttributeValue("", 1273, "ExcluirUsuario?Id=", 1273, 18, true);
#nullable restore
#line 39 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1291, u.Id, 1291, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Usuario\Desktop\TI\Documentar e testar\Biblioteca - Carlos\Biblioteca\Views\Usuario\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n             \r\n                     \r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591