using CleanArchMvcDomain.Validation;

namespace CleanArchMvcDomain.Entities
{
    public sealed class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);

        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;

            ValidateDomain(name, description, price, stock, image);

        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalida name. Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid Name. Minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalida description. description is required");

            DomainExceptionValidation.When(description.Length < 5, "Invalid description. Minimum 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price. Minimum 1 characters");

            DomainExceptionValidation.When(stock < 0, "Invalid stock. Minimum 1 characters");

            DomainExceptionValidation.When(image.Length > 250, "Invalid image name. Maximum 250 characters");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
