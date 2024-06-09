using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace usrinf 
{
    public class UsersInfo 
    {
        int iteration = 0;
        string fileinrow = "";

       

        public void GetUsersProfiles()
        {
           
            
        }
        public string SendDatatoScreen(string data,int row)
        {
            return row.ToString()+" "+data+"XC";
        }

      
}
