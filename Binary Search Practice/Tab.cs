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
        int dolzina = 0;

        //add new value to array and increase value 'dolzina'
        void dodaj(int x)
        {
            tabela[dolzina] = x;
            dolzina++;
        }

        //TO DO 
        // VSEBUJE

        //convert whole array to string
        string ToString2()
        {
            string temp = "";

            for(int i=0; i <= dolzina-1; i++)
            {
                temp += tabela[i].ToString() + ",";
            }

            return temp;
        }

        //VSOTA -- returns value of whole 
        int vsota()
        {
            int value = 0;

            for (int i = 0; i <= dolzina - 1; i++)
            {
                value += tabela[i];
            }

            return value;
        }

        //MIN -- returns smallest number from array
        int Min()
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
        int Max()
        {
            //let's say first number is the biggest
            int maxIndex = 0;

            for (int i = 1; i <= dolzina - 1; i++)
            {
                if (tabela[i] > tabela[maxIndex]) maxIndex = i;
            }

            return tabela[maxIndex];
        }


    }
}
