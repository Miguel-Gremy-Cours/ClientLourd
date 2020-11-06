﻿
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelInternautes:ViewModelBase
    {







        #region Attributes
        private Civilite _SelectedCivilite;
        private ObservableCollection<Civilite> _Civilites;
        private Internaute _SelectedInternaute;
        private ObservableCollection<Internaute> _Internautes;
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
        public Internaute SelectedInternaute
        {
            get { return _SelectedInternaute; }
            set { _SelectedInternaute = value; }
        }
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelInternautes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;

            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
        }
        #endregion

        #region Method
  



        /// <summary>
        /// supprimer un internaute
        /// </summary>

        public void DeleteInternaute()
        {
            // vérification de droit de suppression, table liée à OffresInternautes

            //suppression d'élément
            this.Internautes.Remove(SelectedInternaute);
            this.SaveChanges();
        }
        #endregion
    }
}
