using POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Models.Usuario> ListaUsu = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        void CargarUsuarios()
        {
            Usuario obj1 = new Usuario();
            obj1.usuario = "CIBER";
            obj1.clave = "T4CM2021";

            // agregar los elementos a la lista
            ListaUsu.Add(obj1);

        public ActionResult UsuariosListado()
        {
            // si es la 1ra vez que se llama a este actionresult, entonces
            // cargamos los productos
            if (ListaUsu.Count == 0)
            {
                    // poblando a ListaProd
                    CargarUsuarios();
            }
            // enviar los datos del modelo Productos que se encuentra en
            // "ListaProd" a su vista
            return View(ListaUsu);
        }

    }
}