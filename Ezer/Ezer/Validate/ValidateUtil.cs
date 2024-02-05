﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;
using Ezer.Db;
using Ezer.Data;
using Ezer.Models;
using Ezer.Validate;
using Ezer.Gui;


namespace Ezer.Validate
{
   public class ValidateUtil
    {
        public static bool IsEmail(string email)
        {
            string pattern = "([A-Za-z]+)([_.A-Za-z0-9]*)([A-Za-z0-9]+)(@)([A-Za-z]+)([.A-Za-z]+)([A-Za-z]+)";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
                return true;
            return false;
            /* bool ValidateEmail(string email)
             {
                 if (regex_match(email, regex("([a-z]+)([_.a-z0-9]*)([a-z0-9]+)(@)([a-z]+)([.a-z]+)([a-z]+)")))
                     return true;

                 return false;
             }*/
        }
        public static bool IsHebrew(string word)
        {
            string pattern = @"\b[א-ת-\s]+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }
        public static bool IsNum(string st)
        {
            string pattern = @"\b[0-9-\s]+$";
            Regex reg = new Regex(pattern);
            bool a = reg.IsMatch(st);
            return a;
        }
        public static bool IsAlfa(string st)
        {
            string pattern = @"\b[A-Za-z א-ת-\s]+\d+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(st);
        }
        public static bool IsGil(string st, int startGil, int endGil)
        {
            if (st.Length == 0)
                return false;
            if (Convert.ToInt32(st.ToString()) < startGil || Convert.ToInt32(st.ToString()) > endGil)
                return false;
            return true;
        }
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;
            }
            return sum % 10 == 0;
        }
        public static bool IsCellPhone(string pel)
        {
            string pattern = @"\b05[0 2 3 4 5 6 7 8]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(pel);
        }
        public static bool IsTelPhone(string tel)
        {
            string pattern = @"\b0[2 3 4 72 77 8 9]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }
        public static bool IsTokef(string tokef)
        {
            string pattren = @"\b[1-12]/[20-99]\d$";
            Regex reg = new Regex(pattren);
            return reg.IsMatch(tokef);
        }
    }
}