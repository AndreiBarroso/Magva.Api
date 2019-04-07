using System;
namespace Magva.Infra.Crosscutting.CustomExceptions
{
    public class HandlerException : Exception
    {
        public HandlerException(string message)
            : base(message)
        {
          
        }
 
    }
}
