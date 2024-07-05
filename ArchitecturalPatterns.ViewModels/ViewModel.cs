using ArchitecturalPatterns.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModels
{
    public partial class ViewModel : ObservableObject
    {
        public SomeModel Model { get; set; } = new SomeModel();
        [ObservableProperty]
        protected string inputValue;

        public ViewModel()
        {
            PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            LoadCommand.NotifyCanExecuteChanged();
            SaveCommand.NotifyCanExecuteChanged();
        }


        [RelayCommand(CanExecute = nameof(CanSave))]
        public void Save()
        {
            Model.Value = InputValue;
        }

        public bool CanSave()
        {
            return InputValue != Model.Value;
        }

        [RelayCommand(CanExecute = nameof(CanLoad))]
        public void Load()
        {
            InputValue = Model.Value;
        }
        
        public bool CanLoad()
        {
            return InputValue != Model.Value;
        }
    }
}
