using ConsoleApp2.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.frameworks
{
    public class DataFrameworkFactory : AbstractFactory
    {
        public override Component Create(int choise)
        {
            switch (choise)
            {
                case 1: return new MySqlFramework();
                case 2: return new EntityFramework();


                default:
                    break;
            }

            return null;
        }


    }
}
