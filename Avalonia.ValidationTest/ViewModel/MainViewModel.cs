using Avalonia.ValidationTest.Model;
using Avalonia.ValidationTest.Wrapper;

namespace Avalonia.ValidationTest.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ProjectWrapper _project;
        
        public void Load()
        {
            var project = CreateNewProject();
            
            InitializeProject(project);
        }

        public ProjectWrapper Project
        {
            get => _project;
            private set
            {
                _project = value;
                OnPropertyChanged();
            }
        }  
        
        private Project CreateNewProject()
        {
            var project = new Project
            {
                Name = string.Empty,
                Number = string.Empty,
                Remark = string.Empty
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
            //InvalidateCommands();
        }
    }
}