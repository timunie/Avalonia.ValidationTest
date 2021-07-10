using System.ComponentModel;

namespace Avalonia.ValidationTest.Wrapper
{
    public interface IValidatableTrackingObject : IRevertibleChangeTracking, INotifyPropertyChanged
    {
        bool IsValid { get; }
    }
}