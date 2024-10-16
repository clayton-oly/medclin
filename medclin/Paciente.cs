using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace medclin
{
    public class Paciente
    {
        //atributos
        private int id;
        private string nome;
        private string rg;
        private string cpf;
        private string idade;
        private string datanasc;
        private string profissao;
        private string raca;
        private string sexo;
        private string estadocivil;
        private string naturalidade;
        private string convenio;
        private string ncarteirinha;
        private string endereco;
        private string cep;
        private string num;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string telefone_fixo;
        private string celular;
        private string celular2;
        private string status_lista;


        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Rg { get { return rg; } set { rg = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Idade { get { return idade; } set { idade = value; } }
        public string Datanasc { get { return datanasc; } set { datanasc = value; } }
        public string Profissao { get { return profissao; } set { profissao = value; } }
        public string Raca { get { return raca; } set { raca = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public string Estadocivil { get { return estadocivil; } set { estadocivil = value; } }
        public string Naturalidade { get { return naturalidade; } set { naturalidade = value; } }
        public string Convenio { get { return convenio; } set { convenio = value; } }
        public string Ncarteirinha { get { return ncarteirinha; } set { ncarteirinha = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Num { get { return num; } set { num = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
        public string Telefone_fixo { get { return telefone_fixo; } set { telefone_fixo = value; } }
        public string Celular { get { return celular; } set { celular = value; } }
        public string Celular2 { get { return celular2; } set { celular2 = value; } }
        public string Status_lista { get { return status_lista; } set { status_lista = value; } }

        //construtores
        public Paciente()
        {

        }
        public Paciente(int _id, string _nome, string _rg, string _cpf, string _idade , string _datanasc, string _profissao, string _raca, string _sexo, string _estadocivil, string _naturalidade, string _convenio, string _ncarteirinha , string _endereco, string _cep, string _num, string _complemento, string _bairro, string _cidade, string _uf, string _telefone_fixo, string _celular, string _celular2, string _status_lista)
        {
            id = _id;
            nome = _nome;
            rg = _rg;
            cpf = _cpf;
            idade = _idade;
            datanasc = _datanasc;
            profissao = _profissao;
            raca = _raca;
            sexo = _sexo;
            estadocivil = _estadocivil;
            naturalidade = _naturalidade;
            convenio = _convenio;
            ncarteirinha = _ncarteirinha;
            endereco = _endereco;
            cep = _cep;
            num = _num;
            complemento = _complemento;
            bairro = _bairro;
            cidade = _cidade;
            uf = _uf;
            telefone_fixo = _telefone_fixo;
            celular = _celular;
            celular2 = _celular2;
            status_lista = _status_lista;


        }
        public void inserir()
        {

            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_inserePaciente";
            comm.Parameters.Add("@nome_paciente", SqlDbType.VarChar).Value = nome;
            comm.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
            comm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            comm.Parameters.Add("@idade", SqlDbType.VarChar).Value = idade;
            comm.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = datanasc;
            comm.Parameters.Add("@profissao", SqlDbType.VarChar).Value = profissao;
            comm.Parameters.Add("@raca", SqlDbType.VarChar).Value = raca;
            comm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            comm.Parameters.Add("@estadocivil ", SqlDbType.VarChar).Value = estadocivil;
            comm.Parameters.Add("@naturalidade ", SqlDbType.VarChar).Value = naturalidade;
            comm.Parameters.Add("@convenio ", SqlDbType.VarChar).Value = convenio;
            comm.Parameters.Add("@ncarteirinha ", SqlDbType.VarChar).Value = ncarteirinha;
            comm.Parameters.Add("@cep", SqlDbType.Char).Value = cep;
            comm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
            comm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            comm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            comm.Parameters.Add("@estado", SqlDbType.Char).Value = uf;
            comm.Parameters.Add("@numero_end", SqlDbType.VarChar).Value = num;
            comm.Parameters.Add("@telefone_fixo", SqlDbType.VarChar).Value = telefone_fixo;
            comm.Parameters.Add("@celular ", SqlDbType.VarChar).Value = celular;
            comm.Parameters.Add("@celular2 ", SqlDbType.VarChar).Value = celular2;
            comm.Parameters.Add("@status_lista", SqlDbType.VarChar).Value = status_lista;

            comm.ExecuteNonQuery();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select @@identity";
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }


    }
}

