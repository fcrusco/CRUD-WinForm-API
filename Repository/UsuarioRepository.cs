using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
}

public class UsuarioRepository
{
    private string connStr = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;

    public List<Usuario> ListarTodos()
    {
        var lista = new List<Usuario>();

        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand("sp_listar_usuarios", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        UsuarioId = (int)reader["UsuarioId"],
                        Nome = reader["Nome"].ToString(),
                        SobreNome = reader["SobreNome"].ToString()
                    });
                }
            }
        }

        return lista;
    }


    public int Inserir(string nome, string sobrenome)
    {
        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand("sp_insert_usuario", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@SobreNome", sobrenome);

            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
                return Convert.ToInt32(reader["UsuarioId"]);

            return 0;
        }
    }

    public void Atualizar(int id, string nome, string sobrenome)
    {
        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand("sp_update_usuario", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UsuarioId", id);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@SobreNome", sobrenome);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void Deletar(int id)
    {
        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand("sp_delete_usuario", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UsuarioId", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
