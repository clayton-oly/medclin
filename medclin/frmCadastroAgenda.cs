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

        SqlConnection conexao = new SqlConnection("Data Source=ITQ0514104W10-1;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa;Password=senac@itq");

        // SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
        private string strMySQL;

        private void frmCadastroAgenda_Load(object sender, EventArgs e)
        {
            cmbEspecialidade.SelectedIndex = 0;
            dgvAgendamento.ColumnCount = 6;
            dgvAgendamento.Columns[0].Name = "CÓDIGO";
            dgvAgendamento.Columns[1].Name = "NOME PACIENTE";
            dgvAgendamento.Columns[2].Name = "NOME MEDICO";
            dgvAgendamento.Columns[3].Name = "DATA";
            dgvAgendamento.Columns[4].Name = "HORA";
            dgvAgendamento.Columns[5].Name = "ESPECIALIDADE";
            dgvAgendamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendamento.MultiSelect = false;
            dgvAgendamento.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            try
            {
                SqlConnection cn = new SqlConnection();
                //  cn.ConnectionString = (@"Data Source=DESKTOP-PBG1AVM;Initial Catalog=bancoMed;Persist Security Info=True;User ID=sa; Password = D@silva1996@");
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);


                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtHora.TextLength)
                    {

                        case 0:
                            txtHora.Text = "";
                            break;
                        case 2:
                            txtHora.Text = txtHora.Text + ":";
                            txtHora.SelectionStart = 4;

                            break;
                    }

                }

            }
            catch (Exception)
            {

            }
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbPaciente.Checked)
                {

                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from AGENDA where nome_paciente like '%" + nome + "%'";
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


                else if (rbMedico.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from AGENDA where nome_medico like '%" + nome + "%'";
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

                else if (rbCPF.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from AGENDA where id_agenda like '%" + nome + "%'";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNomePaciente.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome do paciente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNomePaciente.Focus();

                }
                else if (txtHora.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira a HORA ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtHora.Focus();
                }
                else
                {
                    Agenda C = new Agenda();
                    C.Nomep = txtNomePaciente.Text;
                    C.Nomem = cmbMedico.Text;
                    C.Data = txtDataa.Text;
                    C.Hora = txtHora.Text;
                    C.Especialidade = cmbEspecialidade.Text;
                    C.inserir();
                    txtCodigo.Text = C.Id.ToString();
                    MessageBox.Show("Consulta agendada com sucesso ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancelar.Enabled = false;
                    btnNovo.Enabled = true;
                    limparTela();
                    btnCadastrar.Enabled = false;
                    gbPesquisar.Enabled = true;
                    desabilitaControles();
                    txtValor.Enabled = true;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.habilitaControles();
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            gbPesquisar.Enabled = false;
            btnCancelar.Enabled = true;
            gpAgendar.Enabled = true;
            limparTela();
        }

        private void habilitaControles()
        {
            //desabilitar controles
            txtValor.Enabled = true;
            txtHora.Enabled = true;
            txtDataa.Enabled = true;
            txtNomePaciente.Enabled = true;
            cmbEspecialidade.Enabled = true;
            cmbMedico.Enabled = true;
        }

        private void desabilitaControles()
        {
            //desabilitar controles
            txtValor.Enabled = false;
            txtHora.Enabled = false;
            txtDataa.Enabled = false;
            txtNomePaciente.Enabled = false;
            cmbEspecialidade.Enabled = false;
            cmbMedico.Enabled = false;

        }

        private void limparTela()
        {
            //desabilitar controles
            txtNomePaciente.Clear();
            txtHora.Clear();
            txtValor.Clear();
            dgvAgendamento.Rows.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            gbPesquisar.Enabled = true;
            limparTela();
            btnCadastrar.Enabled = false;
            desabilitaControles();
            txtValor.Enabled = true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomePaciente.Text == string.Empty)
                {
                    MessageBox.Show("Insira o nome do paciente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    txtNomePaciente.Focus();

                }
                else if (txtHora.Text == string.Empty)
                {

                    MessageBox.Show("Por favor insira a HORA ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txTelefone.BackColor = Color.Red;
                    this.txtHora.Focus();
                }
                else
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraAgenda";
                    comm.Parameters.Add("@id_agenda", SqlDbType.Int).Value  = txtCodigo.Text;
                    comm.Parameters.Add("@nome_paciente", SqlDbType.VarChar).Value = txtNomePaciente.Text;
                    comm.Parameters.Add("@nome_medico", SqlDbType.VarChar).Value = cmbMedico.Text;
                    comm.Parameters.Add("@data ", SqlDbType.VarChar).Value = txtDataa.Text;
                    comm.Parameters.Add("@hora ", SqlDbType.VarChar).Value = txtHora.Text;
                    comm.Parameters.Add("@especialidade", SqlDbType.VarChar).Value = cmbEspecialidade.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    MessageBox.Show("Dados salvados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = false;
                    gbPesquisar.Enabled = true;
                    desabilitaControles();
                    txtValor.Enabled = true;
                    limparTela();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os campos novamente", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (rbCPF.Checked)
                {
                    solonumero(e);
                    txtValor.MaxLength = 10000;


                }

                if (rbPaciente.Checked)
                {
                    sololetras(e);
                    txtValor.MaxLength = 100;

                }

                if (rbPaciente.Checked)
                {
                    sololetras(e);
                    txtValor.MaxLength = 100;
                }
               
            }
            catch (Exception)
            {


            }
        }

        private void txtNomePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }


        private void dgvAgendamento_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvAgendamento.CurrentRow.Cells[0].Value.ToString();
                txtNomePaciente.Text = dgvAgendamento.CurrentRow.Cells[1].Value.ToString();
                cmbMedico.Text = dgvAgendamento.CurrentRow.Cells[2].Value.ToString();
                txtDataa.Text = dgvAgendamento.CurrentRow.Cells[3].Value.ToString();
                txtHora.Text = dgvAgendamento.CurrentRow.Cells[4].Value.ToString();
                cmbEspecialidade.Text = dgvAgendamento.CurrentRow.Cells[5].Value.ToString();

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                habilitaControles();
                gbPesquisar.Enabled = false;
                btnCadastrar.Enabled = false;
            }
            catch (Exception)
            {

            }
        }


        private void consultar_cliente()
        {
            strMySQL = "SELECT * FROM PACIENTE WHERE nome_paciente like '%" + txtNomePaciente.Text + "%'";
            SqlCommand comando = new SqlCommand(strMySQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("PACIENTE NÃO ENCONTRANDO!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomePaciente.Clear();
                    txtNomePaciente.Focus();
                }
                else
                {
                    txtNomePaciente.Text = dr["nome_paciente"].ToString();
                    btnCadastrar.Focus();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtNomePaciente_Validating(object sender, CancelEventArgs e)
        {
            consultar_cliente();
        }
    }
  }

    
 
    


    
