using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.viewmodel
{
    public partial class AfterLoginUpdateVm : ObservableObject

    {

        [RelayCommand]
       async Task Pop() => await DisplayAlert("Alert", "You have been alerted", "OK");

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            
            return DisplayAlert("Alert", "You have been alerted", "OK");
            
                //DisplayAlert("Alert", "You have been alerted", "OK");
            //throw new NotImplementedException();
        }
    }
}
