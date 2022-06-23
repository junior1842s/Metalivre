using System;

class Example12
{
   public static void Main()
   {
      // Define a set of Decimal values.
      decimal[] values = { 1.45m, 1.55m, 123.456789m, 123.456789m,
                           123.456789m, -123.456m,
                           new Decimal(1230000000, 0, 0, true, 7 ),
                           new Decimal(1230000000, 0, 0, true, 7 ),
                           -9999999999.9999999999m,
                           -9999999999.9999999999m };
      // Define a set of integers to for decimals argument.
      int[] decimals = { 1, 1, 4, 6, 8, 0, 3, 11, 9, 10};

      Console.WriteLine("{0,26}{1,8}{2,26}",
                        "Argument", "Digits", "Result" );
      Console.WriteLine("{0,26}{1,8}{2,26}",
                        "--------", "------", "------" );
      for (int ctr = 0; ctr < values.Length; ctr++)
        Console.WriteLine("{0,26}{1,8}{2,26}",
                          values[ctr], decimals[ctr],
                          Decimal.Round(values[ctr], decimals[ctr]));
    }
}