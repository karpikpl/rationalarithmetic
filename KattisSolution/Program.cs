using System;
using System.IO;
using System.Numerics;
using KattisSolution.IO;

namespace KattisSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());
        }

        public static void Solve(Stream stdin, Stream stdout)
        {
            IScanner scanner = new OptimizedPositiveIntReader(stdin);
            // uncomment when you need more advanced reader
            scanner = new Scanner(stdin);
            // scanner = new LineReader(stdin);
            var writer = new BufferedStdoutWriter(stdout);

            var numberOfTestCases = scanner.NextInt();

            for (var i = 0; i < numberOfTestCases; i++)
            {
                BigInteger x1 = scanner.NextInt();
                BigInteger y1 = scanner.NextInt();
                var operation = scanner.Next();
                BigInteger x2 = scanner.NextInt();
                BigInteger y2 = scanner.NextInt();

                Tuple<BigInteger, BigInteger> result;
                switch (operation)
                {
                    case "+":
                        result = Add(x1, y1, x2, y2);
                        break;
                    case "-":
                        // to substract is like to add but with the oposite sign
                        result = Add(x1, y1, -x2, y2);
                        break;
                    case "*":
                        result = Multiply(x1, y1, x2, y2);
                        break;
                    case "/":
                        // to divide is like to multiple by the oposite
                        result = Multiply(x1, y1, y2, x2);
                        break;
                    default:
                        throw new InvalidOperationException("no operation for:" + operation);
                }
                writer.Write(result.Item1);
                writer.Write(" / ");
                writer.Write(result.Item2);
                writer.Write("\n");
            }

            writer.Flush();
        }

        private static Tuple<BigInteger, BigInteger> Multiply(BigInteger x1, BigInteger y1, BigInteger x2, BigInteger y2)
        {
            var fractionBase = y1 * y2;
            var fractionTop = x1 * x2;

            return Simplify(fractionTop, fractionBase);
        }

        private static Tuple<BigInteger, BigInteger> Add(BigInteger x1, BigInteger y1, BigInteger x2, BigInteger y2)
        {
            BigInteger fractionBase, fractionTop;

            if (y1 == y2)
            {
                fractionTop = x1 + x2;
                fractionBase = y1;
            }
            else
            {
                fractionTop = x1 * y2 + x2 * y1;
                fractionBase = y1 * y2;
            }

            return Simplify(fractionTop, fractionBase);
        }

        private static Tuple<BigInteger, BigInteger> Simplify(BigInteger x, BigInteger y)
        {
            BigInteger i = BigInteger.GreatestCommonDivisor(x, y); ;

            while (i != 1)
            {
                x /= i;
                y /= i;
                i = BigInteger.GreatestCommonDivisor(x, y);
            }

            if (y < 0)
            {
                x *= -1;
                y *= -1;
            }

            return new Tuple<BigInteger, BigInteger>(x, y);
        }
    }
}
