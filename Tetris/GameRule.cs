using System;

namespace Tetris
{
    static class GameRule //동강에서는 static 클래스가 아닌 것으로 표현
    {
        internal const int B_WIDTH = 30; //게임 X좌표 1의 Pixel수
        internal const int B_HEIGHT = 30; //게임 Y좌표 1의 Pixel수
        internal const int BX = 12; //게임 보드의 폭(B_WIDTH*BX Pixels)
        internal const int BY = 20; //게임 보드의 높이(B_HEIGHT*BX Pixels)
        internal const int SX = 4; //시작 S 좌표
        internal const int SY = 0; //시작 Y 좌표
    }
}
