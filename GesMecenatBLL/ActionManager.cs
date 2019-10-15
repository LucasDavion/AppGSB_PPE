﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatDAL;

namespace GesMecenatBLL
{
    class ActionManager
    {
        private static ActionManager uneInstance;

        //Méthode pour crée la classe ActionManager s'il n'en existe pas on en crée un puis retourne la ref à l'objet

        public static ActionManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ActionManager();
            }
            return uneInstance;
        }

        //Constructeur par défaut privée

        private ActionManager()
        {
        }

        //Appel de la couche DAL pour récupérer une liste de pays

        public List<Action> GetAction()
        {
            return ActionDAO.GetInstance().GetAction();
        }
    }
}
