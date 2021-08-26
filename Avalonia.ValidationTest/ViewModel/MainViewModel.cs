using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.ValidationTest.Model;
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
            for (int i = 0; i < 5; i++)
            {
                Items.Add($"Item {i}");
            }
        }

        private void AddDataGridItems()
        {
            var projects = new List<Project>();
            for (int i = 0; i < 5; i++)
            {
                projects.Add(new Project()
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
                wrapper.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == nameof(wrapper.IsChanged) || e.PropertyName == nameof(wrapper.IsValid))
                    {
                        //InvalidateCommands();
                    }
                };
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