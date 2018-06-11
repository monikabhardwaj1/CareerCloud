﻿using CareerCloud.DataAccessLayer;
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
    public class CompanyJobEducationRepository : BaseADO, IDataRepository<CompanyJobEducationPoco>
    {
        SqlConnection _connection;
        public void Add(params CompanyJobEducationPoco[] items)
        {
            _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                int rowsEffected = 0;

                foreach (CompanyJobEducationPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Job_Educations]
           ([Id] ,[Job] ,[Major],[Importance])
     VALUES
            (@Id ,@Job ,@Major,@Importance)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Major", poco.Major);
                    cmd.Parameters.AddWithValue("@Importance", poco.Importance);

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

        public IList<CompanyJobEducationPoco> GetAll(params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            _connection = new SqlConnection(_connString);
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[2000];
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "select * from Company_Job_Educations";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int iPosition = 0;

                while (reader.Read())
                {
                    CompanyJobEducationPoco poco = new CompanyJobEducationPoco();

                    poco.Id = reader.GetGuid(0);

                    poco.Job = reader.GetGuid(1);
                    poco.Major = reader.GetString(2);
                    poco.Importance = reader.GetInt16(3);

                    poco.TimeStamp = (byte[])reader[4];

                    pocos[iPosition] = poco;
                    iPosition++;

                }//end whilec
                _connection.Close();
            }
            return pocos.Where(p => p != null).ToList();
        }

        public IList<CompanyJobEducationPoco> GetList(Expression<Func<CompanyJobEducationPoco, bool>> where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).ToList();
        }

        public CompanyJobEducationPoco GetSingle(Expression<Func<CompanyJobEducationPoco, bool>> where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobEducationPoco[] items)
        {
            _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobEducationPoco poco in items)
                {
                    cmd.CommandText = @"Delete from  [Company_Job_Educations]                   
                    WHERE id=@Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();

                }//end foreach
            }//end using
        }

        public void Update(params CompanyJobEducationPoco[] items)
        {
            _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                foreach (CompanyJobEducationPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Job_Educations]
                   SET 
                      [Job] = @Job
                      ,[Major] = @Major
                      ,[Importance] = @Importance
                               WHERE Id=@Id";

                    
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Major", poco.Major);
                    cmd.Parameters.AddWithValue("@Importance", poco.Importance);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();

                }//end foreach
            }//end using
        }
    }
}
