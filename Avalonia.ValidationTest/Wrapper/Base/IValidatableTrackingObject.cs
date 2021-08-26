using System.ComponentModel;

namespace Avalonia.ValidationTest.Wrapper.Base
{
    public interface IValidatableTrackingObject : IRevertibleChangeTracking, INotifyPropertyChanged
    {
        bool IsValid { get; }
    }
}