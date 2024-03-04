using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Utilisateur
    {
        private int id_utilisateur;
        private string nom_utilisateur;
        private string email;
        private string password;
        private string comfirmpassword;

        //getter and setter
        public int Id_utilisateur { get => id_utilisateur; set => id_utilisateur = value; }
        public string Nom_utilisateur { get => nom_utilisateur; set => nom_utilisateur = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Comfirmpassword { get => comfirmpassword; set => comfirmpassword = value; }


        //constructeur avec id
        public Utilisateur(int id_utilisateur, string nom_utilisateur, string email, string password, string comfirmpassword)
        {
            this.Id_utilisateur = id_utilisateur;
            this.Nom_utilisateur = nom_utilisateur;
            this.Email = email;
            this.Password = password;
            this.Comfirmpassword = comfirmpassword;
        }

        //constructeur vide pour éviter une erreur
        public Utilisateur()
        {
        }


        //constructeur sans id
        public Utilisateur(string nom_utilisateur, string email, string password, string comfirmpassword)
        {
            this.nom_utilisateur = nom_utilisateur;
            this.email = email;
            this.password = password;
            this.comfirmpassword = comfirmpassword;
        }
    }
}