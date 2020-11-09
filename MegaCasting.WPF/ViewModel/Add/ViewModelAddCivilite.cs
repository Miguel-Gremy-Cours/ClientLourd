using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddCivilite : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la Civilité qui sera créée
        /// </summary>
        private Civilite _Civilite;
        #endregion
        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété "Civilite" de type de classe Civilite
        /// </summary>
        public Civilite Civilite
        {
            get { return _Civilite; }
            set { _Civilite = value; }
        }
        #endregion
        #region constructor
        /// <summary>
        /// Créer ViewModelAddCivilite, dans lequelle contient une nouvelle instance Civilité
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddCivilite(MegaCastingEntities entities) : base(entities)
        {
            this.Civilite = new Civilite();
        }
        #endregion
    }
}
