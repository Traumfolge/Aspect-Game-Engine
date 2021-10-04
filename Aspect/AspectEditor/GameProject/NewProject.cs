using System;
using System.Collections.Generic;
using System.Text;

namespace AspectEditor.GameProject
{
    class NewProject : ViewModelBase
    {
        private string _name = "NewProject";
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
    }

}
