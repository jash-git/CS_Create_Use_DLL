using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Create_Use_DLL
{
    public class Class1
    {
        //https://dotblogs.com.tw/hung-chin/2011/09/30/38449
        public string StrUpperLower(string word,bool blnUpper=true)//方法名稱
        {
            if(blnUpper)
            {
                return word.ToUpper();
            }
            else
            {
                return word.ToLower();
            }      
        }
    }
}
