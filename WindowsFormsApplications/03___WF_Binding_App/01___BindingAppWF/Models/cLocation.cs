namespace BindingDataWindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using BindingDataWindowsFormsApp.Models;
    public class cLocation : INotifyPropertyChanged
    {
       
        private const string cnBusy = "Busy";
        private const string cnAvailable = "Available";        
        private string m_occupancyName = "Unknown";
        private Boolean? m_occupancy = null;

        public Boolean? LocationOccupancy
        {
            get
            {
                return m_occupancy ;
            }
            set
            {

                if (value == m_occupancy)
                {
                    return;
                }
                m_occupancy = value;

                OccupancyName = ((bool)m_occupancy ? cnBusy : cnAvailable);
                //OnPropertyChanged("LocationOccupancy");
            }
        }


        public string OccupancyName
        {
            get
            {
                return m_occupancyName;
                
            }
            set
            {

                if (value == m_occupancyName)
                {
                    return;
                }
                m_occupancyName = value;
                //OnPropertyChanged("OccupancyName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
