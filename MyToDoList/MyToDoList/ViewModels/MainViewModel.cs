using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

        [ObservableProperty]
        private string? _newItemContent;

        [RelayCommand]
        private void AddItem()
        {
            if (string.IsNullOrEmpty(NewItemContent))
                return;
            ToDoItems.Add(new ToDoItemViewModel() { Content = NewItemContent });
            NewItemContent = null;
        }

        [RelayCommand]
        private void RemoveItem(ToDoItemViewModel item)
        {
            ToDoItems?.Remove(item);
        }
    }
}

