﻿using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelDomaineMetier:ViewModelBase
    {


        #region Attributes
        private DomaineMetier _SelectedDomaineMetier;
        private ObservableCollection<DomaineMetier> _DomaineMetiers;

        #endregion

        #region Properties
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }

        #endregion

        #region Constrcutor
        public ViewModelDomaineMetier(MegaCastingEntities entities) : base(entities)
        {


            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;

            //this.TypeContrats = new ObservableCollection<TypeContrat>();
            //foreach (TypeContrat typeContrat in this.Entities.TypeContrats) 
            //{
            //    this.TypeContrats.Add(typeContrat);
            //}
        }

        #endregion
        #region Method

        /// <summary>
        /// Ajouter un nouveau domaine
        /// </summary>
        public void InsertDomaineMetier()
        {
            if (this.Entities.DomaineMetiers.Any(dom => dom.Libelle== "Nouveau domaine"))
            {
                DomaineMetier domaineMetier = new DomaineMetier();
                domaineMetier.Libelle = "Nouveau domaine";
                this.DomaineMetiers.Add(domaineMetier);
                this.SaveChanges();
                this.SelectedDomaineMetier = domaineMetier;

            }

        }



        /// <summary>
        /// supprimer un domaine
        /// </summary>

        public void DeleteDomaineMetier()
        {
            // vérification de droit de suppression, table liée à Metier

            //suppression d'élément
            this.DomaineMetiers.Remove(SelectedDomaineMetier);
            this.SaveChanges();
        }
        #endregion
    }
}
