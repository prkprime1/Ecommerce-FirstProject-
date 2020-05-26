using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaPasalWeb.Models.VirwModels
{
    public class BselistingViewModel
    {


    }


    public class pager
    {
        public pager(int TotalItem, int? page, int pagesize = 10)
        {
            if (pagesize == 0) pagesize = 10;
            {
                var totalpage = (int)Math.Ceiling((decimal)TotalItem / (decimal)pagesize);
                var currentpage = page != null ? (int)page : 1;
                var startpage = currentpage - 5;
                var endpage = currentpage + 4;
                if (startpage <= 0)
                {
                    endpage -= (startpage - 1);
                    startpage = 1;


                }
                if (endpage > totalpage)
                {
                    endpage = totalpage;
                    if (endpage > 10)
                    {
                        startpage = endpage - 9;
                    }

                }

                TotalItems = TotalItem;
                CurrentPage = currentpage;
                PageSize = pagesize;
                TotalPages = totalpage;
                StartPage = startpage;
                EndPage = endpage;




            }
        }



        public int TotalItems { get; private     set; }
        public int CurrentPage { get;    private     set; }
        public int PageSize { get;       private     set; }
        public int TotalPages { get; private set; }

        public int StartPage { get;  private set; }

        public int EndPage { get;  private set; }


        

    }

    
}