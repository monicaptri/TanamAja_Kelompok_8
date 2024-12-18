using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanamAja.App.Models
{
    public class M_TukangKebun
    {
        public int id_tukangkebun { get; set; }
        public required string nama { get; set; }
        public required string alamat { get; set; }
        public required string notelefon { get; set; }
        public required string jeniskelamin { get; set; }
        public required string kondisi { get; set; }
    }
}
