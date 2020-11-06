using System;
using System.Collections.Generic;
using System.Text;

namespace NumDuel {
    class Input {
         long Format(string str) {
            if (str == "+n") {
                return long.MaxValue;
            } else if (str == "-n") {
                return long.MinValue;
            }
            return Convert.ToInt64(str);
        }

        public long GetSelect() {
            var select = Console.ReadLine();
            return Format(select);
        }
    }
}
