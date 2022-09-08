using System;
using System.Collections.Generic;
using System.Text;

namespace Aula155ExercicioProposto.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
