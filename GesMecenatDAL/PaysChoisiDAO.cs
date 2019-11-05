using GesMecenatBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatDAL
{
    public class PaysChoisiDAO
    {
        private static PaysChoisiDAO uneInstance;

        public static PaysChoisiDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PaysChoisiDAO();
            }
            return uneInstance;
        }

        private PaysChoisiDAO()
        {

        }

        public int AjoutPays(PaysChoisiPartenariat unPaysChoisiPartenariat)
        {
            int nbEnregs = 0;

            //connexion à la bdd
            SqlConnection cnx = Connexion.GetObjConnexion();

            //requete
            string sqlr = "insert into paysChoisiPartenariat (idPays,annee) values(@pays, @annee)";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;
            maCommand.Parameters.Add("pays", SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unPaysChoisiPartenariat.Id;
            maCommand.Parameters.Add("annee", SqlDbType.Int);
            maCommand.Parameters[1].Value = unPaysChoisiPartenariat.Annee;

            nbEnregs = maCommand.ExecuteNonQuery();

            //on ferme la connexion
            Connexion.CloseConnexion();

            return nbEnregs;
        }
    }
}