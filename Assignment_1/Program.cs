using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_1
{
   
    class Program
    {
        string[] Alldata = System.IO.File.ReadAllLines(@"D:\Lahulesh_Chourasiya\Before Training\First_Techical_Question(IMPORTANT)\Assignment_1\Assignment_1\data.txt");
        HashSet<string> hobj = new HashSet<string>();
        //First
        void readinput()//for print only
        {
            Console.WriteLine("****************************Data Start Values******************************");
            foreach (var a in Alldata)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("****************************Data End Values******************************");
        }
        //Second
        void reverse()//revrse only
        {
            string[] data1 = Alldata;
            Console.WriteLine("**********************Reverse Value Start*******************************");
            for (int a = Alldata.Length - 1; a > -1; a--)
            {
                Console.WriteLine(Alldata[a]);
            }
            Console.WriteLine("**********************Reverse Value End*******************************");
        }
        //Third
        void last3value()//Last 3 values only
        {
            string[] data = Alldata;
            Console.WriteLine("*****************************Last 3 Values Start******************************");
            for (int i = data.Length-3;i<=data.Length-1;i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("*****************************Last 3 Values End******************************");
        }
        //Fourth
        void only2value()//first 2 value only
        {
            string[] data = Alldata;
            Console.WriteLine("**********************Only Second Records Start*******************************");
            Console.WriteLine(data[1]);
            Console.WriteLine("**********************Only Second Records End*******************************");
        }
        //Fifth
        void selection(string[] data)
        {
            string[] lines = Alldata;
            Console.WriteLine("****************************Starting Values******************************");
            foreach (String str in lines)
                Console.WriteLine(str + ",");//print that lines
            Console.WriteLine();
            
            for (int j = 0; j < lines.Length - 1; j++)
            {
                int min = j;
                for (int k = j + 1; k < lines.Length; k++)
                {
                    if (lines[k].CompareTo(lines[min]) < 0) min = k;
                    String temp = lines[j];
                    lines[j] = lines[min];
                    lines[min] = temp;
                }
            }
            Console.WriteLine("**********************After Ascending order*******************************");
            foreach (String str in lines)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
        //Sixth
        void top2value()//First and second Value only
        {
            string[] data = Alldata;
            Console.WriteLine("********************Print First 2 Values Start*******************************");
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine("********************Print First 2 Values End*******************************");
        }
        //Seventh
        void Isvowel(string[] str)//printing vowels only a,e,i,o,u
        {
            string[] data = Alldata;
            Console.WriteLine("*********************Your vowels Values Start****************************");
            foreach (var v in data)
            {
                char[] letters = v.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u')
                    {
                        Console.WriteLine(v);
                        break;
                    }
                }
            }
            Console.WriteLine("*********************Your vowels Values End****************************");
        }
        //Eight
        void duplicate()//duplicate values only
        {
            string[] data = System.IO.File.ReadAllLines(@"D:\Lahulesh_Chourasiya\Before Training\First_Techical_Question(IMPORTANT)\Assignment_1\Assignment_1\data.txt"); ;
            Console.WriteLine("********************Duplicate Value Start*******************************");
            int count = 1;
            for(int i = 0;i<data.Length;i++)
            {
                if(!hobj.Add(data[i]))
                {
                    if(count == 1 && data[i] != "")
                    {
                        Console.WriteLine(data[i]);
                        count++;
                    }
                }
                count = 1;
            }
/*            foreach(var items in data)
            {
                if(hobj.Add(items))
                {
                    if(count == 1 && items !="")
                    {
                        Console.WriteLine(items);
                        count++;
                    }
                }
               
                count = 1;
                
            }*/

            Console.WriteLine("********************Duplicate Value End*******************************");
        }
        //Ninth
        void exit()
        {
            Environment.Exit(0);
        }
        //Call method
        void copy()
        {
            Program pobj = new Program();
            do
            {
                Console.WriteLine("Press 1 to print all the names");
                Console.WriteLine("Press 2 to print all the names in reverse");
                Console.WriteLine("Press 3 to print last 3  names");
                Console.WriteLine("Press 4 to print 2 record from the list");
                Console.WriteLine("Press 5 to print sort in ascending order");
                Console.WriteLine("Press 6 to print first 2 names");
                Console.WriteLine("Press 7 to print all the names that contains vowels");
                Console.WriteLine("Press 8 to print duplicate values");
                Console.WriteLine("Press 9 to print to exit");
                Console.WriteLine("Please Select the Appropriate Number:");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        pobj.readinput();
                        break;
                    case 2:
                        pobj.reverse();
                        break;
                    case 3:
                        pobj.last3value();
                        break;
                    case 4:
                        pobj.only2value();
                        break;
                    case 5:
                        pobj.selection(pobj.Alldata);
                        break;
                    case 6:
                        pobj.top2value();
                        break;
                    case 7:
                        pobj.Isvowel(pobj.Alldata);
                        break;
                    case 8:
                        pobj.duplicate();
                        break;
                    case 9:
                        pobj.exit();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Number");
                        break;
                }
            } while (true);
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            try
            {
                p.copy();
            }
            catch
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Please enter a interger value");
                Console.WriteLine("*****************************");
                p.copy();
            }
            Console.ReadKey();
        }
        
    }
}
