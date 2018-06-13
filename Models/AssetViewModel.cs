using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetMVCCore.Models
{
    public class AssetViewModel
    {
        private AssetStoreContext ctx;
      
        public int Asset_Id { get; set; }
        public string Finance_Company { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

    }
}
    