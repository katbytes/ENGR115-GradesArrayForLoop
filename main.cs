//Practice10_5.cs, Page 443
//Exercise 10-5

using System;
class Practice10_5  {
   public static void Main (string[] args) {
     int[,] grades = new int[6,3];
     grades[0,0] = 82;
     grades[0,1] = 91;
     grades[0,2] = 73;

     grades[1,0] = 90;
     grades[1,1] = 65;
     grades[1,2] = 88;

     grades[2,0] = 64;
     grades[2,1] = 56;
     grades[2,2] = 33;

     grades[3,0] = 80;
     grades[3,1] = 85;
     grades[3,2] = 81;

     grades[4,0] = 95;
     grades[4,1] = 98;
     grades[4,2] = 95;

     grades[5,0] = 75;
     grades[5,1] = 61;
     grades[5,2] = 80;

     for (int row = 0; row < grades.GetLength(0); row++) {
        for (int col = 0; col < grades.GetLength(1); col++)
           Console.Write(grades[row,col] + " ");
           Console.WriteLine();
        }
     }
}
