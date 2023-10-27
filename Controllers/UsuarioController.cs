using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
       public IActionResult Sair()
       {
        HttpContext.Session.Clear();
        return RedirectToAction("Login", "Home");
       }

       public IActionResult administrador()
       {
        return View();
       }

       public IActionResult Listagem()
       {
        Autenticacao.CheckLogin(this);
        Autenticacao.verificaSeUsuarioEAdmin(this);
        return View(new UsuarioService().Listar());
       }


       public IActionResult Cadastro()
       {
        Autenticacao.CheckLogin(this);
        Autenticacao.verificaSeUsuarioEAdmin(this);
        return View();
       }


       [HttpPost]

       public IActionResult Cadastro(Usuario novoUser)
       {
        novoUser.Senha = Criptografo.TextoCriptografado(novoUser.Senha);
        new UsuarioService().incluirUsuario(novoUser);

        return RedirectToAction("Listagem");
       }

        public IActionResult EditarUsuario(int id)
       {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            Usuario u = new UsuarioService().Listar(id);
            return View(u);
       }
        
        [HttpPost]
       public IActionResult EditarUsuario(Usuario user)
       {

        new UsuarioService().editarUsuario(user);
        
        return RedirectToAction("Listagem");
       }


       public IActionResult ExcluirUsuario(int id)
       {
        Autenticacao.CheckLogin(this);
        Autenticacao.verificaSeUsuarioEAdmin(this);
        
        new UsuarioService().excluirUsuario(id);
        return RedirectToAction("Listagem");
       }

    }
}
