using DomoThink.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/*--------------------------------------------------------
 * MainViewModel.cs
 * 
 * Version: 1.0
 * Author: Filipe
 * Created: 23/09/2016 15:15:29
 * 
 * Notes:
 * -------------------------------------------------------*/

namespace Yolo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region FIELDS



        #endregion

        #region PROPERTIES

        private string text;
        public string TextYolo
        {
            get { return this.text; }
            set
            {
                this.text = value;
                this.OnPropertyChanged("TextYolo");
            }
        }

        private string first;
        public string FirstName
        {
            get { return this.first; }
            set
            {
                this.first = value;
                this.OnPropertyChanged("FirstName");
            }
        }

        private string last;
        public string LastName
        {
            get { return this.last; }
            set
            {
                this.last = value;
                this.OnPropertyChanged("LastName");
            }
        }

        private string mail;
        public string Email
        {
            get { return this.mail; }
            set
            {
                this.mail = value;
                this.OnPropertyChanged("Email");
            }
        }

        private string res;
        public string Result
        {
            get { return this.res; }
            set
            {
                this.res = value;
                this.OnPropertyChanged("Result");
            }
        }

        private ICommand onButtonClick;
        public ICommand OnButtonClick
        {
            get { return this.onButtonClick; }
            set
            {
                this.onButtonClick = value;
                this.OnPropertyChanged("OnButtonClick");
            }
        }

        #endregion

        #region CONSTRUCTORS

        public MainViewModel()
        {
            //this.TextYolo = "Hello world!";
            this.Result = "";
            this.OnButtonClick = new Command(this.OnButtonAction);
        }

        #endregion

        #region METHODS

        private void OnButtonAction(object param)
        {
            this.TextYolo = "Hello world!";
            this.Result = FirstName + " " +  LastName + " " + Email;

        }

        #endregion
    }
}
