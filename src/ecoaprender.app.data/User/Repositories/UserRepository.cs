using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using ecoaprender.app.data.User.Sql;
using ecoaprender.app.domain.Student.Dtos;
using ecoaprender.app.domain.User.Dtos;
using ecoaprender.app.domain.User.Interfaces;

namespace ecoaprender.app.data.User.Repositories {

    public class UserRepository : BaseRepository, IUserRepository {

        private readonly UserSql _userSql;

        public UserRepository (UserSql userSql) {
            _userSql = userSql;
        }

        public UserLoginResponse Login (UserLoginRequest userLoginRequest) {
            var userLoginResponse = new UserLoginResponse ();
            using (SqlConnection conn = new SqlConnection (ConnectionString ())) {
                using (var cmd = new SqlCommand ()) {
                    cmd.Connection = conn;
                    cmd.CommandText = _userSql.Login ();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue ("@Email", GetDbValue (userLoginRequest.Email));
                    cmd.Parameters.AddWithValue ("@Password", GetDbValue (userLoginRequest.Password));

                    conn.Open ();
                    using (DbDataReader dr = cmd.ExecuteReader ()) {

                        var count = 1;

                        while (dr.Read ()) {

                            if (count == 1) {
                                userLoginResponse.Id = Convert.ToInt32 (dr["Id"].ToString ());
                                userLoginResponse.SchoolId = Convert.ToInt32 (dr["EscolaId"].ToString ());
                                userLoginResponse.Name = dr["Nome"].ToString ();
                                userLoginResponse.Email = dr["Email"].ToString ();
                                userLoginResponse.Students = new List<Student> ();
                                count++;
                            }

                            var student = new Student () {
                                Id = Convert.ToInt32 (dr["AlunoId"].ToString ()),
                                Name = dr["AlunoNome"].ToString (),
                                Group = new Group {
                                    Id = Convert.ToInt32 (dr["GrupoId"].ToString ()),
                                    Description = dr["GrupoDescricao"].ToString ()
                                }
                            };

                            userLoginResponse.Students.Add (student);
                        }
                    }
                }
            }

            return userLoginResponse;

        }
    }
}