using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        Node first;
        Node last;
        int size;

        public void AddFirst(int val)//добавление в начало списка
        {
            Node currentNode = new Node(val);
            if (first == null)
            {
                first = currentNode;
                last = currentNode;
            }
            else
            {
                currentNode.Next = first;
                first = currentNode;
            }
            size++;

        }
        public void AddFirst(int[] vals)//то же самое, но с массивом
        {
            for(int i = 0; i < vals.Length; i++)
            {
                Node currentNode = new Node(vals[i]);
                if (first == null)
                {
                    first = currentNode;
                    last = currentNode;
                }
                else
                {
                    currentNode.Next = first;
                    first = currentNode;
                }
            }
                size+=vals.Length;
        }
        public void AddLast(int val)//добавление в конец списка
        {
            Node currentNode = new Node(val);
            if(first == null)
            {
                first = currentNode;
            }
            else
            {
                last.Next = currentNode;
            }
                
            last = currentNode;
            size++;
        }
        public void AddLast(int[] vals)//то же самое, но с массивом
        {
            for (int i = 0; i < vals.Length; i++)
            {
                Node currentNode = new Node(vals[i]);
                if (first == null)
                {
                    first = currentNode;
                }
                else
                {
                    last.Next = currentNode;
                }
                    
                last = currentNode;
                size += vals.Length;
            }

        }

        public void AddAt(int idx, int val)//вставка по указанному индексу
        {
            if (idx < 0 || idx > size)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Numerator();

                Node currentNode = first;
                int counter = 0;

                for (int index = 0; currentNode.Index != idx; index++)
                {
                    counter++;

                    currentNode = currentNode.Next;
                }

                currentNode.Value = val;
                counter++;

                currentNode = currentNode.Next;

                for (int index = counter; currentNode != null; index++)
                {
                    counter++;

                    currentNode = currentNode.Next;
                }
            }
        }

        public void AddAt(int idx, int[] vals)//то же самое, но с массивом
        {
            Numerator();

        }

        public int GetSize()//узнать кол-во элементов в списке
        {
            return size;
        }

        public void Set(int idx, int val)//поменять значение элемента с указанным индексом
        {
            Numerator();

            Node currentNode = first;

            for (int index = 0; currentNode != null; index++)
            {
                if (currentNode.Index == idx)
                    currentNode.Value = val;

                currentNode = currentNode.Next;
            }
        }

        public void RemoveFirst()//удаление первого элемента
        {
            if (first != null)
            {
                first = first.Next;
            }
            else
            {
                
            }
            size--;
        }

        public void RemoveLast()//удаление последнего элемента
        {

        }

        public void RemoveAt(int idx)//удаление по индексу
        {

        }

        public void RemoveAll(int val)//удалить все элементы, равные val
        {

        }

        public bool Contains(int val)//проверка, есть ли элемент в списке
        {
            int[] arr = ToArray();
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == val) return true;
            }
            return false;
        }

        public int IndexOf(int val)//вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет)
        {
            Numerator();

            Node currentNode = first;
            
            for (int index = 0; currentNode != null; index++)
            {
                if(currentNode.Value == val)
                    return currentNode.Index;

                currentNode = currentNode.Next;
            }
            return -1;
        }

        public int[] ToArray()//преобразовать список в массив
        {
            int[] arr = new int[size];
            Node currentNode = first;
            
            for(int index = 0; currentNode != null; index++)
            {
                arr[index] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return arr;
        }
        private void Numerator()//нумеровать список
        {
            Node currentNode = first;
            
            for (int index = 0; currentNode != null; index++)
            {
                currentNode.Index = index;
                
                currentNode = currentNode.Next;
            }
        }
        public int GetFirst()//вернёт значение первого элемента списка
        {
            return first.Value;
        }

        public int GetLast()//вернёт значение последнего элемента списка
        {
            
            return last.Value;
        }

        public int Get(int idx)//вернёт значение элемента списка c указанным индексом
        {
            if (idx < 0 || idx > size)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                int val=0; 
                Numerator();

                Node currentNode = first;

                for (int index = 0; currentNode != null; index++)
                {
                    if (currentNode.Index == idx)
                      val = currentNode.Value;

                    currentNode = currentNode.Next;
                }
                return val;
            }
        }

        public void Reverse()//изменение порядка элементов списка на обратный
        {
            Node currentNode = first;
            last = first;
            
            while (currentNode.Next != null)
            {
                Node nextNode = currentNode.Next;
                currentNode.Next = nextNode.Next;
                nextNode.Next = first;
                first = nextNode;
            }
        }
    }
}
