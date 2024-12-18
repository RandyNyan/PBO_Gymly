using Npgsql;
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
    internal class BagianProfil : Database_Gymly
    {
        private static string table = "profil_customer";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            id_profil,
            naleng_customer,
            alamat_customer,
            notel_customer
        FROM 
            profil_customer";

            DataTable datafasilitasgym = queryExecutor(query);
            return datafasilitasgym;
        }

        public static DataTable getFasilitasGymById(int id)
        {
            string query = @"
                SELECT 
                    id_profil,
                    naleng_customer,
                    alamat_customer,
                    notel_customer
                FROM 
                    profil_customer
                WHERE 
                    id_customer = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable datafasilitasgym = queryExecutor(query, parameters);
            return datafasilitasgym;
        }


        public static void AddProfil(Struktur_Profil profilbaru)
        {
            string query = $"INSERT INTO {table} (naleng_customer, alamat_customer, notel_customer, id_customer) VALUES(@naleng_customer, @alamat_customer, @notel_customer, @id_customer)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@naleng_customer", profilbaru.naleng_customer),
                new NpgsqlParameter("@alamat_customer", profilbaru.alamat_customer),
                new NpgsqlParameter("@notel_customer", profilbaru.notel_customer),
                new NpgsqlParameter("@id_customer", profilbaru.id_akun)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateProfil(Struktur_Profil profil)
        {
            string query = $"UPDATE {table} SET naleng_customer = @naleng_customer, alamat_customer = @alamat_customer, notel_customer = @notel_customer WHERE id_customer = @id_customer";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@naleng_customer", profil.naleng_customer),
                new NpgsqlParameter("@alamat_customer", profil.alamat_customer),
                new NpgsqlParameter("@notel_customer", profil.notel_customer),
                new NpgsqlParameter("@id_customer", profil.id_akun)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteMahasiswa(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_profil = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
