﻿using doctorWebApp.context;
using doctorWebApp.interfaces;
using doctorWebApp.models;
using Microsoft.EntityFrameworkCore;

namespace doctorWebApp.repositories
{
    public class DoctorRepository : IRepository<int, Doctor>
    {
        readonly doctorAppContext _context;

        public DoctorRepository(doctorAppContext doctors)
        {
            _context = doctors;

        }

        public async Task<Doctor> Add(Doctor item)
        {
            _context.Doctors.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Doctor> Delete(int key)
        {
            var doctor = await Get(key);
            if (doctor != null)
            {
                _context.Remove(doctor);
                _context.SaveChangesAsync(true);
                return doctor;
            }
            throw new Exception();
        }

        public Task<Doctor> Get(int key)
        {
            var doctor = _context.Doctors.FirstOrDefaultAsync(e => e.Id == key);
            return doctor;
        }

        public async Task<IEnumerable<Doctor>> Get()
        {
            var doctors = await _context.Doctors.ToListAsync();
            return doctors;

        }

        public async Task<Doctor> Update(Doctor item)
        {
            var doctor = await Get(item.Id);
            if (doctor != null)
            {
                _context.Update(item);
                _context.SaveChangesAsync(true);
                return doctor;
            }
            throw new Exception();
        }
    }
}
