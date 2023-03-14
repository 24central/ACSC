
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.ComponentModel;

namespace ACSC.viewmodel
{
    public partial class Mainviewmodel : ObservableObject
    {




        [RelayCommand]
        Task Navigate() => Shell.Current.GoToAsync(nameof(Afterlogin));
       

    }
}
