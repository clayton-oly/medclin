using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medclin
{
    public static class Banco
    {
        public static SqlConnection abrir()
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=ITQ0514104W10-1;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa;Password=senac@itq");
                cn.Open();
                return cn;

                //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
                //cn.Open();
                //return cn;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}

