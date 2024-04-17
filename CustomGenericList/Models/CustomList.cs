using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericList.Models
{
    //List classını Custom yazmaq(Generic olacaq) . List-in Add() Find() FindAll() Remove() RemoveAll() metodları da olacaq.
    internal class CustomList<t>
    {
        static t[] list;
        public CustomList()
        {
            list = Array.Empty<t>();
        }
        public void Add(t item) 
        {
            Array.Resize(ref list, list.Length + 1);
            list[^1] = item;
        }

        public static t[] Find(t[] list, Predicate<t> method)
        {
            
            t[] findlist=new t[0];
            foreach(t t in list)
            {
                if (method(t))
            {
                    Array.Resize<t>(ref findlist, findlist.Length + 1);
                    findlist[^1] = t;
                    Console.WriteLine(t);
                    break;
                }
            }
            return findlist;
 
        }

        public static t[] FindAll(t[] list, Predicate<t> method )
        {
            t[] findlist = new t[0];

            foreach (t item in list)
            {
                if (method(item))
                {
                    Array.Resize<t>(ref findlist, findlist.Length + 1);
                    findlist[^1] = item;
                    Console.WriteLine(item);
                }

            }
            return findlist;

        }

        public static t[] Remove(t item,Predicate<t> method)
        {
            t[] deletedlist=new t[0];
            foreach (t items in list)
            {
                if (!method(items))
                {
                    Array.Resize(ref deletedlist, deletedlist.Length+1);
                    deletedlist[^1]=items;
                }
                else if (method(items))
                {
                    break;
                }

            }
            return deletedlist;
        }

        public static t[] RemoveAll(t index,Predicate<t> method) 
        {
            t[] deletedlist=new t[list.Length];
            return deletedlist;
        }

    }
}
