﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassConcept
{
    public  class Maximum
    {
        
        public void IntegerMaximum(int firstNumber , int secoundNumber, int thirdNumber)
        {
            //int index = firstNumber.CompareTo(thirdNumber);
            int maximumInteger = firstNumber;

         
            if (maximumInteger.CompareTo(secoundNumber)>0)
            {
                maximumInteger = secoundNumber;
             }
            if (maximumInteger.CompareTo(thirdNumber) > 0)
            {
                maximumInteger = thirdNumber;
            }

            Console.WriteLine($"the maximum number out of three digit are {maximumInteger}");

            
           
        }

        public void FloatMaximum(float firstNumber, float secoundNumber, float thirdNumber)
        {
            float maximumInteger = firstNumber;


            if (maximumInteger.CompareTo(secoundNumber) > 0)
            {
                maximumInteger = secoundNumber;
            }
            if (maximumInteger.CompareTo(thirdNumber) > 0)
            {
                maximumInteger = thirdNumber;
            }
            Console.WriteLine($"the maximum number out of three digit are {maximumInteger}");

        }

        public void StringMaximum(string firstNumber, string secoundNumber, string thirdNumber)
        {
            string maximumInteger = firstNumber;


            if (maximumInteger.CompareTo(secoundNumber) > 0)
            {
                maximumInteger = secoundNumber;
            }
            if (maximumInteger.CompareTo(thirdNumber) > 0)
            {
                maximumInteger = thirdNumber;
            }
            Console.WriteLine($"the maximum number out of three string are {maximumInteger}");

        }

        public void MaximumFinder<dataType>(params dataType[] inputs ) where dataType : IComparable<dataType>
        {

           
            ArrayList values  = new ArrayList();

            foreach ( dataType  input in inputs ) { 
            
               values.Add( input );
            
            }

            values.Sort();
            Console.WriteLine($"the maximum value of the given inputs {values[values.Count - 1]}");
            


        }



    }
}