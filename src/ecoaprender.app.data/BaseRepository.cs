using System;

namespace ecoaprender.app.data
{
    public class BaseRepository
    {
        public string ConnectionString () {
            return "Data Source=sql4.porta80.com.br;Initial Catalog=ecoaprender;Integrated Security=False;User ID=ecoaprender;Password=ahv5G2pH4a@;MultipleActiveResultSets=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True";
        }

        public string GetDbValue (string value) {
            return string.IsNullOrEmpty (value) ? string.Empty : value.Trim ();
        }

        public int GetDbValue (int? value) {
            return value == null || value < 0 ? 0 : Convert.ToInt32 (value);
        }
    }
}