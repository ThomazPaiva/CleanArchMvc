using CleanArchMvcDomain.Validation;

namespace CleanArchMvcDomain.Entities
{
    public sealed class Category : EntityBase
    {
        public string Name { get; set; }

        public Category(string name)
        {
            ValidateDomain(name);

            Name = name;
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            ValidateDomain(name);

            Id = id;
        }

        public void Update(string name)
        {
            ValidateDomain(name);

        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name. Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid Name. Minimum 3 characters");

            Name = name;
        }
        public List<Product> Products { get; set; }
    }
}
