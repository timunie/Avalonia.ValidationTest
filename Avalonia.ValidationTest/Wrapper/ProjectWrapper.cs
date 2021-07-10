using System.ComponentModel.DataAnnotations;
using Avalonia.ValidationTest.Model;

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

        [Required(ErrorMessage = "Required")]
        [StringLength(20, ErrorMessage = "Max length 20")]
        public string Name
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string ProjectNameOriginalValue => GetOriginalValue<string>(nameof(Name));

        public bool ProjectNameIsChanged => GetIsChanged(nameof(Name));


        [Required(ErrorMessage = "Required")]
        [StringLength(20, ErrorMessage = "Max length 20")]
        public string Number
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string NumberOriginalValue => GetOriginalValue<string>(nameof(Number));

        public bool NumberIsChanged => GetIsChanged(nameof(Number));
        
        
        [Required(ErrorMessage = "Required")]
        [StringLength(20, ErrorMessage = "Max length 20")]
        public string Remark
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string RemarkOriginalValue => GetOriginalValue<string>(nameof(Remark));

        public bool RemarkIsChanged => GetIsChanged(nameof(Remark));
    }
}