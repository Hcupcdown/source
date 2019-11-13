using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hospital.Hospital.entity
{
    class CheckInfo
    {
        public CheckInfo()
        {
        }
        public string checkT(string str)
        {
            //利用正则表达式检查特殊字符
            return Regex.Replace(str.Trim(),"[^%&',.!#()~`:<>/|*;=?$\x22]+","");
        }
        public string checkNull(string str)
        {

            if (str.Trim().Equals(""))
            {
                return "1";
            }
            
            else
            {
                return "";
            }
                
        }
        public string checkLength(string str)
        {
            if (str.Trim().Length > 10)
            {
                return "1";
            }
            else
            {
                return "";
            }
        }

    }
}
