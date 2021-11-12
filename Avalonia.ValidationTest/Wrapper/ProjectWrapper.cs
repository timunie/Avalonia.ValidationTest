using Avalonia.ValidationTest.Dto;
using Avalonia.ValidationTest.Wrapper.Base;

namespace Avalonia.ValidationTest.Wrapper
{
    // No longer any DataAnnotation attributes in this class. Replaced with a partial class
    public partial class ProjectWrapper : ModelWrapper<ProjectDto>
    {
        public ProjectWrapper(ProjectDto model) : base(model)
        {
        }

        public int Id
        {
            get => GetValue<int>();
            set => SetValue(value);
        }

        public string Name
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string Number
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        
        public string Remark
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        
        public string Select
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        
        public bool IsChecked
        {
            get => GetValue<bool>();
            set => SetValue(value);
        }
        
        public string NameOriginalValue => GetOriginalValue<string>(nameof(Name));
        public bool NameIsChanged => GetIsChanged(nameof(Name));

        public string NumberOriginalValue => GetOriginalValue<string>(nameof(Number));
        public bool NumberIsChanged => GetIsChanged(nameof(Number));

        public string RemarkOriginalValue => GetOriginalValue<string>(nameof(Remark));
        public bool RemarkIsChanged => GetIsChanged(nameof(Remark));

        public string SelectOriginalValue => GetOriginalValue<string>(nameof(Select));
        public bool SelectIsChanged => GetIsChanged(nameof(Select));

        public bool IsCheckedOriginalValue => GetOriginalValue<bool>(nameof(IsChecked));
        public bool IsCheckedIsChanged => GetIsChanged(nameof(IsChecked));
    }
}