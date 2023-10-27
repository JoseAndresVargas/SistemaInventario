using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Utilidades
{
    public class ErrorDescriber :IdentityErrorDescriber

    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = nameof(ErrorDescriber.PasswordRequiresLower),
                Description = "Tiene que tener al menos una minúscula"
            };
        }

    }
}
