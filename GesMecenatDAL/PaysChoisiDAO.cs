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
            string sqlr = "insert into paysChoisiPartenariat values(@pays)";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;
            maCommand.Parameters.Add("pays", SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unPaysChoisiPartenariat.Pays;

            nbEnregs = maCommand.ExecuteNonQuery();

            //on ferme la connexion
            Connexion.CloseConnexion();

            return nbEnregs;
        }
    }
}
