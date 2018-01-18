using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoIOT.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string senha { get; set; }
        public string Permissoes { get; set; }

    }
}