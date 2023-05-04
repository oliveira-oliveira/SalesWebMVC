using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // verificando se há algum registro no banco de dados
            if (_context.Department.Any() ||
                _context.SalesRecord.Any() ||
                _context.Seller.Any())
            {
                return; // banco de dados populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@mail.com", new DateTime(1991,1,1), 1000, d1);
            Seller s2 = new Seller(2, "Carl Grenn", "carl@mail.com", new DateTime(1992, 2, 2), 1000, d2);
            Seller s3 = new Seller(3, "Dany Red", "dany@mail.com", new DateTime(1993, 3, 3), 1000, d3);
            Seller s4 = new Seller(4, "Emy Gray", "emy@mail.com", new DateTime(1994, 4, 4), 1000, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord sr1 = new SalesRecord { Id = 1, Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord sr2 = new SalesRecord { Id = 2, Date = new DateTime(2018, 09, 4), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord sr3 = new SalesRecord { Id = 3, Date = new DateTime(2018, 09, 13), Amount = 4000.0, Status = SaleStatus.Canceled, Seller = s4 };
            SalesRecord sr4 = new SalesRecord { Id = 4, Date = new DateTime(2018, 09, 1), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord sr5 = new SalesRecord { Id = 5, Date = new DateTime(2018, 09, 21), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord sr6 = new SalesRecord { Id = 6, Date = new DateTime(2018, 09, 15), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord sr7 = new SalesRecord { Id = 7, Date = new DateTime(2018, 09, 28), Amount = 13000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord sr8 = new SalesRecord { Id = 8, Date = new DateTime(2018, 09, 11), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord sr9 = new SalesRecord { Id = 9, Date = new DateTime(2018, 09, 14), Amount = 11000.0, Status = SaleStatus.Pending, Seller = s6 };
            SalesRecord sr10 = new SalesRecord { Id = 10, Date = new DateTime(2018, 09, 7), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord sr11 = new SalesRecord { Id = 11, Date = new DateTime(2018, 09, 13), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord sr12 = new SalesRecord { Id = 12, Date = new DateTime(2018, 09, 25), Amount = 7000.0, Status = SaleStatus.Pending, Seller = s3 };
            SalesRecord sr13 = new SalesRecord { Id = 13, Date = new DateTime(2018, 09, 29), Amount = 10000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord sr14 = new SalesRecord { Id = 14, Date = new DateTime(2018, 09, 4), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord sr15 = new SalesRecord { Id = 15, Date = new DateTime(2018, 09, 12), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord sr16 = new SalesRecord { Id = 16, Date = new DateTime(2018, 10, 5), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord sr17 = new SalesRecord { Id = 17, Date = new DateTime(2018, 10, 1), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord sr18 = new SalesRecord { Id = 18, Date = new DateTime(2018, 10, 24), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord sr19 = new SalesRecord { Id = 19, Date = new DateTime(2018, 10, 22), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord sr20 = new SalesRecord { Id = 20, Date = new DateTime(2018, 10, 15), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord sr21 = new SalesRecord { Id = 21, Date = new DateTime(2018, 10, 17), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord sr22 = new SalesRecord { Id = 22, Date = new DateTime(2018, 10, 24), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord sr23 = new SalesRecord { Id = 23, Date = new DateTime(2018, 10, 19), Amount = 11000.0, Status = SaleStatus.Canceled, Seller = s2 };
            SalesRecord sr24 = new SalesRecord { Id = 24, Date = new DateTime(2018, 10, 12), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord sr25 = new SalesRecord { Id = 25, Date = new DateTime(2018, 10, 31), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord sr26 = new SalesRecord { Id = 26, Date = new DateTime(2018, 10, 6), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord sr27 = new SalesRecord { Id = 27, Date = new DateTime(2018, 10, 13), Amount = 9000.0, Status = SaleStatus.Pending, Seller = s1 };
            SalesRecord sr28 = new SalesRecord { Id = 28, Date = new DateTime(2018, 10, 7), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord sr29 = new SalesRecord { Id = 29, Date = new DateTime(2018, 10, 23), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord sr30 = new SalesRecord { Id = 30, Date = new DateTime(2018, 10, 12), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s2 };

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            _context.SaveChanges();

        }
    }
}
