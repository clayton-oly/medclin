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
            dgvMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedico.MultiSelect = false;
            dgvMedico.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // dgvPacient.Columns[5].Width = 150;
        }

        public void solonumero(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {


            }




        }


        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {


            }




        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome de Médico!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNome.Focus();

                }
                else if (txtCrm.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira CRM ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCrm.Focus();
                }

                else if (txtCbo.Text == string.Empty)
                {
                    MessageBox.Show("Insira a Cbo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    txtCbo.Focus();
                }
                else
                {

                    Medico C = new Medico();
                    C.Nome = txtNome.Text;
                    C.Crm = txtCrm.Text;
                    C.Cbo = txtCbo.Text;
                    C.Formacao = txtFormacao.Text;
                    C.Especialidade = cmbEspecialidade.Text;
                    C.inserir();
                    txtCodigo.Text = C.Id.ToString();
                    MessageBox.Show("Cliente Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gbPesquisa.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnCadastrar.Enabled = false;
                    btnNovo.Enabled = true;
                    desabilitaControles();
                    limparTela();

                }
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
            txtCrm.Enabled = true;
            txtFormacao.Enabled = true;
            txtCbo.Enabled = true;
            cmbEspecialidade.Enabled = true;
        }

        private void desabilitaControles()
        {
            //desabilitar controles
            txtNome.Enabled = false;
            txtCrm.Enabled = false;
            txtFormacao.Enabled = false;
            txtCbo.Enabled = false;
            cmbEspecialidade.Enabled = false;
           
        }

        private void limparTela()
        {
            //desabilitar controles
            txtNome.Clear();
            txtFormacao.Clear();
            txtCbo.Clear();
            txtCrm.Clear();
            dgvMedico.Rows.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.habilitaControles();
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            gbPesquisa.Enabled = false;
            btnCancelar.Enabled = true;
            limparTela();
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
                txtCrm.Text = dgvMedico.CurrentRow.Cells[2].Value.ToString();
                txtCbo.Text = dgvMedico.CurrentRow.Cells[3].Value.ToString();
                txtFormacao.Text = dgvMedico.CurrentRow.Cells[4].Value.ToString();
                cmbEspecialidade.Text = dgvMedico.CurrentRow.Cells[5].Value.ToString();

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                habilitaControles();
                gbPesquisa.Enabled = false;
                btnCadastrar.Enabled = false;   


            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um Médico válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome de Médico!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNome.Focus();

                }
                else if (txtCrm.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira CRM ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtCrm.Focus();
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
                    comm.Parameters.Add("@crm", SqlDbType.VarChar).Value = txtCrm.Text;
                    comm.Parameters.Add("@cbo", SqlDbType.VarChar).Value = txtCbo.Text;
                    comm.Parameters.Add("@formacao", SqlDbType.VarChar).Value = txtFormacao.Text;
                    comm.Parameters.Add("@especialidade", SqlDbType.VarChar).Value = cmbEspecialidade.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    MessageBox.Show("Dados salvados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    gbPesquisa.Enabled = true;
                    desabilitaControles();
                    limparTela();

                }
            }

             catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os campos novamente", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            gbPesquisa.Enabled = true;
            limparTela();
            btnCadastrar.Enabled = false;
            this.desabilitaControles();

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {
                    sololetras(e);
                    txtValor.MaxLength = 100;

                }

                if (rbCRM.Checked)
                {
                    txtValor.MaxLength = 10;
             

                }
            }
            catch (Exception)
            {


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }
    }
    }

