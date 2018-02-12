using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Uygulama
{
    class Car : IMachine
    {

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }


        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }



        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Horn()
        {
            throw new NotImplementedException();
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
    }
}
