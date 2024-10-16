using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace medclin
{
    public class Agenda
    {
        //atributos
        private int id;
        private string nomep;
        private string nomem;
        private string data;
        private string hora;
        private string especialidade;



        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nomep { get { return nomep; } set { nomep = value; } }
        public string Nomem { get { return nomem; } set { nomem = value; } }
        public string Data { get { return data; } set { data = value; } }
        public string Hora { get { return hora; } set { hora = value; } }
        public string Especialidade { get { return especialidade; } set { especialidade = value; } }

        //construtores
        public Agenda()
        {

        }
        public Agenda(int _id, string _nomep, string _nomem, string _data, string _hora, string _especialidade)
        {
            id = _id;
            nomep = _nomep;
            nomem = _nomem;
            data = _data;
            hora = _hora;
            especialidade = _especialidade;


        }
        public void inserir()
        {

            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_insereAgenda";
            comm.Parameters.Add("@nome_paciente", SqlDbType.VarChar).Value = nomep;
            comm.Parameters.Add("@nome_medico", SqlDbType.VarChar).Value = nomem;
            comm.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
            comm.Parameters.Add("@hora", SqlDbType.VarChar).Value = hora;
            comm.Parameters.Add("@especialidade", SqlDbType.VarChar).Value = especialidade;
            comm.ExecuteNonQuery();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select @@identity";
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }


    }
}