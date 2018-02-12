using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities;

namespace BusinessLayer
{
    public class AppointmentBLL : IBusiness<Appointment, Int32>
    {
        AppointmentDLL _appointment;

        public AppointmentBLL()
        {
            _appointment = new AppointmentDLL();
        }


        public bool Insert(Appointment item)
        {
            //if (string.IsNullOrWhiteSpace(item))
            //{

            //}
            return false;
        }

        public bool Update(Entities.Appointment item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Entities.Appointment item)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entities.Appointment Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
