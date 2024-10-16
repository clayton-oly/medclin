using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace medclin
{
    public class Medico
    {
        //atributos
    private int id;
    private string nome;
    private string crm;
    private string cbo;
    private string formacao;
    private string especialidade;



    //propriedades
    public int Id { get { return id; } set { id = value; } }
    public string Nome { get { return nome; } set { nome = value; } }
    public string Crm { get { return crm; } set { crm = value; } }
    public string Cbo { get { return cbo; } set { cbo = value; } }
    public string Formacao { get { return formacao; } set { formacao = value; } }
    public string Especialidade { get { return especialidade; } set { especialidade = value; } }

    //construtores
    public Medico()
    {

    }
    public Medico (int _id, string _nome, string _crm, string _cbo, string _formacao, string _especialidade)
    {
        id = _id;
        nome = _nome;
        crm = _crm;
        cbo = _cbo;
        formacao = _formacao;
        especialidade = _especialidade;


    }
    public void inserir()
    {

        SqlCommand comm = new SqlCommand();
        comm.Connection = Banco.abrir();
        comm.CommandType = CommandType.StoredProcedure;
        comm.CommandText = "sp_insereMedico";
        comm.Parameters.Add("@nome_medico", SqlDbType.VarChar).Value = nome;
        comm.Parameters.Add("@crm ", SqlDbType.VarChar).Value = crm;
        comm.Parameters.Add("@cbo ", SqlDbType.VarChar).Value = cbo;
        comm.Parameters.Add("@formacao ", SqlDbType.VarChar).Value = formacao;
        comm.Parameters.Add("@especialidade ", SqlDbType.VarChar).Value = especialidade;
        comm.ExecuteNonQuery();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select @@identity";
        id = Convert.ToInt32(comm.ExecuteScalar());
        comm.Connection.Close();

    }


}
}