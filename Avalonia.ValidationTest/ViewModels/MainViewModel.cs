using Avalonia.ValidationTest.Models;
using Avalonia.ValidationTest.Wrappers;

namespace Avalonia.ValidationTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ProjectWrapper _project;

    public MainViewModel()
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
        
    private static Project CreateNewProject()
    {
        var project = new Project
        {
            Name = "Project 1",
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
    }
}