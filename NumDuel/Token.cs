using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace NumDuel {
    class Token {
        string s;
        public string now;
        public string tk;

        public Token(string secret) {
            s = secret + " / ";
        }

        public void Generate(long num) {
            now = DateTime.UtcNow.ToString();
            var sha = new SHA256Managed();
            var str = new StringBuilder(s);
            str.Append(num);
            str.Append(now);
            sha.ComputeHash(Encoding.ASCII.GetBytes(str.ToString()));
            tk = Convert.ToBase64String(sha.Hash).Substring(0, 16);
        }

        public bool Check(long num, string time, string tk) {
            var sha = new SHA256Managed();
            var str = new StringBuilder(s);
            str.Append(num);
            str.Append(time);
            sha.ComputeHash(Encoding.ASCII.GetBytes(str.ToString()));
            return tk == Convert.ToBase64String(sha.Hash).Substring(0, 16);
        }
    }
}
