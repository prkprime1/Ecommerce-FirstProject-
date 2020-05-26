using LugaPasalModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LugaPasalDataBase;
using System.Security.Cryptography.X509Certificates;

namespace LugaPasalServices
{
    public class CategoryProcess
    {

        public int Save(CategoryModal modal)
        {
            using (var database = new PrkStoreEntities())
            {
                tblCategory CategoryTB = new tblCategory()
                {

                    Name = modal.Name,
                    Description = modal.Description,
                    ImageUrl =modal.ImageUrl,
                    IsFeatured = modal.IsFeatured


                };

                database.tblCategory.Add(CategoryTB);
                database.SaveChanges();
                return CategoryTB.ID;

            }


        }

        public List<CategoryModal> GetAll()
        {
            using (var database = new PrkStoreEntities())
            {
                var all = database.tblCategory.Select(X => new CategoryModal()
                {
                    ID = X.ID,
                    Name = X.Name,
                    Description = X.Description,
                    ImageUrl = X.ImageUrl,
                    IsFeatured = (bool)X.IsFeatured


                }).ToList();

                return all;

            }
        }

        public List<CategoryModal> GetFeaturedCategories()
        {
            using (var database = new PrkStoreEntities())
            {
                var all = database.tblCategory.Where(x =>x.IsFeatured== true)
                    .Select(X => new CategoryModal()
                {
                    ID = X.ID,
                    Name = X.Name,
                    Description = X.Description,
                    ImageUrl = X.ImageUrl,
                    IsFeatured = (bool)X.IsFeatured





                }).ToList();

                return all;

            }
        }
        public CategoryModal GetOne(int id)
        {
            using (var database = new PrkStoreEntities())
            {
                var all = database.tblCategory.Where(x => x.ID == id).
                    Select(X => new CategoryModal
                    {
                        Name = X.Name,
                        Description = X.Description




                    }).FirstOrDefault();

                return all;

            }
        }
        public bool Edit(int id, CategoryModal models)
        {
            using (var contest = new PrkStoreEntities())
            {
                var employee = contest.tblCategory.FirstOrDefault(x => x.ID == id);// first or default use garda fast hucha where vanda
                if (employee != null)
                {
                    employee.Name = models.Name;
                    employee.Description = models.Description;
                    employee.IsFeatured = models.IsFeatured;

                }
                contest.SaveChanges();
                return true;
            }

        }
        public bool DeleteEmployee(int id)
        {
            using (var contest = new PrkStoreEntities())
            {
                var employee = contest.tblCategory.FirstOrDefault(x => x.ID == id);
                if (employee != null)
                {
                    contest.tblCategory.Remove(employee);
                    contest.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool DeleteEmploye(int id)
        {
            using (var contest = new PrkStoreEntities())
            {
                var employee = contest.tblCategory.FirstOrDefault(x => x.ID == id);
                if (employee != null)
                {
                    contest.tblCategory.Remove(employee);
                    contest.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
