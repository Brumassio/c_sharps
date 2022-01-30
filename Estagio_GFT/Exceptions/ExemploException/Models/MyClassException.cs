using System.Runtime.Serialization;

namespace ExemploException.Models
{
    [Serializable]
    public class MyClassException : Exception
    {
        public MyClassException()
        {
        }

        public MyClassException(string? message) : base(message)
        {
        }

        public MyClassException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string? MyProperty {get; set;}
    }
}