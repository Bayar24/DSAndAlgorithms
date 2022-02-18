using System;

namespace HardProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            TrappingWater trappingWater = new TrappingWater();
            trappingWater.TestTrap();

            TextJustification textJustification = new TextJustification();
            textJustification.TestFullJustify();

            WordSearchII wordSearchII = new WordSearchII();
            wordSearchII.TestFindWords();
        }
    }
}
