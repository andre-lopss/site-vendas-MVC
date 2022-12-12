using System;

namespace SiteDeVendasMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException (string message) : base(message)
        {

        }
    }
}
