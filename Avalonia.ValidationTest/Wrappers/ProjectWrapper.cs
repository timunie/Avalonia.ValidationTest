using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Avalonia.ValidationTest.Models;
using Avalonia.ValidationTest.Wrappers.Base;

namespace Avalonia.ValidationTest.Wrappers;

public sealed class ProjectWrapper : ModelWrapper<Project>
{
    public ProjectWrapper(Project model) : base(model)
    {
    }

    public int Id
    {
        get => GetValue<int>();
        set => SetValue(value);
    }

    public string? Name
    {
        get => GetValue<string?>();
        set => SetValue(value);
    }

    public string? Number
    {
        get => GetValue<string?>();
        set => SetValue(value);
    }
        
    public string? Remark
    {
        get => GetValue<string?>();
        set => SetValue(value);
    }
        
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Name
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
            
        // Number
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
            
        // Remark
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
    }
        
    public string? NameOriginalValue => GetOriginalValue<string?>(nameof(Name));
    public bool NameIsChanged => GetIsChanged(nameof(Name));

    public string? NumberOriginalValue => GetOriginalValue<string?>(nameof(Number));
    public bool NumberIsChanged => GetIsChanged(nameof(Number));

    public string? RemarkOriginalValue => GetOriginalValue<string?>(nameof(Remark));
    public bool RemarkIsChanged => GetIsChanged(nameof(Remark));
}