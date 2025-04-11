using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entidades
{
    public class Obs
    {
        public string obs { get; set; }

        [Required]
        [PrimaryKey, AutoIncrement]
        public Guid id { get; set; }

        public Obs()
        {

        }

        public Obs(string obs)
        {
            id = Guid.NewGuid();
            this.obs = obs;
        }
    }
}
