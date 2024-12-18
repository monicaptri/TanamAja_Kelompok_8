using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamAja.App.Core;

namespace TanamAja.App.Context
{
    internal class C_Riwayat : DatabaseWrapper
    {
        private static string table = "Pesanan";

        // Metode untuk mengambil semua data Tukang Kebun
        public static DataTable All()
        {
            string query = @"
                SELECT 
                    t.id_pesanan,
                    t.Nama,
                    t.Nama_Item,
                    t.Alamat,
                    t.Nomor_Telepon,
                    t.Luas_Lahan,
                    t.Detail_Lainnya;
                FROM 
                    Pesanan p";

            DataTable dataRiwayat  = queryExecutor(query);
            return dataRiwayat;
        }
    }
}
