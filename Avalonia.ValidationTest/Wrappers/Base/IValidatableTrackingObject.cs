using System.ComponentModel;

namespace Avalonia.ValidationTest.Wrappers.Base;

public interface IValidatableTrackingObject : IRevertibleChangeTracking, INotifyPropertyChanged
{
    bool IsValid { get; }
}