using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HospitalSystem.Classes
{
    internal class appointments
    {
        public string app_id { set; get; }
        public string staff_id { set; get; }
        public string client_id { set; get; }
        public string date { set; get; }
        public string time { set; get; }
        public string state { set; get; }

        connection con = new connection();
        public static void populatecombo(ComboBox comboBox, string query, string displayMember)
        {

            using (MySqlConnection connect = new MySqlConnection("datasource = 127.0.0.1; port= 3306; username=root; password=; database= hope_medi_clinic"))
            {
                MySqlCommand command1 = new MySqlCommand(query, connect);
                connect.Open();
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader[displayMember].ToString());
                }
                reader.Close();
                connect.Close();
            }
        }

        // for retrieving client id and staff id

        public string getid(string query, string dis)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(query, con.GetSqlConnection);
            string id = "";
            string display = dis;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                id = dt.Rows[0][display].ToString();
            }
            return id;

        }

        //for sending mail
        public bool sendmail(string email, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("clinichope77@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("clinichope77@gmail.com", "cqhbrskufwrfdpow");
            smtp.EnableSsl = true;
            if (email != null)
            {
                smtp.Send(mail);
                return true;
            }
            else
            {
                return false;
            }
        }

        //for sending sms

        public bool sms(string message)
        {
            string tonumber = "+265992247334";
            TwilioClient.Init("AC90823bef65619f7116d00d225a24c0ca", "ab2c4dedb7dda1adacdd25722327f523");

            try
            {
                var sms = MessageResource.Create(body: message, from: new Twilio.Types.PhoneNumber("+17622382749"), to: new Twilio.Types.PhoneNumber(tonumber));
                return true;
            }
            catch { return false; }
        }

        //for adding appointment
        public bool addApp(string app_id, string staff_id, string client_id, DateTime date, TimeSpan time, string state)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `appointments`(`app_id`,`staff_id`,`client_id`,`date`,`time`,`state`) " +
                "VALUES(@aid,@sid,@cid,@dt,@tm,@st)", con.GetSqlConnection);
            command.Parameters.Add("@aid", MySqlDbType.VarChar).Value = app_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = staff_id;
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = client_id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@tm", MySqlDbType.Time).Value = time;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = state;

            con.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closeConnect();
                return true;
            }
            else
            {
                con.closeConnect();
                return false;
            }
        }

        //for updating an appointmnet

        public bool update(string app_id, string staff_id, string client_id, DateTime date, TimeSpan time, string state)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `appointments` SET staff_id = @sid,client_id = @cid, date = @dt,time = @tm,state = @st WHERE app_id = @id", con.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = app_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = staff_id;
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = client_id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@tm", MySqlDbType.Time).Value = time;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = state;

            con.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closeConnect();
                return true;
            }
            else
            {
                con.closeConnect();
                return false;
            }
        }

        public bool res(string app_id, string updt)
        {
            MySqlCommand command = new MySqlCommand("UPDATE appointments SET state = @st WHERE app_id = @id", con.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = app_id;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = updt;

            con.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closeConnect();
                return true;
            }
            else
            {
                con.closeConnect();
                return false;
            }
        }

        public bool Check(DateTime date, string id, TimeSpan time)
        {
            MySqlCommand command = new MySqlCommand("Select * from appointments where staff_id = @id AND date = @dt AND time = @tm", con.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@tm", MySqlDbType.Time).Value = time;

            con.openConnect();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.closeConnect();
                return true;
            }
            else
            {
                con.closeConnect();
                return false;
            }

        }
    }
}
