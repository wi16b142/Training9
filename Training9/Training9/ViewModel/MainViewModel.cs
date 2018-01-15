using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Training9.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        #region members
        ObservableCollection<DataVM> data;
        RelayCommand addBtnClick;
        string newCategory;
        string newDescription;
        BitmapImage newType;
        int newPriority;
        int newAmount;
        string newStatus;
        #endregion

        public MainViewModel()
        {
            data = new ObservableCollection<DataVM>();

            AddBtnClick = new RelayCommand(()=> 
            {
                Data.Add(new DataVM(NewCategory, NewDescription, NewType, NewPriority, NewAmount, NewStatus));
            }, ()=> { return CanAddData(); });

            GenerateDemoData();
        }

        private void GenerateDemoData()
        {
            Data.Add(new DataVM(DataVM.Categories[1], "ZeroW", DataVM.Types[0], DataVM.Priorities[0], 100, DataVM.States[2]));
            Data.Add(new DataVM(DataVM.Categories[0], "Micro", DataVM.Types[5], DataVM.Priorities[2], 200, DataVM.States[1]));
            Data.Add(new DataVM(DataVM.Categories[3], "PI3", DataVM.Types[1], DataVM.Priorities[1], 300, DataVM.States[0]));
            Data.Add(new DataVM(DataVM.Categories[4], "PI2", DataVM.Types[1], DataVM.Priorities[2], 400, DataVM.States[0]));
            Data.Add(new DataVM(DataVM.Categories[3], "Mega", DataVM.Types[2], DataVM.Priorities[0], 500, DataVM.States[1]));
            Data.Add(new DataVM(DataVM.Categories[2], "Nano", DataVM.Types[4], DataVM.Priorities[1], 600, DataVM.States[2]));
            Data.Add(new DataVM(DataVM.Categories[4], "Uno", DataVM.Types[3], DataVM.Priorities[2], 700, DataVM.States[1]));
        }

        private bool CanAddData()
        {
            return true;
        }

        #region properties
        public ObservableCollection<DataVM> Data
        {
            get => data; set
            {
                data = value; RaisePropertyChanged();
            }
        }
        public RelayCommand AddBtnClick
        {
            get => addBtnClick; set
            {
                addBtnClick = value; RaisePropertyChanged();
            }
        }
        public string NewCategory
        {
            get => newCategory; set
            {
                newCategory = value; RaisePropertyChanged();
            }
        }
        public string NewDescription
        {
            get => newDescription; set
            {
                newDescription = value; RaisePropertyChanged();
            }
        }
        public BitmapImage NewType
        {
            get => newType; set
            {
                newType = value; RaisePropertyChanged();
            }
        }
        public int NewPriority
        {
            get => newPriority; set
            {
                newPriority = value; RaisePropertyChanged();
            }
        }
        public int NewAmount
        {
            get => newAmount; set
            {
                newAmount = value; RaisePropertyChanged();
            }
        }
        public string NewStatus
        {
            get => newStatus; set
            {
                newStatus = value; RaisePropertyChanged();
            }
        }
        #endregion
    }
}