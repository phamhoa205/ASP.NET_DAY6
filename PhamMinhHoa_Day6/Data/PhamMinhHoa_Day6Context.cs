using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamMinhHoa_Day6.Models;

namespace PhamMinhHoa_Day6.Data
{
    public class PhamMinhHoa_Day6Context : DbContext
    {
        public PhamMinhHoa_Day6Context (DbContextOptions<PhamMinhHoa_Day6Context> options)
            : base(options)
        {
        }

        public DbSet<PhamMinhHoa_Day6.Models.Genre> Genre { get; set; } = default!;
        public DbSet<PhamMinhHoa_Day6.Models.Movie> Movie { get; set; } = default!;
    }
}
