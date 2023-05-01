namespace CleanArchMvcDomain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {}

        public static void When(bool hasError, string error)
        {
            if (hasError == true)
            {
                throw new DomainExceptionValidation(error);
            }
        }
    }
}
