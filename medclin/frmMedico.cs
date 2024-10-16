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
    public partial class frmCadastroMedico : Form
    {
        public frmCadastroMedico() {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();

        }

        private void CadastrarM_Load(object sender, EventArgs e) {

            cmbEspecialidade.SelectedIndex = 0;
            dgvMedico.ColumnCount = 6;
            dgvMedico.Columns[0].Name = "CÓDIGO";
            dgvMedico.Columns[1].Name = "NOME";
            dgvMedico.Columns[2].Name = "CRM";
            dgvMedico.Columns[3].Name = "CBO";
            dgvMedico.Columns[4].Name = "FORMAÇÃO";
            dgvMedico.Columns[5].Name = "ESPECIALIDADE";

            // dgvPacient.Columns[5].Width = 150;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Medico C = new Medico();
                C.Nome = txtNome.Text;
                C.Crm  = txtCRM.Text;
                C.Cbo = txtCbo.Text;
                C.Formacao = txtFormacao.Text;
                C.Especialidade = cmbEspecialidade.Text;
                C.inserir();
                txtCodigo.Text = C.Id.ToString();
                MessageBox.Show("Cliente Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os campos novamente", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaControles()
        {
            //desabilitar controles
            txtNome.Enabled = true;
            txtCRM.Enabled = true;
            txtFormacao.Enabled = true;
            txtCbo.Enabled = true;
            //especialidadeTextBox.Enabled = true;
            btnCadastrar.Enabled = true;
        }

        private void desabilitaControles()
        {
            //desabilitar controles
            txtNome.Enabled = false;
            txtCRM.Enabled = false;
            txtFormacao.Enabled = false;
            txtCbo.Enabled = false;
            //especialidadeTextBox.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.habilitaControles();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {

                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from MEDICO where nome_medico like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvMedico.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvMedico.Rows.Add();
                        dgvMedico.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvMedico.Rows[linha].Cells["NOME"].Value = dr.GetValue(1);
                        dgvMedico.Rows[linha].Cells["CRM"].Value = dr.GetValue(2);
                        dgvMedico.Rows[linha].Cells["CBO"].Value = dr.GetValue(3);
                        dgvMedico.Rows[linha].Cells["FORMAÇÃO"].Value = dr.GetValue(4);
                        dgvMedico.Rows[linha].Cells["ESPECIALIDADE"].Value = dr.GetValue(5);

                        linha++;
                    }


                    cmd.Connection.Close();
                }


                else if (rbCRM.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from MEDICO where crm like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvMedico.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvMedico.Rows.Add();
                        dgvMedico.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvMedico.Rows[linha].Cells["NOME"].Value = dr.GetValue(1);
                        dgvMedico.Rows[linha].Cells["CRM"].Value = dr.GetValue(2);
                        dgvMedico.Rows[linha].Cells["CBO"].Value = dr.GetValue(3);
                        dgvMedico.Rows[linha].Cells["FORMAÇÃO"].Value = dr.GetValue(4);
                        dgvMedico.Rows[linha].Cells["ESPECIALIDADE"].Value = dr.GetValue(5);
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

        private void dgvMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtCodigo.Text = dgvMedico.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvMedico.CurrentRow.Cells[1].Value.ToString();
                txtCRM.Text = dgvMedico.CurrentRow.Cells[2].Value.ToString();
                txtCbo.Text = dgvMedico.CurrentRow.Cells[3].Value.ToString();
                txtFormacao.Text = dgvMedico.CurrentRow.Cells[4].Value.ToString();
                cmbEspecialidade.Text = dgvMedico.CurrentRow.Cells[5].Value.ToString();

                btnEditar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um fornecedor válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome de usúario!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNome.Focus();

                }
                else if (txtCRM.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira CRM ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCRM.Focus();
                }

                else if (txtCbo.Text == string.Empty)
                {
                    MessageBox.Show("Insira a Cbo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtCbo.Focus();
                }
                else
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraMedico";
                    comm.Parameters.Add("@id_medico", SqlDbType.Int).Value = Convert.ToInt32(txtCodigo.Text);
                    comm.Parameters.Add("@nome_medico", SqlDbType.VarChar).Value = txtNome.Text;
                    comm.Parameters.Add("@crm", SqlDbType.VarChar).Value = txtCRM.Text;
                    comm.Parameters.Add("@cbo", SqlDbType.VarChar).Value = txtCbo.Text;
                    comm.Parameters.Add("@formacao", SqlDbType.VarChar).Value = txtFormacao.Text;
                    comm.Parameters.Add("@especialidade", SqlDbType.VarChar).Value = cmbEspecialidade.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    MessageBox.Show("Dados salvados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Para editar você precisa consultar o usuario antes pelo código", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
   }
  

