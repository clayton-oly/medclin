using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medclin
{
    public partial class frmCadastroAgenda : Form
    {
        public frmCadastroAgenda()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=ITQ0514104W10-1;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa;Password=senac@itq");
        // SqlConnection conexao = new SqlConnection(@"Data Source=ITQ0514104W10-1;Initial Catalog=goDB;Persist Security Info=True;User ID=sa;Password=senac@itq");
        private string strMySQL;

        private void frmCadastroAgenda_Load(object sender, EventArgs e)
        {
            cmbEspecialidade.SelectedIndex = 0;
            txtData.Text = DateTime.Now.ToShortTimeString();

            dgvAgendamento.ColumnCount = 6;
            dgvAgendamento.Columns[0].Name = "CÓDIGO";
            dgvAgendamento.Columns[1].Name = "NOME PACIENTE";
            dgvAgendamento.Columns[2].Name = "NOME MEDICO";
            dgvAgendamento.Columns[3].Name = "DATA";
            dgvAgendamento.Columns[4].Name = "HORA";
            dgvAgendamento.Columns[5].Name = "ESPECIALIDADE";



            if (true)
            {
                SqlConnection cn = new SqlConnection();
               // cn.ConnectionString = (@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
                 cn.ConnectionString = (@"Data Source=ITQ0514104W10-1;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa;Password=senac@itq");
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "Select nome_medico from MEDICO";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbMedico.DisplayMember = "nome_medico";
                cmbMedico.DataSource = dt;
            }
            try
            {
                SqlConnection cn = new SqlConnection();
               // cn.ConnectionString = (@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
                 cn.ConnectionString = (@"Data Source=ITQ0514104W10-1;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa;Password=senac@itq");
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "Select nome_paciente from PACIENTE";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                //cmbPaciente.DisplayMember = "nome_paciente";
                //cmbPaciente.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CONECTAR NO BANCO DE DADOS ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMedico_Click(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            strMySQL = "insert into agendamento( nome_paciente, nome_medico , data , hora , especialidade ) values ( @nome_paciente, @nome_medico , @data , @hora , @especialidade)";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            try
            {
                conexao.Open();
                if (true)
                {
                    comando.Parameters.Clear();
                  //  comando.Parameters.AddWithValue("@id_agendamento", txtCodigo.Text);
                    //comando.Parameters.AddWithValue("@nome_paciente", cmbPaciente.Text);
                    comando.Parameters.AddWithValue("@nome_medico", cmbMedico.Text);
                    comando.Parameters.AddWithValue("@data", dT_NASCDateTimePicker.Text);
                    comando.Parameters.AddWithValue("@hora", txtData.Text);
                    comando.Parameters.AddWithValue("@especialidade", cmbEspecialidade.Text);

                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            comando.ExecuteNonQuery();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {

                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from AGENDAMENTO where nome_paciente like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvAgendamento.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvAgendamento.Rows.Add();
                        dgvAgendamento.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvAgendamento.Rows[linha].Cells["NOME PACIENTE"].Value = dr.GetValue(1);
                        dgvAgendamento.Rows[linha].Cells["NOME MEDICO"].Value = dr.GetValue(2);
                        dgvAgendamento.Rows[linha].Cells["DATA"].Value = dr.GetValue(3);
                        dgvAgendamento.Rows[linha].Cells["HORA"].Value = dr.GetValue(4);
                        dgvAgendamento.Rows[linha].Cells["ESPECIALIDADE"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }


                else if (rbCRM.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from AGENDAMENTO where nome_medico like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvAgendamento.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvAgendamento.Rows.Add();
                        dgvAgendamento.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvAgendamento.Rows[linha].Cells["NOME PACIENTE"].Value = dr.GetValue(1);
                        dgvAgendamento.Rows[linha].Cells["NOME MEDICO"].Value = dr.GetValue(2);
                        dgvAgendamento.Rows[linha].Cells["DATA"].Value = dr.GetValue(3);
                        dgvAgendamento.Rows[linha].Cells["HORA"].Value = dr.GetValue(4);
                        dgvAgendamento.Rows[linha].Cells["ESPECIALIDADE"].Value = dr.GetValue(5);
                        linha++;
                    }


                    cmd.Connection.Close();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possivel fazer a consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }

        
    


