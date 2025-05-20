//using CareNet_System.Models; 
//using CareNet_System.ViewModels;
//using Microsoft.EntityFrameworkCore;

//namespace CareNet_System.Repostatory
//{
//    public class BillsRepository : IBillsRepository
//    {
//        private readonly HosPitalContext _context;

//        public BillsRepository(HosPitalContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<Bills> GetAll()
//        {
//            return _context.Bills
//                .Include(b => b.patient)
//                //.Include(b => b.insurance_id)
//                .ToList();
//        }

//        public Bills? GetById(int id)
//        {
//            return _context.Bills
//                .Include(b => b.patient)
//                .Include(b => b.insurance_id)
//                .FirstOrDefault(b => b.Id == id);
//        }

//        public void Add(Bills bill)
//        {
//            _context.Bills.Add(bill);
//        }

//        public void Update(Bills bill)
//        {
//            _context.Bills.Update(bill);
//        }

//        public void Delete(int id)
//        {
//            var bill = _context.Bills.Find(id);
//            if (bill != null)
//            {
//                _context.Bills.Remove(bill);
//            }
//        }

//        public void Save()
//        {
//            _context.SaveChanges();
//        }
//    }



//}

using System.Collections.Generic;
using System.Linq;
using CareNet_System.Models;
using CareNet_System.Repostatory;
using Microsoft.EntityFrameworkCore;

namespace CareNet_System.Repositories
{
    public class BillsRepository : IBillsRepository
    {
        private readonly HosPitalContext _context;

        public BillsRepository(HosPitalContext context)
        {
            _context = context;
        }

        public IEnumerable<Bills> GetAll()
        {
            return _context.Bills
                .Include(b => b.patient)
                
                .ToList();
        }

        public Bills? GetById(int id)
        {
            return _context.Bills
                .Include(b => b.patient)
                
                .FirstOrDefault(b => b.Id == id);
        }

        public void Add(Bills bill)
        {
            _context.Bills.Add(bill);
        }

        public void Update(Bills bill)
        {
            _context.Entry(bill).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var bill = _context.Bills.Find(id);
            if (bill != null)
            {
                _context.Bills.Remove(bill);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Bills> GetBillsByPatientId(int patientId)
        {
            return _context.Bills
                .Include(b => b.patient)
                .Include(b => b.insurance_id)
           
                .ToList();
        }

        public IEnumerable<Bills> GetBillsByInsuranceId(int insuranceId)
        {
            return _context.Bills
                .Include(b => b.patient)
                .Include(b => b.insurance_id)
  
                .ToList();
        }

      
    }
}