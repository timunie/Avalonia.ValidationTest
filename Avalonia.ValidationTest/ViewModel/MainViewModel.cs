using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.ValidationTest.Dto;
using Avalonia.ValidationTest.Wrapper;
using Avalonia.ValidationTest.Wrapper.Base;

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
            AddDataGridItems();
            
            AddComboBoxItems();
            
            var project = CreateNewProject();
            
            InitializeProject(project);

            OnPropertyChanged("");
        }

        public ChangeTrackingCollection<ProjectWrapper> Projects { get; private set; }
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
            for (var i = 0; i < 5; i++)
            {
                Items.Add($"Item {i}");
            }
        }

        private void AddDataGridItems()
        {
            var projects = new List<ProjectDto>();
            for (var i = 0; i < 5; i++)
            {
                projects.Add(new ProjectDto()
                {
                    Name = $"Project {i}",
                    Number = $"00000{i}",
                    Remark = $"Remark {i}",
                    IsChecked = false
                });
            }

            Projects = new ChangeTrackingCollection<ProjectWrapper>(
                projects.Select(e => new ProjectWrapper(e)));

            foreach (var wrapper in Projects)
            {
                InitializeProject(wrapper.Model);
            }
        }
        
        private static ProjectDto CreateNewProject()
        {
            var project = new ProjectDto
            {
                Name = "Project",
                Number = string.Empty,
                Remark = string.Empty,
                IsChecked = false,
                Select = string.Empty
            };

            return project;
        }
        
        private void InitializeProject(ProjectDto project)
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