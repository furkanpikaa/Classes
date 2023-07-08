﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacess
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServiceCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");

        }

        public void Update()
        {
            Console.WriteLine("sql updated");

        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");

        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");

        }

        public void Update()
        {
            Console.WriteLine("MySql updated");

        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }

        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }
}
