using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204053
{
    public class Book: Product_1204053
    {
        protected string pageCount;

        public Book(string type, string title, string pagecount)
            : base(type, title)
        {
            this.MyTitle = title;
            this.pageCount = pagecount;
            this.MyType = "Book";
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}