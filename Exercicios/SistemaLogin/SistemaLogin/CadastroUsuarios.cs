using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        {
            new Usuario(){ Nome = "Wilson", Senha = "289512" },
            new Usuario(){ Nome = "Andréa", Senha = "abc123" },
            new Usuario(){ Nome = "Giovanna", Senha = "123456" }
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }   
}
