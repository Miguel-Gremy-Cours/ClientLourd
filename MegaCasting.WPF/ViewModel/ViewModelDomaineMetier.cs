using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    public class ViewModelDomaineMetier:ViewModelBase
    {


        #region Attributes
        private DomaineMetier _SelectdDomaineMetier;
        private ObservableCollection<DomaineMetier> _DomaineMetiers;

        #endregion

        #region Properties
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        public DomaineMetier SelectdDomaineMetier
        {
            get { return _SelectdDomaineMetier; }
            set { _SelectdDomaineMetier = value; }
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
                this.SelectdDomaineMetier = domaineMetier;

            }

        }



        /// <summary>
        /// supprimer un domaine
        /// </summary>

        public void DeleteDomaineMetier()
        {
            // vérification de droit de suppression, table liée à Metier

            //suppression d'élément
            this.DomaineMetiers.Remove(SelectdDomaineMetier);
            this.SaveChanges();
        }
        #endregion
    }
}
