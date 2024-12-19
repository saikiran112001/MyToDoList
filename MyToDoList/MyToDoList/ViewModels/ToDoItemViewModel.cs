using CommunityToolkit.Mvvm.ComponentModel;
using MyToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        public ToDoItemViewModel()
        {

        }
        //public ToDoItemViewModel(ToDoItem item)
        //{
        //    IsChecked = item.IsChecked;
        //    Content = item.Content;
        //}
        [ObservableProperty]
        private bool _isChecked;

        [ObservableProperty]
        private string? _Content;
    }
}
