﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["tacheDBConnection"].ConnectionString);

        public static bool VerifierUtilisateur(Utilisateur utilisateur)
        {
            var request = "SELECT * FROM public.\"User\" WHERE username='" + utilisateur.Username + "' AND password='" + utilisateur.Password + "'";
            var hasUser = false;
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(request, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hasUser;
        }
    }
}