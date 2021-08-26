using System.ComponentModel.DataAnnotations;

namespace Avalonia.ValidationTest.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Remark { get; set; }
        public string Select { get; set; }
        public bool IsChecked { get; set; }
    }
}