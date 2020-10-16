
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelEmployes:ViewModelBase

    {

       

       



        #region Attributes
        private Employe _SelectedEmploye;
        private ObservableCollection<Employe> _Employes;
        #endregion

        #region Properties
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }



        public Employe Employe
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }
        #endregion
        #region constrcutor

        public ViewModelEmployes(MegaCastingEntities entities):base(entities)
        {
            this.Employes = new ObservableCollection<Employe>();
            foreach(Employe employe in this.Entities.Employes)
            {
                this.Employes.Add(employe);
            }
        }
        #endregion

    }
}
