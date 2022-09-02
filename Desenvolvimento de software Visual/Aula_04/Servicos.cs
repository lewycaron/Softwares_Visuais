using System;
using System.IO;
using System.Collections.Generic;

namespace Aula_04{

    class Usuario{

        static int UID = 0;
        
        int id;
        string username;
        string hash;

        public Usuario(string u, string p){
            
            id = getUID();
            SetUsername(u);
            ApplyHash(p);

        }

        static int getUID(){
            
            UID++;
            return UID;
        }

        public void ApplyHash(string password){
            //TODO aplicar Hash.
            hash = password;
        }
        
        public void SetUsername(string u){
            username = u;
        }


        public string getHash(){
            return hash;
        }

        public string Serialize(){
            return id + "," + username + ","+ hash;
        }

    }
    class UserBase
    {
        string filename;
        List<Usuario> usuarios;

        public UserBase(string, f){
            filename = f;
            usuarios = new List<Usuario>();
            LoadUser();
        }

        void LoadUser(){
            //TODO carregar usuarios do arquivo
        }

        public void AddUser(Usuario u)
        {
            usuarios.Add(u);
        }

        public void Save(){
            string output = "";

            foreach (Usuario u in usuarios)
            {
                output += u.Serialize() + "\n";
            }

            File.WriteAllText(filename, output);
        }

    }

}
