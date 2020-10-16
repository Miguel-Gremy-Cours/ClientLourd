
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelContrat:ViewModelBase
    {




        #region Attributes
        private ObservableCollection<Contrat> _Contrats;
        private Contrat _SelectedContrat;

        #endregion


        #region Properties
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }



        #endregion


        #region Constructor
        public ViewModelContrat(MegaCastingEntities entities):base(entities)
        {
            this.Contrats = new ObservableCollection<Contrat>();

            foreach(Contrat contrat in this.Entities.Contrats)
            {
                this.Contrats.Add(contrat);
            }
        }
        #endregion
    }
}
