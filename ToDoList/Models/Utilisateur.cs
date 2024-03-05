using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Utilisateur
    {
        private int _id_inscription;
        private string _nom_utilisateur;
        private string _email;
        private string _password;
        private string _comfirmpassword;

        //getter and setter
        public int Id_utilisateur { get => _id_inscription; set => _id_inscription = value; }
        public string Nom_utilisateur { get => _nom_utilisateur; set => _nom_utilisateur = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Comfirmpassword { get => _comfirmpassword; set => _comfirmpassword = value; }


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
            this._nom_utilisateur = nom_utilisateur;
            this._email = email;
            this._password = password;
            this._comfirmpassword = comfirmpassword;
        }
    }
}