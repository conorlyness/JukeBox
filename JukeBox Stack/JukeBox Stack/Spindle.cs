using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBox_Stack
{
    class Spindle
    {
        private CDNode top;
        private int capacity, size;
        

        public Spindle()
        {
            top = null;
            size = 0;
            capacity = 10;
        }

        private bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//isEmpty

        public Boolean push(CDNode newNode)
        {
           
            if (size >= capacity)
            {
                return false; 
            }
            else
            {
                newNode.Prev = top;
                top = newNode;
                size++;
                return true;
            }

           
        }//push

        public string list()
        {
            
                if (isEmpty())
                {
                    return "Spindle is empty\n";
                }
                string output = "Contents of Stack\nCD's: " + size + "\n";
                CDNode current = top;

                while (current != null)
                {
                    output += current.Name + " By " + current.Artist + "   || No. of tracks: " + current.getTracks() + "   || runtime in mins: " + current.getDuration() + "\n";
                    current = current.Prev;
                }

            

            return output;
        }//list

        public CDNode peek()
        {
            return top;
        }//peek

        public CDNode pop()
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                CDNode removed = top; //creating a reference called removed
                top = removed.Prev; //top should now be removed previous
                size--;
                return removed;
            }//pop
        }

        public bool contains(string find)
        {
            if (isEmpty())
            {
                return false;
            }

            CDNode current = top;

            while (current != null)
            {
                if (find == current.Name)
                {
                    current.getTracks();
                    current.getDuration();
                    return true;
                }
                
                current = current.Prev;
            }
            return false;
        }//contains
    }
}
