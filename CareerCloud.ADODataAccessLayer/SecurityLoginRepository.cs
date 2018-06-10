using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : BaseADO, IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                int rowsEffected = 0;

                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins]
           ([Id] ,[Login] ,[Password],[Created_Date],[Password_Update_Date]
           ,[Agreement_Accepted_Date],[Is_Locked],[Is_Inactive],[Email_Address]
           ,[Phone_Number],[Full_Name],[Force_Change_Password],[Prefferred_Language])
     VALUES
             (@Id ,@Login ,@Password,@Created_Date,@Password_Update_Date
           ,@Agreement_Accepted_Date,@Is_Locked,@Is_Inactive,@Email_Address
           ,@Phone_Number,@Full_Name,@Force_Change_Password,@Prefferred_Language)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Password", poco.Id);
                    cmd.Parameters.AddWithValue("@Created_Date", poco.Password);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", poco.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", poco.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", poco.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", poco.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", poco.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", poco.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", poco.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", poco.PrefferredLanguage;

                    _connection.Open();
                    rowsEffected += cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            SecurityLoginPoco[] pocos = new SecurityLoginPoco[1000];
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "select * from Security_Logins";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int iPosition = 0;

                while (reader.Read())
                {
                    SecurityLoginPoco poco = new SecurityLoginPoco();

                    poco.Id = reader.GetGuid(0);

                    poco.Login = reader.GetString(1);
                    poco.Password = reader.GetString(2);
                    poco.PasswordUpdate = (DateTime?)reader[3];
                    poco.AgreementAccepted = (DateTime?)reader[4];
                    poco.IsLocked = reader.GetBoolean(5);
                    poco.IsInactive = reader.GetBoolean(6);
                    poco.EmailAddress = reader.GetString(7);
                    poco.PhoneNumber = reader.GetString(8);
                    poco.FullName = reader.GetString(9);
                    poco.ForceChangePassword = reader.GetBoolean(10);
                    poco.PrefferredLanguage = reader.GetString(11);

                    poco.TimeStamp = (byte[])reader[12];

                    pocos[iPosition] = poco;
                    iPosition++;

                }//end whilec
                _connection.Close();
            }
            return pocos;
        }

        public IList<SecurityLoginPoco> GetList(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(p => p != null).ToList();
        }

            public SecurityLoginPoco GetSingle(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
