using System;
using System.IO;
using System.Collections.Generic;

namespace Aula_04
{
    class Program
    {
        static void Main(String[]args){
            Usuario u = new Usuario("jango", "batatinha123");
            Usuario p = new Usuario("ana", "aimeudeus");
            Usuario q = new Usuario("Lewy", "pokemon38");
            userBase myBase = new UserBase("userbase.txt");
            myBase.AddUser(u);
            myBase.AddUser(p);
            myBase.AddUser(q);
            myBase.Save();
            //Console.WriteLine(u.Serialize());
        }
    }
}