using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui0.ViewModel
{
    [QueryProperty("Text","Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ICommand]
        async Task Back()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
