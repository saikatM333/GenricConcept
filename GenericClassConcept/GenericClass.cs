using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassConcept
{
    public  class GenericClass<T> where T : IComparable<T>
    {
        public T? MaximumFinder<T>(params T[] inputs)
        {


            ArrayList values = new ArrayList();

            foreach (T input in inputs)
            {

                values.Add(input);

            }

            values.Sort();
            return (T?)values[values.Count - 1];



        }
    }
}
