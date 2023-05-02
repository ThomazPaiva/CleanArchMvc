using CleanArchMvcDomain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        [Trait("Category", "DomainExceptionValidation")]

        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");

            action.Should().NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With Invalid ID")]
        [Trait("Category", "DomainExceptionValidation")]

        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create Category With a Name Too Short")]
        [Trait("Category", "DomainExceptionValidation")]

        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid Name. Minimum 3 characters");
        }

        [Fact(DisplayName = "Create Category With Missing Name Value")]
        [Trait("Category", "DomainExceptionValidation")]

        public void CreateCategory_MissingNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "");

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid Name. Name is required");
        }

        [Fact(DisplayName = "Create Category With Null Name Value")]
        [Trait("Category", "DomainExceptionValidation")]

        public void CreateCategory_WithNullNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, null);

            action.Should().Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
    }
}