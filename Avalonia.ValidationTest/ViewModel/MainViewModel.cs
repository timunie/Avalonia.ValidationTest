using System.Collections.ObjectModel;
using Avalonia.ValidationTest.Model;
using Avalonia.ValidationTest.Wrapper;

namespace Avalonia.ValidationTest.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ProjectWrapper _project;

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        public void Load()
        {
            AddComboBoxItems();
            
            var project = CreateNewProject();
            
            InitializeProject(project);
        }

        public ObservableCollection<string> Items { get; }

        public ProjectWrapper Project
        {
            get => _project;
            private set
            {
                _project = value;
                OnPropertyChanged();
            }
        }  

        private void AddComboBoxItems()
        {
            for (int i = 0; i < 5; i++)
            {
                Items.Add($"Item {i}");
            }
        }
        
        private Project CreateNewProject()
        {
            var project = new Project
            {
                Name = "Project",
                Number = string.Empty,
                Remark = string.Empty,
                IsChecked = false,
                Select = string.Empty
            };

            return project;
        }
        
        private void InitializeProject(Project project)
        {
            Project = new ProjectWrapper(project);

            Project.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName is nameof(Project.IsChanged) or nameof(Project.IsValid))
                {
                    //InvalidateCommands();
                }
            };
        }
    }
}