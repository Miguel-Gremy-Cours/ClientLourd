using MegaCasting.DBLib;
using MegaCasting.WPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    public abstract class ViewModelBase
    {

        #region Attributues
        /// <summary>
        /// Attribut contenant les données de la base de donnée
        /// </summary>
        private MegaCastingEntities _Entities;
        /// <summary>
        /// Attribut du ViewModel
        /// </summary>
        private ViewModelMainWindow _ViewModel;
        #endregion

        #region  Properties
        /// <summary>
        /// Entitées de la base de donnée
        /// </summary>
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }


        }
        /// <summary>
        /// ViewModel pour la page correspondante
        /// </summary>
        public ViewModelMainWindow ViewModel
        {
            get { return _ViewModel; }
            set { _ViewModel = value; }
        }

        #endregion
        #region constrcutor
        /// <summary>
        /// Constructeur de la classe 'ViewModelBase'
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelBase(MegaCastingEntities entities)
        {
            this.Entities = entities;
        }
        #endregion

        #region Method
        /// <summary>
        /// Sauvegarde de modification en base de donnée
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
            //try
            //{

            //}
            //catch (Exception e)
            //{
               
               
            //}
            //finally
            //{

            //WindowSucces windowSucces = new WindowSucces();
            //}
        }

        /*
        public string ToDateValue(DateTime? pValue)
            => pValue == null ? "NULL" : $"'{pValue.Value.ToString("yyyyMMdd")}'";
        */
        #endregion
    }
}
