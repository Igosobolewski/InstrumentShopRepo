using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context) : base(context) 
        {
        }
    }
}
