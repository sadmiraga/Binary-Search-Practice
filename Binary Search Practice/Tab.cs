using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Practice
{
    class Tab
    {
        private int[] tabela = new int[100];
        public int dolzina = 0;

        //add new value to array and increase value 'dolzina'
        public void dodaj(int x)
        {
            tabela[dolzina] = x;
            dolzina++;
        }

        //VSEBUJE -- return true or false depending on that if array has given number
        public bool vsebuje(int x)
        {
            bool contains = false;

            for(int i = 0; i <= dolzina - 1; i++)
            {
                if(tabela[i] == x)
                {
                    contains = true;
                    break;
                }
            }

            return contains;
        }

        // TO STRING 2 -- convert whole array to string
        public string ToString2()
        {
            string temp = "";

            for(int i=0; i <= dolzina-1; i++)
            {
                temp += tabela[i].ToString() + ",";
            }

            return temp;
        }

        //VSOTA -- returns value of whole 
        public int vsota()
        {
            int value = 0;

            for (int i = 0; i <= dolzina - 1; i++)
            {
                value += tabela[i];
            }

            return value;
        }

        //MIN -- returns smallest number from array
        public int Min()
        {
            //lets say first number is the smallest
            int minIndex = 0;

            for(int i =1; i <= dolzina - 1; i++)
            {
                if (tabela[i] < tabela[minIndex]) minIndex = i;
            }

            return tabela[minIndex];
        }

        //MAX -- returns biggest number from array
        public int Max()
        {
            //let's say first number is the biggest
            int maxIndex = 0;

            for (int i = 1; i <= dolzina - 1; i++)
            {
                if (tabela[i] > tabela[maxIndex]) maxIndex = i;
            }

            return tabela[maxIndex];
        }

        //POVPREČJE -- returns avarage value from array 
        public double povprecje()
        {
            int sum = vsota();
            double avarage = sum / dolzina;
            return avarage;
        }

        //VSEBUJE BINARNO -- with binary search returns true or false depending on that if array has given number 
        public bool vsebujeBinarno(int x)
        {
            int low = 0;
            int high = dolzina - 1;

            int mid;

            // do while loop until low value cross high value and vice versa
            while(low <= high)
            {
                //define middle value
                mid = (low + high) / 2;

                if(x == tabela[mid])
                {
                    return true;
                } else if(x > tabela[mid])
                {
                    low = mid + 1;
                } else
                {
                    high = mid - 1;
                }

            }

            return false;

        }


    }
}
