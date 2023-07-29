using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;


//using System.Windows.Input;

namespace Maui0.ViewModel
{
    public partial  class MainViewModel : ObservableObject  //: INotifyPropertyChanged
    {

        public MainViewModel() 
        {
            Items = new ObservableCollection<string>();
        }


        [ObservableProperty]
        ObservableCollection<string> items;



        [ObservableProperty]
        string text;

        //public ICommand IncrementCounterCommand { get; }

        [ICommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text)) return; 
            
           Items.Add(Text);
            Text = string.Empty;
        }


        [ICommand]
        void Delete(string s) 
            {
            if (Items.Contains(s))
                    Items.Remove(s); 
            }


        /* public string Text
         {
             get => text;
             set { 
                     text = value;
                     OnPropertyChanged(nameof(Text));
                 }
         }


         public event PropertyChangedEventHandler PropertyChanged;

         void OnPropertyChanged(string name) =>
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
 */

        [ICommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }

    }
}
