using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddTypeContrat : ViewModelBase
    {
        #region Attributes
        private TypeContrat _TypeContrat;
        #endregion
        private ObservableCollection<TypeContrat> _TypeContrats;

        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }

        #region Accesseurs
        public TypeContrat TypeContrat
        {
            get { return _TypeContrat; }
            set { _TypeContrat = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddTypeContrat(MegaCastingEntities entities) : base(entities)
        {
            this.TypeContrat = new TypeContrat();
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
        }
        #endregion

        public void InserteTypeContrat(string libelle)
        {
            TypeContrat typeContrat = new TypeContrat();
            typeContrat.Libelle = libelle;
            this.TypeContrats.Add(typeContrat);
            this.SaveChanges();
        }


    }
}
