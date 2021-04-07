using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.Login
{
    public class LoginDto
    {
        public Guid Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
