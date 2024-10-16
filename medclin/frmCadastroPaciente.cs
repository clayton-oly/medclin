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
            cmbStatus.SelectedIndex = 0;
            dgvPaciente.ColumnCount = 23;
            dgvPaciente.Columns[0].Name = "CÓDIGO";
            dgvPaciente.Columns[1].Name = "NOME";
            dgvPaciente.Columns[2].Name = "RG";
            dgvPaciente.Columns[3].Name = "CPF";
            dgvPaciente.Columns[4].Name = "IDADE";
            dgvPaciente.Columns[5].Name = "DATA DE NASCIMENTO";
            dgvPaciente.Columns[6].Name = "PROFISSÃO";
            dgvPaciente.Columns[7].Name = "RAÇA";
            dgvPaciente.Columns[8].Name = "SEXO";
            dgvPaciente.Columns[9].Name = "ESTADOCIVIL";
            dgvPaciente.Columns[10].Name = "NATURALIDADE";
            dgvPaciente.Columns[11].Name = "CONVENIO";
            dgvPaciente.Columns[12].Name = "NCARTEIRINHA";
            dgvPaciente.Columns[13].Name = "CEP";
            dgvPaciente.Columns[14].Name = "ENDEREÇO";
            dgvPaciente.Columns[15].Name = "BAIRRO";
            dgvPaciente.Columns[16].Name = "CIDADE";
            dgvPaciente.Columns[17].Name = "ESTADO";
            dgvPaciente.Columns[18].Name = "NUMERO";
            dgvPaciente.Columns[19].Name = "TELEFONE";
            dgvPaciente.Columns[20].Name = "CELULAR";
            dgvPaciente.Columns[21].Name = "CELULAR2";
            dgvPaciente.Columns[22].Name = "STATUS";

            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.MultiSelect = false;
            dgvPaciente.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // dgvPacient.Columns[5].Width = 150;


            gbPaciente.Enabled = false;

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
            txtConvenio.Enabled = true;
            txtNatu.Enabled = true;
            txtEnd.Enabled = true;
            txtNum.Enabled = true;
            txtCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtUf.Enabled = true;
            txtCidade.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtCelular2.Enabled = true;

        }

        public void limpaTela()
        {
            //habilitar tela

            txtCodigo.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtProfissao.Clear();
            txtRg.Clear();
            txtCPF.Clear();
            txtCor.Clear();
            txtEstadoCivil.Clear();
            txtNatu.Clear();
            txtConvenio.Clear();
            txtNatu.Clear();
            txtEnd.Clear();
            txtNcarteirinha.Clear();
            txtNum.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtUf.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCelular2.Clear();
            dgvPaciente.Rows.Clear();

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
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtCPFCNPJ.BackColor = Color.Red;
                    this.txtNome.Focus();

                }
                else if (txtRg.Text == string.Empty)
                {
                    MessageBox.Show("campo RG vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtRg.Focus();
                }

                else if (txtCPF.Text == string.Empty)
                {
                    MessageBox.Show("campo CPF vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtNome.BackColor = Color.Red;
                    this.txtCPF.Focus();
                }

                else
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
                    C.Cep = txtCEP.Text;
                    C.Endereco = txtEnd.Text;
                    C.Bairro = txtBairro.Text;
                    C.Cidade = txtCidade.Text;
                    C.Uf = txtUf.Text;
                    C.Num = txtNum.Text;
                    C.Telefone_fixo = txtTelefone.Text;
                    C.Celular = txtCelular.Text;
                    C.Celular2 = txtCelular2.Text;
                    C.Status_lista = cmbStatus.Text;


                    C.inserir();
                    txtCodigo.Text = C.Id.ToString();
                    MessageBox.Show("Paciente Cadastrado com sucesso!", " Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTela();
                    gbPaciente.Enabled = false;
                    btnCadastrar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnNovo.Enabled = true;
                    gbPesquisa.Enabled = true;



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Paciente com esse RG ou CPF já esta cadastrado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void cEPTextBox_TextChanged(object sender, EventArgs e)
        {
            WebCEP(txtCEP.Text);
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

        private void dgvPacient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                gbPaciente.Enabled = true;
                btnNovo.Enabled = false;

            }
            catch (Exception)
            {

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
                    comm.Parameters.Add("@cep", SqlDbType.Char).Value = txtCEP.Text;
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


                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = false;
                    gbPaciente.Enabled = false;
                    btnNovo.Enabled = true;
                    gbPesquisa.Enabled = true;
                    limpaTela();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel salvar dados, verifique se os campos foi preenchido corretamente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            gbPaciente.Enabled = true;
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtCodigo.Enabled = false;
            gbPesquisa.Enabled = false;
            limpaTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbPaciente.Enabled = false;
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtCodigo.Enabled = false;
            btnEditar.Enabled = false;
            limpaTela();
            gbPesquisa.Enabled = true;
        }

        private void gbPesquisa_Enter(object sender, EventArgs e)
        {

        }

  

        private void label1_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "select * from PACIENTE where nome_paciente like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvPaciente.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvPaciente.Rows.Add();
                        dgvPaciente.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvPaciente.Rows[linha].Cells["NOME"].Value = dr.GetValue(1);
                        dgvPaciente.Rows[linha].Cells["RG"].Value = dr.GetValue(2);
                        dgvPaciente.Rows[linha].Cells["CPF"].Value = dr.GetValue(3);
                        dgvPaciente.Rows[linha].Cells["IDADE"].Value = dr.GetValue(4);
                        dgvPaciente.Rows[linha].Cells["DATA DE NASCIMENTO"].Value = dr.GetValue(5);
                        dgvPaciente.Rows[linha].Cells["PROFISSÃO"].Value = dr.GetValue(6);
                        dgvPaciente.Rows[linha].Cells["RAÇA"].Value = dr.GetValue(7);
                        dgvPaciente.Rows[linha].Cells["SEXO"].Value = dr.GetValue(8);
                        dgvPaciente.Rows[linha].Cells["ESTADOCIVIL"].Value = dr.GetValue(9);
                        dgvPaciente.Rows[linha].Cells["NATURALIDADE"].Value = dr.GetValue(10);
                        dgvPaciente.Rows[linha].Cells["CONVENIO"].Value = dr.GetValue(11);
                        dgvPaciente.Rows[linha].Cells["NCARTEIRINHA"].Value = dr.GetValue(12);
                        dgvPaciente.Rows[linha].Cells["CEP"].Value = dr.GetValue(13);
                        dgvPaciente.Rows[linha].Cells["ENDEREÇO"].Value = dr.GetValue(14);
                        dgvPaciente.Rows[linha].Cells["BAIRRO"].Value = dr.GetValue(15);
                        dgvPaciente.Rows[linha].Cells["CIDADE"].Value = dr.GetValue(16);
                        dgvPaciente.Rows[linha].Cells["ESTADO"].Value = dr.GetValue(17);
                        dgvPaciente.Rows[linha].Cells["NUMERO"].Value = dr.GetValue(18);
                        dgvPaciente.Rows[linha].Cells["TELEFONE"].Value = dr.GetValue(19);
                        dgvPaciente.Rows[linha].Cells["CELULAR"].Value = dr.GetValue(20);
                        dgvPaciente.Rows[linha].Cells["CELULAR2"].Value = dr.GetValue(21);
                        dgvPaciente.Rows[linha].Cells["STATUS"].Value = dr.GetValue(22);

                        linha++;
                    }


                    cmd.Connection.Close();
                }


                else if (rbCPF.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from PACIENTE where CPF like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvPaciente.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvPaciente.Rows.Add();
                        dgvPaciente.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvPaciente.Rows[linha].Cells["NOME"].Value = dr.GetValue(1);
                        dgvPaciente.Rows[linha].Cells["RG"].Value = dr.GetValue(2);
                        dgvPaciente.Rows[linha].Cells["CPF"].Value = dr.GetValue(3);
                        dgvPaciente.Rows[linha].Cells["IDADE"].Value = dr.GetValue(4);
                        dgvPaciente.Rows[linha].Cells["DATA DE NASCIMENTO"].Value = dr.GetValue(5);
                        dgvPaciente.Rows[linha].Cells["PROFISSÃO"].Value = dr.GetValue(6);
                        dgvPaciente.Rows[linha].Cells["RAÇA"].Value = dr.GetValue(7);
                        dgvPaciente.Rows[linha].Cells["SEXO"].Value = dr.GetValue(8);
                        dgvPaciente.Rows[linha].Cells["ESTADOCIVIL"].Value = dr.GetValue(9);
                        dgvPaciente.Rows[linha].Cells["NATURALIDADE"].Value = dr.GetValue(10);
                        dgvPaciente.Rows[linha].Cells["CONVENIO"].Value = dr.GetValue(11);
                        dgvPaciente.Rows[linha].Cells["NCARTEIRINHA"].Value = dr.GetValue(12);
                        dgvPaciente.Rows[linha].Cells["CEP"].Value = dr.GetValue(13);
                        dgvPaciente.Rows[linha].Cells["ENDEREÇO"].Value = dr.GetValue(14);
                        dgvPaciente.Rows[linha].Cells["BAIRRO"].Value = dr.GetValue(15);
                        dgvPaciente.Rows[linha].Cells["CIDADE"].Value = dr.GetValue(16);
                        dgvPaciente.Rows[linha].Cells["ESTADO"].Value = dr.GetValue(17);
                        dgvPaciente.Rows[linha].Cells["NUMERO"].Value = dr.GetValue(18);
                        dgvPaciente.Rows[linha].Cells["TELEFONE"].Value = dr.GetValue(19);
                        dgvPaciente.Rows[linha].Cells["CELULAR"].Value = dr.GetValue(20);
                        dgvPaciente.Rows[linha].Cells["CELULAR2"].Value = dr.GetValue(21);
                        dgvPaciente.Rows[linha].Cells["STATUS"].Value = dr.GetValue(22);


                        linha++;
                    }


                    cmd.Connection.Close();

                }

                else if (rbCodigo.Checked)
                {
                    string nome = txtValor.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Banco.abrir();
                    cmd.CommandText = "select * from PACIENTE where id_paciente like '%" + nome + "%'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dgvPaciente.Rows.Clear();
                    int linha = 0;
                    while (dr.Read())

                    {
                        dgvPaciente.Rows.Add();
                        dgvPaciente.Rows[linha].Cells["CÓDIGO"].Value = dr.GetValue(0);
                        dgvPaciente.Rows[linha].Cells["NOME"].Value = dr.GetValue(1);
                        dgvPaciente.Rows[linha].Cells["RG"].Value = dr.GetValue(2);
                        dgvPaciente.Rows[linha].Cells["CPF"].Value = dr.GetValue(3);
                        dgvPaciente.Rows[linha].Cells["IDADE"].Value = dr.GetValue(4);
                        dgvPaciente.Rows[linha].Cells["DATA DE NASCIMENTO"].Value = dr.GetValue(5);
                        dgvPaciente.Rows[linha].Cells["PROFISSÃO"].Value = dr.GetValue(6);
                        dgvPaciente.Rows[linha].Cells["RAÇA"].Value = dr.GetValue(7);
                        dgvPaciente.Rows[linha].Cells["SEXO"].Value = dr.GetValue(8);
                        dgvPaciente.Rows[linha].Cells["ESTADOCIVIL"].Value = dr.GetValue(9);
                        dgvPaciente.Rows[linha].Cells["NATURALIDADE"].Value = dr.GetValue(10);
                        dgvPaciente.Rows[linha].Cells["CONVENIO"].Value = dr.GetValue(11);
                        dgvPaciente.Rows[linha].Cells["NCARTEIRINHA"].Value = dr.GetValue(12);
                        dgvPaciente.Rows[linha].Cells["CEP"].Value = dr.GetValue(13);
                        dgvPaciente.Rows[linha].Cells["ENDEREÇO"].Value = dr.GetValue(14);
                        dgvPaciente.Rows[linha].Cells["BAIRRO"].Value = dr.GetValue(15);
                        dgvPaciente.Rows[linha].Cells["CIDADE"].Value = dr.GetValue(16);
                        dgvPaciente.Rows[linha].Cells["ESTADO"].Value = dr.GetValue(17);
                        dgvPaciente.Rows[linha].Cells["NUMERO"].Value = dr.GetValue(18);
                        dgvPaciente.Rows[linha].Cells["TELEFONE"].Value = dr.GetValue(19);
                        dgvPaciente.Rows[linha].Cells["CELULAR"].Value = dr.GetValue(20);
                        dgvPaciente.Rows[linha].Cells["CELULAR2"].Value = dr.GetValue(21);
                        dgvPaciente.Rows[linha].Cells["STATUS"].Value = dr.GetValue(22);


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

        private void dgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvPaciente.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
                txtRg.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
                txtCPF.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
                txtIdade.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
                txtData.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();
                txtProfissao.Text = dgvPaciente.CurrentRow.Cells[6].Value.ToString();
                txtCor.Text = dgvPaciente.CurrentRow.Cells[7].Value.ToString();
                cmbSexo.Text = dgvPaciente.CurrentRow.Cells[8].Value.ToString();
                txtEstadoCivil.Text = dgvPaciente.CurrentRow.Cells[9].Value.ToString();
                txtNatu.Text = dgvPaciente.CurrentRow.Cells[10].Value.ToString();
                txtConvenio.Text = dgvPaciente.CurrentRow.Cells[11].Value.ToString();
                txtNcarteirinha.Text = dgvPaciente.CurrentRow.Cells[12].Value.ToString();
                txtCEP.Text = dgvPaciente.CurrentRow.Cells[13].Value.ToString();
                txtEnd.Text = dgvPaciente.CurrentRow.Cells[14].Value.ToString();
                txtBairro.Text = dgvPaciente.CurrentRow.Cells[15].Value.ToString();
                txtCidade.Text = dgvPaciente.CurrentRow.Cells[16].Value.ToString();
                txtUf.Text = dgvPaciente.CurrentRow.Cells[17].Value.ToString();
                txtNum.Text = dgvPaciente.CurrentRow.Cells[18].Value.ToString();
                txtTelefone.Text = dgvPaciente.CurrentRow.Cells[19].Value.ToString();
                txtCelular.Text = dgvPaciente.CurrentRow.Cells[20].Value.ToString();
                txtCelular.Text = dgvPaciente.CurrentRow.Cells[21].Value.ToString();
                cmbStatus.Text = dgvPaciente.CurrentRow.Cells[22].Value.ToString();

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                gbPaciente.Enabled = true;
                gbPesquisa.Enabled = false;
                btnCadastrar.Enabled = false;


            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um Médico válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (rbCPF.Checked)
                {
                    solonumero(e);
                    txtValor.MaxLength = 14;
                    if (char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                    }


                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (txtValor.TextLength)
                        {

                            case 0:
                                txtValor.Text = "";
                                break;

                            case 3:
                                txtValor.Text = txtValor.Text + ".";
                                txtValor.SelectionStart = 5;
                                break;

                            case 7:
                                txtValor.Text = txtValor.Text + ".";
                                txtValor.SelectionStart = 9;
                                break;

                            case 11:
                                txtValor.Text = txtValor.Text + "/";
                                txtValor.SelectionStart = 12;
                                break;

                        }


                    }

                }

                else if (rbNome.Checked)
                {
                    sololetras(e);
                    txtValor.MaxLength = 100; 
                }


                else if (rbCodigo.Checked)
                {
                    solonumero(e);
                    txtValor.MaxLength = 5;

                }

            }

            catch (Exception)
            {

                MessageBox.Show("Não foi possivel consultar dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCelular.TextLength)
                    {

                        case 0:
                            txtCelular.Text = "(";
                            txtCelular.SelectionStart = 2;
                            break;

                        case 3:
                            txtCelular.Text = txtCelular.Text + ")";
                            txtCelular.SelectionStart = 5;
                            break;

                        case 9:
                            txtCelular.Text = txtCelular.Text + "-";
                            txtCelular.SelectionStart = 11;
                            break;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtCelular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCelular2.TextLength)
                    {

                        case 0:
                            txtCelular2.Text = "(";
                            txtCelular2.SelectionStart = 2;
                            break;

                        case 3:
                            txtCelular2.Text = txtCelular2.Text + ")";
                            txtCelular2.SelectionStart = 5;
                            break;

                        case 9:
                            txtCelular2.Text = txtCelular2.Text + "-";
                            txtCelular2.SelectionStart = 11;
                            break;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                solonumero(e);

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtTelefone.TextLength)
                    {

                        case 0:
                            txtTelefone.Text = "(";
                            txtTelefone.SelectionStart = 2;
                            break;

                        case 3:
                            txtTelefone.Text = txtTelefone.Text + ")";
                            txtTelefone.SelectionStart = 5;
                            break;

                        case 8:
                            txtTelefone.Text = txtTelefone.Text + "-";
                            txtTelefone.SelectionStart = 10;
                            break;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
           solonumero(e);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtNatu_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }
    }
    
 }

    





    
 

    

