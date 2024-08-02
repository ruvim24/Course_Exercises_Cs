using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics
{
    public class DataBase<T> where T : class 
    {
        T[] dataBase;
        int index;
        public DataBase(int nrElements)
        {
            dataBase = new T[nrElements];
            index = 0;
        }

        public void Add(T entity)
        {
            dataBase[index] = entity;
            index++;
        }
        public T Get(int index)
        {
            return dataBase[index];
        }

        public T Delete(int index)
        {
            return dataBase[index];
            dataBase[index] = default;
        }
        public void DisplayAll()
        {
            foreach (T entity in dataBase)
            {
                Console.WriteLine(entity.GetType().Name);
            }
        }



    }
}
