using BethanyPieShop.Data;
using BethanyPieShop.Interface;
using BethanyPieShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Repository
{
    public class PieRepository: IPieRepository
    {
        private readonly AppDbContext _dbContext;
        public PieRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pie> AllPies
        { 
            get
            {
                return _dbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _dbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int PieId)
        {

            return _dbContext.Pies.FirstOrDefault(p => p.PieId == PieId);
         
        }
    }
}
