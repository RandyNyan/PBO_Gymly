using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_Gymly.DataBase;
using PBO_Gymly.StrukturData;

namespace PBO_Gymly.CRUD
{
    internal class BagianFasilitasGym : Database_Gymly
    {
        private static string table = "fasilitas_gym";
        
        public static DataTable All()
        {
            string query = @"
        SELECT 
            id_fasilitas_gym,
            nama_fasilitas,
            jumlah_fasilitas,
            fasilitas_baik,
            fasilitas_rusak
        FROM 
            fasilitas_gym";

            DataTable datafasilitasgym = queryExecutor(query);
            return datafasilitasgym;
        }

        public static void AddFasilitas(Struktur_FasilitasGym fasilitasbaru)
        {
            string query = $"INSERT INTO {table} (nama_fasilitas, jumlah_fasilitas, fasilitas_baik, fasilitas_rusak) VALUES(@nama_fasilitas, @jumlah_fasilitas, @fasilitas_baik, @fasilitas_rusak)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_fasilitas", fasilitasbaru.nama_fasilitas),
                new NpgsqlParameter("@jumlah_fasilitas", fasilitasbaru.jumlah_fasilitas),
                new NpgsqlParameter("@fasilitas_baik", fasilitasbaru.fasilitas_baik),
                new NpgsqlParameter("@fasilitas_rusak", fasilitasbaru.fasilitas_rusak)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateFasilitas(Struktur_FasilitasGym fasilitas)
        {
            string query = $"UPDATE {table} SET nama_fasilitas = @nama_fasilitas, jumlah_fasilitas = @jumlah_fasilitas, fasilitas_baik = @fasilitas_baik, fasilitas_rusak = @fasilitas_rusak WHERE id_fasilitas_gym = @id_fasilitas_gym";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_fasilitas", fasilitas.nama_fasilitas),
                new NpgsqlParameter("@jumlah_fasilitas", fasilitas.jumlah_fasilitas),
                new NpgsqlParameter("@fasilitas_baik", fasilitas.fasilitas_baik),
                new NpgsqlParameter("@fasilitas_rusak", fasilitas.fasilitas_rusak),
                new NpgsqlParameter("@id_fasilitas_gym", fasilitas.id_fasilitas_gym)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteFasilitasGym(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_fasilitas_gym = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
