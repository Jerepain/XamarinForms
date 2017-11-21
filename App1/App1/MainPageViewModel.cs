using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App1.Annotations;
using Xamarin.Forms;

namespace App1
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            Items = new ObservableCollection<BreadCrumbItem>{new BreadCrumbItem{Label = "oijh"}};
            Items.Add(new BreadCrumbItem { Label = "aaa" });
            Test = "test";
            BreadcrumbCommand = new Command(BreadcrumbNavigate);

        }

        private void BreadcrumbNavigate(object o)
        {
            
        }

        public ICommand BreadcrumbCommand { get; set; }

        public string Test { get; set; }

        private ObservableCollection<BreadCrumbItem> _items;
        public ObservableCollection<BreadCrumbItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
