using System;

namespace logcat_format
{
    class Program
    {
        private const string ErrorPrefix    = "\x1B[31m";
        private const string WarningPrefix  = "\x1B[33m";
        private const string InfoPrefix     = "\x1B[32m";
        private const string DebugPrefix    = "\x1B[34m";
        private const string VerbosePrefix  = "\x1B[0m";
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (line.Length < 1)
                    continue;

                switch (line[0])
                {
                    case 'E':   // Error
                        Console.Write(ErrorPrefix);
                        break;
                    case 'W':   // Warn
                        Console.Write(WarningPrefix);
                        break;
                    case 'I':   // Info
                        Console.Write(InfoPrefix);
                        break;
                    case 'D':
                        Console.Write(DebugPrefix);
                        break;
                    default:   // Includes Verbose
                        Console.Write(VerbosePrefix);
                        break;
                }

                Console.WriteLine(line);
            }
        }
    }
}
