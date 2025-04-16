using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace ToDoList

{

    public class collectionToDo

    {

        List<String> toDoLists = new List<string>();

        string listElement = "";

        int ind;

        string indx = "";

        bool isInt = false;

        char todo;

        bool shallExit = false;



        public void options()

        {

            do

            {

                Console.WriteLine("\nHello, What you want to do?");

                Console.WriteLine("[S]ee all TODOs");

                Console.WriteLine("[A]dd a TODOs");

                Console.WriteLine("[R]emove a TODOs");

                Console.WriteLine("[E]xit");

                todo = Console.ReadKey().KeyChar;

                todo = char.ToUpper(todo);

                //bool check = true;



                if (todo == 'E')

                {

                    Console.WriteLine("\nThanks for working with us have  wonderful day!!!!");

                    shallExit = true;

                }

                else

                 if (todo != 'S' && todo != 'A' && todo != 'R' && todo != 'E')

                {

                    Console.WriteLine($"\nInvalid Chiioce. {todo}");

                }

                else

                if (todo == 'A')

                {

                    add();

                }

                else

                if (todo == 'R')

                {

                    remove();

                }

                else

                if (todo == 'S')

                {

                    printList(todo);

                }

            }

            while (shallExit == false);

            //while (todo != 'S' && todo != 'A' && todo != 'R' && todo!='E');

        }



        public void add()

        {



            do

            {

                Console.WriteLine($"\nPlease enter the TODO description");

                listElement = Console.ReadLine();



                if (!string.IsNullOrEmpty(listElement) && listElement != " ")

                {

                    if (toDoLists.Contains(listElement))

                    {

                        Console.WriteLine($"This description already exists in the list: {listElement}");

                        Console.WriteLine("Please add new description to the list");

                    }

                    else

                    {

                        toDoLists.Add(listElement);

                        Console.WriteLine($"Description successfully added into TODO List");

                        return;

                        //options();

                    }



                }

                else

                {

                    Console.WriteLine("Please enter valid description");

                }



            }

            while (!string.IsNullOrEmpty(listElement) && listElement != " ");



        }



        public void remove()

        {



            do

            {

                printList('R');

                Console.WriteLine("Select the index of todo to be removed from list");

                indx = Console.ReadLine();



                if (indx == " " || string.IsNullOrEmpty(indx))

                {

                    Console.WriteLine("Selected Index can not be empty");

                }

                else

                {

                    isInt = int.TryParse(indx, out ind);

                    if (!isInt)

                    {

                        Console.WriteLine("Please enter valid Index value");

                    }

                    else

                    {

                        if (toDoLists.Count() < ind - 1 || ind == 0)

                        {

                            Console.WriteLine("The given index is out of index range of list listed above");

                            Console.WriteLine("Please enter valid index");

                        }

                        else

                        {

                            Console.WriteLine($"{ind}. {toDoLists[ind - 1]}");  // thre is bug at this state need to figure out and fix what if user input 0

                            toDoLists.RemoveAt(ind - 1);

                            Console.WriteLine("Item successfully removed from list");

                            //options();

                            return;

                        }

                    }

                }



            }

            while (indx != " " && !string.IsNullOrEmpty(indx));



        }

        public void printList(char ops)

        {

            foreach (String element in toDoLists)

            {

                Console.WriteLine($"\n{toDoLists.IndexOf(element) + 1}. {element}");



            }

            if (ops != 'R')

            {

                //options();

                return;

            }



        }

    }

}