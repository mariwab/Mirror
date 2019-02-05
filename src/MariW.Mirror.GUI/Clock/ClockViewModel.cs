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

    public class ClockViewModel : PropertyChangedBase

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
        private string currentDate;
        public string CurrentDate
        {

            get
            {
                return currentDate;
            }
            set
            {
                if (currentDate != value)
                {
                    currentDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        internal void Initialize(ClockModel model)
        {
            this.model = model;
            UpdateTime();
            model.PropertyChanged += ModelPropertyChanged;
            
        }

        private void ModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(model.CurrentTime))
            {
                UpdateTime();
            }
        }

        private void UpdateTime()
        {
            CurrentTime = model.CurrentTime.ToString("hh:mm:ss tt");
            CurrentDate = model.CurrentTime.ToString("d MMMM yyyy");
        }
    }
}




            

