using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Notes
{
    class NotesSqlModel : NotesModel
    {
        private MySqlConnection connection;

        string username;

        public NotesSqlModel(string user, string password)
        {
            string server = "192.168.43.10";
            string database = "notes";
            username = user;

            string connectionTemplate = "SERVER={0};DATABASE={1};UID={2};PASSWORD={3};";
            string connectionString = String.Format(connectionTemplate,
                                                    server, database,
                                                    user, password);

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection error " + ex);
            }
        }

        ~NotesSqlModel()
        {
            connection.Close();
        }

        public void loadNotes()
        {
            string query = "select * from `notes`.`" + username + "`;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Note note = new Note();
                note.id = reader["id"].ToString();
                note.text = reader["text"].ToString();
                notes.Add(note);
            }

            reader.Close();
        }

        public override void addNote(string category)
        {
            throw new NotImplementedException();
        }

        override public void addNote(string category, string text)
        {
            string queryTemplate = "insert into `notes`.`{0}` (`text`) values ('{1}');";
            string query = String.Format(queryTemplate, username, text);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public override void addNote(string id, string category, string text)
        {
            throw new NotImplementedException();
        }

        override public void updateNote(string id, string text)
        {
            string queryTemplate = "update `notes`.`{0}` set `text`='{1}' where `id`={2};";
            string query = String.Format(queryTemplate, username, text, id);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        override public void deleteNote(string id)
        {
            string queryTemplate = "delete from `notes`.`{0}` where `id`={1};";
            string query = String.Format(queryTemplate, username, id);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
