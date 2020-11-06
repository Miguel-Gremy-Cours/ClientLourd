
using Caliburn.Micro;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
   public  class ViewModelPartenaires:ViewModelBase
    {




        #region Attributes
        private Partenaire _SelectedPartenaire;
        private ObservableCollection<Partenaire> _Partenaires;
 
        #endregion

        #region Properties

     

        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }


        public Partenaire SelectedPartenaire
        {
            get { return _SelectedPartenaire; }
            set { _SelectedPartenaire = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelPartenaires(MegaCastingEntities entities):base(entities)
        {

            this.Entities.Partenaires.ToList();
            this.Partenaires = this.Entities.Partenaires.Local;
           
            
        }
        #endregion


        #region Method
        /// <summary>
        /// supprimer un partenaire
        /// </summary>

        public void DeletePartenaire()
        {
            // vérification de droit de suppression, aucune table liée

            //suppression d'élément
            this.Partenaires.Remove(SelectedPartenaire);
            this.SaveChanges();
        }
        #endregion
    }
}
