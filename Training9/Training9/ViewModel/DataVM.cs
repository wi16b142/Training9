using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace Training9.ViewModel
{
    public class DataVM:ViewModelBase
    {
        #region members
        static string[] categories = new string[] {"Category 1", "Category 2", "Category 3", "Category 4", "Category 5" };
        static int[] priorities = new int[] { 1, 2, 3 };
        static string[] states = new string[] { "ready", "processing", "waiting" };
        static BitmapImage[] types = new BitmapImage[] 
        {
            new BitmapImage(new Uri("Images/PIZero.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("Images/PI3.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("Images/Mega.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("Images/Uno.jpg", UriKind.Relative)),  
            new BitmapImage(new Uri("Images/Nano.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("Images/Micro.jpg", UriKind.Relative))
        };

        public static string[] Categories { get => categories; private set => categories = value; }
        public static int[] Priorities { get => priorities; set => priorities = value; }
        public static BitmapImage[] Types { get => types; set => types = value; }
        public string Category
        {
            get => category; set
            {
                category = value; RaisePropertyChanged();
            }
        }
        public string Description
        {
            get => description; set
            {
                description = value; RaisePropertyChanged();
            }
        }
        public BitmapImage Type
        {
            get => type; set
            {
                type = value; RaisePropertyChanged();
            }
        }
        public int Priority
        {
            get => priority; set
            {
                priority = value; RaisePropertyChanged();
            }
        }
        public int Amount
        {
            get => amount; set
            {
                amount = value; RaisePropertyChanged();
            }
        }
        public string Status
        {
            get => status; set
            {
                status = value; RaisePropertyChanged();
            }
        }
        public static string[] States
        {
            get => states; set
            {
                states = value;
            }
        }

        string category;
        string description;
        BitmapImage type;
        int priority;
        int amount;
        string status;

        #endregion

        public DataVM(string category, string description, BitmapImage type, int priority, int amount, string status)
        {
            Category = category;
            Description = description;
            Type = type;
            Priority = priority;
            Amount = amount;
            Status = status;
        }


    }
}
