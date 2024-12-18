using Npgsql;
using NpgsqlTypes;
using PBO_Gymly.DataBase;
using PBO_Gymly.StrukturData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.CRUD
{
    internal class BagianStatus : Database_Gymly
    {
        private static string table = "status_membership";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            id_status,
            status_membership,
            id_profil,
            id_membership,
        FROM 
            status_membership";

            DataTable datafasilitasgym = queryExecutor(query);
            return datafasilitasgym;
        }

        public static void AddStatus(Struktur_Status statusbaru)
        {
            string query = $"INSERT INTO {table} (status, id_profil, id_membership) VALUES(@status, @id_profil, @id_membership)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@status", statusbaru.status_membership),
                new NpgsqlParameter("@id_profil", statusbaru.id_profil),
                new NpgsqlParameter("@id_membership", statusbaru.id_membership)
            };

            commandExecutor(query, parameters);
        }
        public static void UpdateStatus(Struktur_Status status)
        {
            string query = $"UPDATE {table} SET status = @status, id_profil = @id_profil, id_membership = @id_membership WHERE id_status = @id_status";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@status", status.status_membership),
                new NpgsqlParameter("@id_profil", status.id_profil),
                new NpgsqlParameter("@id_membership", status.id_membership),
                new NpgsqlParameter("@id_status", status.id_status)
            };

            commandExecutor(query, parameters);
        }
    }
}
