using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class DBConnexion
    {
        //Connection Npgsql avec la connectionString
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todolist"].ConnectionString);
        
        //Fonction InscriptionUtilisateur
        public static void InscriptionUtilisateur(Utilisateur utilisateur)
        {
            //requêtte pour Insert (énoncer la requête)
            var req = $"INSERT INTO public.\"Inscription\"(nom_utilisateur, email, password, comfirmepassword) VALUES ('{utilisateur.Nom_utilisateur}','{utilisateur.Email}','{utilisateur.Password}','{utilisateur.Comfirmpassword}')";

            //Déclarationexception
            try { 
                //Open et Close Connexion/ commande Npgsql/Execution
                connectionString.Open();
                var cmd = new NpgsqlCommand(req);
                cmd.ExecuteNonQuery();
                connectionString.Close();
                }
            catch (Exception e)
            {
                throw e;
            }
            return;
        }
    }
}