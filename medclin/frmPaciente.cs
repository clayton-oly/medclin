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
    public partial class frmCadastroPaciente : Form
    {
        public frmCadastroPaciente() {
            InitializeComponent();
        }


        private void CadastroP_Load(object sender, EventArgs e) {
            cmbSexo.SelectedIndex = 0;

        }

        public void habilitaTela()
        {
            //habilitar tela


            txtNome.Enabled = true;
            txtData.Enabled = true;
            txtIdade.Enabled = true;
            txtProfissao.Enabled = true;
            txtRg.Enabled = true;
            txtCPF.Enabled = true;
            txtCor.Enabled = true;
            cmbSexo.Enabled = true;
            txtEstadoCivil.Enabled = true;
            txtNatu.Enabled = true;
            txtParticular.Enabled = true;
            txtConvenio.Enabled = true;
            txtNatu.Enabled = true;
            txtEnd.Enabled = true;
            txtNum.Enabled = true;
            txtCep.Enabled = true;
            txtBairro.Enabled = true;
            txtUf.Enabled = true;
            txtCidade.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtCelular2.Enabled = true;
       
            bunifuFlatButton1.Enabled = true;

            // desabilitar imagem click


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


        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            try
            {

                Paciente C = new Paciente();
                C.Nome = txtNome.Text;
                C.Rg = txtRg.Text;
                C.Cpf = txtCPF.Text;
                C.Idade = txtIdade.Text;
                C.Datanasc = txtData.Text;
                C.Profissao = txtProfissao.Text;
                C.Raca = txtCor.Text;
                C.Sexo = cmbSexo.Text;
                C.Estadocivil = txtEstadoCivil.Text;
                C.Naturalidade = txtNatu.Text;
                C.Convenio = txtConvenio.Text;
                C.Ncarteirinha = txtNcarteirinha.Text;
                C.Cep = txtCep.Text;
                C.Endereco = txtEnd.Text;
                C.Bairro = txtBairro.Text;
                C.Cidade = txtCidade.Text;
                C.Uf = txtUf.Text;
                C.Num = txtNum.Text;
                C.Telefone_fixo = txtTelefone.Text;
                C.Celular = txtCelular.Text;
                C.Celular2 = txtCelular2.Text;
                //C.Status_lista = statusTextBox.Text;


                C.inserir();
                txtCodigo.Text = C.Id.ToString();
                MessageBox.Show("Cliente Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
            catch (Exception )
            {
                MessageBox.Show("Ocorreu um erro verifique os campos novamente", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.habilitaTela();
        }

        private void cEPTextBox_TextChanged(object sender, EventArgs e)
        {
            WebCEP(txtCep.Text);
        }


        public void WebCEP(string CEP)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" +
                CEP.Replace("-", "").Trim() + "&formato=xml");
            txtEnd.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() +
                " " + ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
            txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
            txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
            txtUf.Text = ds.Tables[0].Rows[0]["uf"].ToString().Trim();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

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
                    cmd.CommandText = "select * from cliente where nome_cliente like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvPacient.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvPacient.Rows.Add();
                        dgvPacient.Rows[linha].Cells["clnId"].Value = dr.GetValue(0);
                        dgvPacient.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvPacient.Rows[linha].Cells["clnCPF"].Value = dr.GetValue(2);
                        dgvPacient.Rows[linha].Cells["clnData"].Value = dr.GetValue(3);
                        dgvPacient.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvPacient.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);
                        dgvPacient.Rows[linha].Cells["clnCEP"].Value = dr.GetValue(6);
                        dgvPacient.Rows[linha].Cells["clnEnd"].Value = dr.GetValue(7);
                        dgvPacient.Rows[linha].Cells["clnBairro"].Value = dr.GetValue(8);
                        dgvPacient.Rows[linha].Cells["clnCompl"].Value = dr.GetValue(9);
                        dgvPacient.Rows[linha].Cells["clnCidade"].Value = dr.GetValue(10);
                        dgvPacient.Rows[linha].Cells["clnEstado"].Value = dr.GetValue(11);
                        dgvPacient.Rows[linha].Cells["clnNum"].Value = dr.GetValue(12);

                        linha++;
                    }


                    cmd.Connection.Close();
                }


                else if (rbCPF.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from cliente where cpf like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvPacient.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvPacient.Rows.Add();
                        dgvPacient.Rows[linha].Cells["clnId"].Value = dr.GetValue(0);
                        dgvPacient.Rows[linha].Cells["clnNome"].Value = dr.GetValue(1);
                        dgvPacient.Rows[linha].Cells["clnCPF"].Value = dr.GetValue(2);
                        dgvPacient.Rows[linha].Cells["clnData"].Value = dr.GetValue(3);
                        dgvPacient.Rows[linha].Cells["clnTelefone"].Value = dr.GetValue(4);
                        dgvPacient.Rows[linha].Cells["clnEmail"].Value = dr.GetValue(5);
                        dgvPacient.Rows[linha].Cells["clnCEP"].Value = dr.GetValue(6);
                        dgvPacient.Rows[linha].Cells["clnEnd"].Value = dr.GetValue(7);
                        dgvPacient.Rows[linha].Cells["clnBairro"].Value = dr.GetValue(8);
                        dgvPacient.Rows[linha].Cells["clnCompl"].Value = dr.GetValue(9);
                        dgvPacient.Rows[linha].Cells["clnCidade"].Value = dr.GetValue(10);
                        dgvPacient.Rows[linha].Cells["clnEstado"].Value = dr.GetValue(11);
                        dgvPacient.Rows[linha].Cells["clnNum"].Value = dr.GetValue(12);
                        linha++;
                    }


                    cmd.Connection.Close();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possivel fazer a consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtNome.Focus();

                }

                else if (txtCPF.Text == string.Empty)
                {
                    MessageBox.Show("campo CPF vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCPF.Focus();
                }


                else
                {

                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Banco.abrir();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "sp_alteraPaciente";
                    comm.Parameters.Add("@id_paciente", SqlDbType.Int).Value = txtCodigo.Text;
                    comm.Parameters.Add("@nome_paciente", SqlDbType.VarChar).Value = txtNome.Text;
                    comm.Parameters.Add("@rg", SqlDbType.Char).Value = txtRg.Text;
                    comm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPF.Text;
                    comm.Parameters.Add("@idade", SqlDbType.VarChar).Value = txtIdade.Text;
                    comm.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = txtData.Text;
                    comm.Parameters.Add("@profissao", SqlDbType.VarChar).Value = txtProfissao.Text;
                    comm.Parameters.Add("@raca", SqlDbType.VarChar).Value = txtCor.Text;
                    comm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = cmbSexo.Text;
                    comm.Parameters.Add("@estadocivil", SqlDbType.VarChar).Value = txtEstadoCivil.Text;
                    comm.Parameters.Add("@naturalidade", SqlDbType.VarChar).Value = txtNatu.Text;
                    comm.Parameters.Add("@convenio", SqlDbType.VarChar).Value = txtConvenio.Text;
                    comm.Parameters.Add("@ncarteirinha", SqlDbType.VarChar).Value = txtNcarteirinha.Text;
                    comm.Parameters.Add("@cep", SqlDbType.Char).Value = txtCep.Text;
                    comm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEnd.Text;
                    comm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                    comm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                    comm.Parameters.Add("@estado", SqlDbType.Char).Value = txtUf.Text;
                    comm.Parameters.Add("@numero_end", SqlDbType.VarChar).Value = txtNum.Text;
                    comm.Parameters.Add("@telefone_fixo", SqlDbType.VarChar).Value = txtTelefone.Text;
                    comm.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCelular.Text;
                    comm.Parameters.Add("@celular2", SqlDbType.VarChar).Value = txtCelular2.Text;
                    comm.Parameters.Add("@status_lista", SqlDbType.VarChar).Value = cmbStatus.Text;
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel salvar dados, verifique se os campos foi preenchido corretamente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
    
}
