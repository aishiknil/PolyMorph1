using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Application
{
    public class Program
    {
        class LoadParent
        {
            public void Show()
            {
                System.Console.WriteLine("This is Parent's Show");
            }
            public virtual void Test()
            {
                System.Console.WriteLine("This is Parents's Test");
            }
        }
        class LoadChild : LoadParent
        {
            public void Show(int i)
            {
                System.Console.WriteLine("Child Class Show");
            }
            public override void Test()
            {
                System.Console.WriteLine("CHild's Test Method");
                //base.Test();
            }
            static void Main(string[] args)
            {
                LoadChild c = new LoadChild();
                c.Show();
                c.Test();
                c.Show(1);
            }
        }
    }
}