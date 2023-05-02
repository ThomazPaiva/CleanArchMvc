using CleanArchMvcDomain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid Parameters")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9, 99, "Product Image");

            action.Should().NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Negative ID")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9, 99, "Product Image");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_InvalidName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "", "Product Description", 9, 99, "Product Image");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
        }

        [Fact(DisplayName = "Create Product With Name Length Less Than 3 characters")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_InvalidNameLength_DomainExceptionInvalidNameLength()
        {
            Action action = () => new Product(1, "PR", "Product Description", 9, 99, "Product Image");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid Name. Minimum 3 characters");
        }

        [Fact(DisplayName = "Create Product With Invalid Description")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_InvalidDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "Product Name", "", 9, 99, "Product Image");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid description. Description is required");
        }

        [Fact(DisplayName = "Create Product With Invalid Description Length")]
        [Trait("Product", "DomainExceptionValidation")]

        public void CreateProduct_InvalidDescriptionLength_DomainExceptionInvalidDescriptionLength()
        {
            Action action = () => new Product(1, "Product Name", "Desc", 9, 99, "Product Image");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid description. Minimum 5 characters");
        }
    }
}
