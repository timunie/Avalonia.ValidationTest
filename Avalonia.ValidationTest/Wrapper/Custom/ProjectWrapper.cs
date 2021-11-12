using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avalonia.ValidationTest.Wrapper
{
    // This class replaces DataAnnotation attributes on ProjectWrapper
    public partial class ProjectWrapper
    {
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                yield return new ValidationResult("Required",
                    new[] { nameof(Name) });
            }
            if (Name?.Length > 20)
            {
                yield return new ValidationResult("Max length 20",
                    new[] { nameof(Name) });
            }
            
            if (string.IsNullOrWhiteSpace(Number))
            {
                yield return new ValidationResult("Required",
                    new[] { nameof(Number) });
            }
            if (Number?.Length > 20)
            {
                yield return new ValidationResult("Max length 20",
                    new[] { nameof(Number) });
            }
            
            if (string.IsNullOrWhiteSpace(Remark))
            {
                yield return new ValidationResult("Required",
                    new[] { nameof(Remark) });
            }
            if (Remark?.Length > 50)
            {
                yield return new ValidationResult("Max length 50",
                    new[] { nameof(Remark) });
            }
            
            if (string.IsNullOrWhiteSpace(Select))
            {
                yield return new ValidationResult("Required",
                    new[] { nameof(Select) });
            }
            if (Select?.Length > 20)
            {
                yield return new ValidationResult("Max length 20",
                    new[] { nameof(Select) });
            }
        }
    }
}