
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelStudios:ViewModelBase
    {



        #region Attributes
        private ObservableCollection<Studio> _Studios;
        private Studio _SelectedStudio;
        #endregion

        #region Properties
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }

        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelStudios(MegaCastingEntities entities):base(entities)
        {
            this.Studios = new ObservableCollection<Studio>();
            foreach(Studio studio in this.Entities.Studios)
            {
                this.Studios.Add(studio);
            }
        }
        #endregion
    }
}
