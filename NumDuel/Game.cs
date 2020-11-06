using System;

namespace NumDuel {
    class Game {
        public int win;
        public int lose;
        public int draw;

        public Game() {
            win = 0;
            lose = 0;
            draw = 0;
        }

        public int CheckWin(long a, long b) {
            if (a == b) {
                return 0;
            }
            if (a == long.MaxValue && b == 0) {
                return -1;
            }
            if (b == long.MaxValue && a == 0) {
                return 1;
            }
            if (a != 0 && b != 0 && (a >> 63) == (b >> 63)) {
                return MathF.Abs(a) > MathF.Abs(b) ? 1 : -1;
            } else {
                return MathF.Abs(a) < MathF.Abs(b) ? 1 : -1;
            }
        }
    }
}
