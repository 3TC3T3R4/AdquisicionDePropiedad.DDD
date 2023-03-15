using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto
{
    public class Email
    {

        public string EmailFinal { get; init; }


        public Email(string email)
        {

           
            EmailFinal = email;

        }

        public static Email Crear(string email)
        {

            validar(email);

            return new Email(email);

        }


        public static void validar(string email)
        {

            if (email == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }


    }
}
