
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelCivilite:ViewModelBase
    {
        #region Attributes

        private Civilite _SelectedCivilite;



        private ObservableCollection<Civilite> _Civilites;
        #endregion
        #region Properties

        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }

        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        #endregion

        #region Constructor

        public ViewModelCivilite(MegaCastingEntities entities) : base(entities)
        {


            this.Civilites = new ObservableCollection<Civilite>();

            foreach (Civilite civilite in this.Entities.Civilites)
            {
                this.Civilites.Add(civilite);
            }
        }
        #endregion
    }
}
