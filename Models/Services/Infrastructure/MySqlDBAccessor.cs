using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RCommerce.Models.Services.Infrastructure
{
    public class MySqlDBAccessor : IDatabaseAccessor
    {

        MySqlConnection cn = new MySqlConnection("Data Source=localhost; Database=ghiot; User ID=root; Password=;");
        public async Task<DataSet> QueryAsync(FormattableString Formattablequery)
        {
            
            var arguments = Formattablequery.GetArguments();
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            for(int i = 0; i<arguments.Length; i++){
                MySqlParameter parameter = new MySqlParameter(i.ToString(),arguments[i]);
                parameters.Add(parameter);
                arguments[i] = "@"+i;
            } 
            string query = Formattablequery.ToString();


            //DataSet di ritorno
            DataSet dataset = new DataSet();
            using(var cmd = new MySqlCommand(query,cn)){
                await cn.OpenAsync();
                foreach(MySqlParameter p in parameters){
                    cmd.Parameters.Add(p);
                }
                using(var reader = await cmd.ExecuteReaderAsync()){
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataset.Tables.Add(dt);
                }
                cn.Close();
            }

            return dataset;

        }
    }
}