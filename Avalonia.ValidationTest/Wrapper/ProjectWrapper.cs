using System.ComponentModel.DataAnnotations;
using Avalonia.ValidationTest.Model;
using Avalonia.ValidationTest.Wrapper.Base;

namespace Avalonia.ValidationTest.Wrapper
{
    public class ProjectWrapper : ModelWrapper<Project>
    {
        public ProjectWrapper(Project model) : base(model)
        {
        }

        public int Id
        {
            get => GetValue<int>();
            set => SetValue(value);
        }

        [Required]
        [StringLength(20)]
        public string Name
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string NameOriginalValue => GetOriginalValue<string>(nameof(Name));

        public bool NameIsChanged => GetIsChanged(nameof(Name));


        [Required]
        [StringLength(20)]
        public string Number
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string NumberOriginalValue => GetOriginalValue<string>(nameof(Number));

        public bool NumberIsChanged => GetIsChanged(nameof(Number));
        
        
        [Required]
        [StringLength(20)]
        public string Remark
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string RemarkOriginalValue => GetOriginalValue<string>(nameof(Remark));

        public bool RemarkIsChanged => GetIsChanged(nameof(Remark));
        
        [Required]
        public string Select
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string SelectOriginalValue => GetOriginalValue<string>(nameof(Select));

        public bool SelectIsChanged => GetIsChanged(nameof(Select));
        
        public bool IsChecked
        {
            get => GetValue<bool>();
            set => SetValue(value);
        }

        public bool IsCheckedOriginalValue => GetOriginalValue<bool>(nameof(IsChecked));

        public bool IsCheckedIsChanged => GetIsChanged(nameof(IsChecked));
    }
}