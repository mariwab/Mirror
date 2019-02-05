using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MariW.Mirror.GUI.Clock
{

    public class ClockViewModel : INotifyPropertyChanged

    {
        private ClockModel model;
        private string currentTime;
        public string CurrentTime
        {
      
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged();
                }                  
            }
        }

        internal void Initialize(ClockModel model)
        {
            this.model = model;
            UpdateTime();
        }

        private void UpdateTime()
        {

            CurrentTime = $"Hora actual {model.CurrentTime.ToString("hh:mm:ss tt")}"; 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        { 
            if (PropertyChanged != null)
            {
           PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}




            

