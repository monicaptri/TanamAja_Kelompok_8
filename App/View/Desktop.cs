using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;
using TanamAja.App.View;

namespace TanamAja
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            formLogin Login = new formLogin();
            Login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Desktop_Load(object sender, EventArgs e)
        {
          
        }
    }
}
