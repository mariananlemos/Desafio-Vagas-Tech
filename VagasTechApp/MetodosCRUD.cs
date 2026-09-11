// pessoa 4 - Marcia Moreira

using System;
using Microsoft.Data.Sqlite;

public static class MetodosCRUD
{
    // =========================================================
    // --- 1. CREATE (Cadastrar Vaga) ---
    // =========================================================
    public static void CadastrarVaga(SqliteConnection conexao, int id, string titulo, string empresa, decimal salario)
    {
        var sql = "INSERT INTO VAGAS (ID_VAGA, TITULO, EMPRESA, SALARIO) VALUES (@id, @titulo, @empresa, @salario);";
        using (var comando = new SqliteCommand(sql, conexao))
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@salario", salario);
            comando.ExecuteNonQuery();
        }
    }

    // =========================================================
    // --- 2. CREATE (para CADASTRAR Candidata) ---
    // =========================================================
    public static void CadastrarCandidata(SqliteConnection conexao, int id, string nome, string email)
    {
        var sql = "INSERT INTO CANDIDATAS (ID_CANDIDATA, NOME, EMAIL) VALUES (@id, @nome, @email);";
        using (var comando = new SqliteCommand(sql, conexao))
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
        }
    }

    // =========================================================
    // --- 3. CREATE (para ENVIAR Candidatura) ---
    // =========================================================
    public static void EnviarCandidatura(SqliteConnection conexao, int idCandidatura, string dataEnvio, int idVaga, int idCandidata)
    {
        var sql = "INSERT INTO CANDIDATURAS (ID_CANDIDATURA, DATA_ENVIO, ID_VAGA, ID_CANDIDATA) VALUES (@idCandidatura, @dataEnvio, @idVaga, @idCandidata);";
        using (var comando = new SqliteCommand(sql, conexao))
        {
            comando.Parameters.AddWithValue("@idCandidatura", idCandidatura);
            comando.Parameters.AddWithValue("@dataEnvio", dataEnvio);
            comando.Parameters.AddWithValue("@idVaga", idVaga);
            comando.Parameters.AddWithValue("@idCandidata", idCandidata);
            comando.ExecuteNonQuery();
        }
    }

    // =========================================================
    // --- 4. READ (para CONSULTAR Candidaturas com INNER JOIN) ---
    // =========================================================
    public static void ConsultarCandidaturas(SqliteConnection conexao)
    {
        var sql = @"
            SELECT CANDIDATURAS.DATA_ENVIO, VAGAS.TITULO, VAGAS.EMPRESA, VAGAS.SALARIO, CANDIDATAS.NOME AS NOME_CANDIDATA, CANDIDATAS.EMAIL
            FROM CANDIDATURAS
            INNER JOIN VAGAS      ON VAGAS.ID_VAGA           = CANDIDATURAS.ID_VAGA
            INNER JOIN CANDIDATAS ON CANDIDATAS.ID_CANDIDATA = CANDIDATURAS.ID_CANDIDATA;";

        using (var comando = new SqliteCommand(sql, conexao))
        {
            using (var leitor = comando.ExecuteReader())
            {
                Console.WriteLine("\n=== CANDIDATURAS CADASTRADAS ===");
                while (leitor.Read())
                {
                    Console.WriteLine($"Data: {leitor["DATA_ENVIO"]} | Vaga: {leitor["TITULO"]} | Empresa: {leitor["EMPRESA"]} | Salário: {leitor["SALARIO"]} | Candidata: {leitor["NOME_CANDIDATA"]} | Email: {leitor["EMAIL"]}");
                }
                Console.WriteLine("=================================\n");
            }
        }
    }

    // =========================================================
    // --- 5. UPDATE (para ATUALIZAR Salário da Vaga) ---
    // =========================================================
    public static void AtualizarSalarioVaga(SqliteConnection conexao, int idVaga, decimal novoSalario)
    {
        var sql = "UPDATE VAGAS SET SALARIO = @salario WHERE ID_VAGA = @id;";
        using (var comando = new SqliteCommand(sql, conexao))
        {
            comando.Parameters.AddWithValue("@salario", novoSalario);
            comando.Parameters.AddWithValue("@id", idVaga);
            comando.ExecuteNonQuery();
        }
    }

    // =========================================================
    // --- 6. DELETE (para CANCELAR Candidatura) ---
    // =========================================================
    public static void CancelarCandidatura(SqliteConnection conexao, int idCandidatura)
    {
        var sql = "DELETE FROM CANDIDATURAS WHERE ID_CANDIDATURA = @id;";
        using (var comando = new SqliteCommand(sql, conexao))
        {
            comando.Parameters.AddWithValue("@id", idCandidatura);
            comando.ExecuteNonQuery();
        }
    }
}
