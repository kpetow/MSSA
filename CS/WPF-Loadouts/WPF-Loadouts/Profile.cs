using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_Loadouts
{
    public class Profile : INotifyPropertyChanged
    {
        //Events
        public event PropertyChangedEventHandler PropertyChanged;

        //Fields
        private int brightness;
        private string difficulty;
        private string resolution;
        private bool hints;

        //Properties
        public int Brightness
        {
            get { return brightness; }
            set { brightness = value; onPropertyChanged("Brightness"); }
        }
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; onPropertyChanged("Brightness"); }
        }
        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; onPropertyChanged("Brightness"); }
        }
        public bool Hints
        {
            get { return hints; }
            set { hints = value; onPropertyChanged("Brightness"); }
        }

        //Contructor
        public Profile(int brightness = 50, string difficulty = "Normal", string resolution = "1920 x 1080", bool hints = false)
        {
            this.brightness = brightness;
            this.difficulty = difficulty;
            this.resolution = resolution;
            this.hints = hints;
        }
        
        //Methods
        public void onPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
