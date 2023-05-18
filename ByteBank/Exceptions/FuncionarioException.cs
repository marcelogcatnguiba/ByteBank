namespace ByteBank.Exceptions
{
    public class FuncionarioException : Exception
    {
        public FuncionarioException(string error)
            : base(error)
        {

        }

        public static void When(bool thisError, string error)
        {
            if (thisError)
            {
                throw new FuncionarioException(error);
            }
        }
    }
}
