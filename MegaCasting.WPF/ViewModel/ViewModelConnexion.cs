using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelConnexion : ViewModelBase
    {
        public ViewModelConnexion(MegaCastingEntities entities) : base(entities)
        {
            this.Entities = entities;
        }

        /// <summary>
        /// Récupère l'employé correspondant aux Logins
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public Employe GetEmployeeByLogs(string Login, string Password)
        {
#if DEBUG
            this.Entities.Employes.ToList();
            Employe employe = this.Entities.Employes.FirstOrDefault(empl => empl.Login == "kstokes1" && empl.Password == "VxfGwVfeF");
#endif
            return employe;
        }
    }
}
