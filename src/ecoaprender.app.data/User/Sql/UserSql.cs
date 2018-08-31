namespace ecoaprender.app.data.User.Sql {
    public class UserSql {
        public string Login () {
            string sql =
                " SELECT Usuario.Id" +
                "      , Usuario.Nome" +
                "      , Usuario.Email" +
                "      , Usuario.Senha" +
                "      , Usuario.EscolaId " +
                "      , Aluno.Id as AlunoId " +
                "      , Aluno.Nome as AlunoNome " +
                "      , Grupo.Id as GrupoId " +
                "      , Grupo.Descricao as GrupoDescricao " +
                " FROM Usuario " +
                " INNER JOIN AlunoPais on AlunoPais.UsuarioId = Usuario.Id " +
                " INNER JOIN Aluno on Aluno.Id = AlunoPais.AlunoId " +
                " INNER JOIN Grupo on Grupo.Id = Aluno.GrupoId " +
                " WHERE Email = @Email " +
                "   AND Senha = @Password";

            return sql;
        }
    }
}