namespace ByteBank.Exceptions
{
    public class ClienteException : Exception
    {
        public ClienteException(string error) : base(error)
        {

        }

        public static void When(bool thisError, string error)
        {
            if (thisError)
            {
                throw new ClienteException(error);
            }
        }
    }
}
