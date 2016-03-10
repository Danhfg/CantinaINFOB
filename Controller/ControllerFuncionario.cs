using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ModelCantina;

namespace Controller
{
    public class ControllerFuncionario
    {
        public bool GravarFuncionario(Funcionario func)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into tbl_funcionario (nome_funcionario,matricula_funcionario) values(@nome,@matricula)";
            comando.Parameters.AddWithValue("@nome", func.Nome);
            comando.Parameters.AddWithValue("@matricula", func.Matricula);
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }
    }
}
