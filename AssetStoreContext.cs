using AssetMVCCore.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetMVCCore
{
    public class AssetStoreContext
    {
        public string ConnectionString { get; set; }

        public AssetStoreContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public List<AssetViewModel> GetAllAssets()
        {
            List<AssetViewModel> list = new List<AssetViewModel>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from asset", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AssetViewModel()
                        {
                            Asset_Id = Convert.ToInt32(reader["asset_id"]),
                            Description = reader["asset_description"].ToString(),
                            //Finance_Company = reader["finance_company"].ToString(),
                            Make = reader["mfg"].ToString(),
                            Model = reader["model"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
