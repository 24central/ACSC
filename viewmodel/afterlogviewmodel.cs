

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ACSC.viewmodel
{
    
    public partial class Afterlogviewmodel:ObservableObject
    {
        
       [RelayCommand]
       
         Task Add() => Shell.Current.GoToAsync(nameof(AfterLoginUpdate));
        

       





    }
}
