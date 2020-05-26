using lugapasal.database;
using lugapasal.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lugapasal.services
{
    public class categoryservice
    {

        public List<Category> GetCategories()
        {
            using (var contest = new lugapasalcontext())
            {
                return contest.categories.ToList();
            }

        }
        public Category GetCategories(int id)
        {
            using (var contest = new lugapasalcontext())
            {
                return contest.categories.Find(id);
            }

        }

        public void SaveCategory(Category category )
        {
            using (var contest = new lugapasalcontext())
            {
                contest.categories.Add(category);
                contest.SaveChanges();
            }

        }
        public void Update(Category category)
        {
            using (var contest = new lugapasalcontext())
            {
                contest.Entry(category).State = System.Data.Entity.EntityState.Modified;
                contest.SaveChanges();
            }

        }
        public void Delete(int id)
        {
            using (var contest = new lugapasalcontext())
            {
                var category = contest.categories.Find(id);
                contest.categories.Remove(category);
                contest.SaveChanges();
            }

        }

    }

}
