using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LugaPasalModals;
using LugaPasalDataBase;

namespace LugaPasalServices
{
    public class ProductServices
    {

        public int Save(ProductModals modal)
        {
            using (var database = new PrkStoreEntities())
            {
                tblProduct CategoryTB = new tblProduct()
                {

                    Name = modal.Name,
                    Description = modal.Description,
                    Price = modal.Price

                };
                database.tblProduct.Add(CategoryTB);
                database.SaveChanges();
                return CategoryTB.Id;
            }

        }

        public List<ProductModals> GetAll(int pageno)
        {
            int pageSize = 5;

            using (var database = new PrkStoreEntities())
            {
                var all = database.tblProduct.OrderBy(x => x.Id).Skip((pageno - 1) * pageSize).Take(pageSize)
                    .Select(X => new ProductModals()
                    {
                        Id = X.Id,
                        Name = X.Name,
                        Description = X.Description,
                        Price = (decimal)X.Price,
                        pagenumber = pageno,
                        one = 1,
                       
                        



                    }).ToList();
                

                return all;

            }
        }

        public ProductModals GetOne(int id)
        {
            using (var database = new PrkStoreEntities())
            {
                var all = database.tblProduct.Where(x => x.Id == id).
                    Select(X => new ProductModals
                    {
                        Name = X.Name,
                        Description = X.Description




                    }).FirstOrDefault();

                return all;

            }
        }


        public List<ProductModals> GetOne(List<int> ids)
        {
            using (var database = new PrkStoreEntities())
            {
                var all = database.tblProduct.Where(product => ids.Contains(product.Id)).
                    Select(X => new ProductModals
                    {
                        Name = X.Name,
                        Description = X.Description,
                        Price = (decimal)X.Price




                    }).ToList();

                return all;

            }
        }

        public bool Edit(int id, ProductModals models)
        {
            using (var contest = new PrkStoreEntities())
            {
                var employee = contest.tblProduct.FirstOrDefault(x => x.Id == id);// first or default use garda fast hucha where vanda
                if (employee != null)
                {
                    employee.Name = models.Name;
                    employee.Description = models.Description;
                    employee.Price = models.Price;

                }
                contest.SaveChanges();
                return true;
            }

        }
        public bool DeleteEmployee(int id)
        {
            using (var contest = new PrkStoreEntities())
            {
                var employee = contest.tblProduct.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    contest.tblProduct.Remove(employee);
                    contest.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
