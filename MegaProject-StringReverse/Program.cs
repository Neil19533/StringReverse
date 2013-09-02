using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProject_StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Reverse String mini project--------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Please enter some text to reverse, then press the Enter key: ");
            string Forwardinput = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------Method A------");
            Console.WriteLine("");

            #region MethodA

            //Start timer for methodA:
            DateTime Timer = DateTime.Now;

            //Run the Method many times for comparisons
            for (int i = 0; i < 1000000; i++)
            {
                ReverseStringMethodA(Forwardinput);
            }

            string ReversedA = ReverseStringMethodA(Forwardinput);

            //Stop the Timer
            TimeSpan Span = DateTime.Now.Subtract(Timer);

            //getMessage
            string finishedmessage = StringReversedMessage(Forwardinput, Span, ReversedA);

            Console.WriteLine(finishedmessage);

            #endregion

            Console.WriteLine("");
            Console.WriteLine("------Method B------");
            Console.WriteLine("");

            #region MethodB

            //Start a timer for MethodB:
            DateTime TimerB = DateTime.Now;

            //Run test same amount of times as previouse for comparison
            for (int i = 0; i < 1000000; i++)
            {
                ReverseStringMethodB(Forwardinput);
            }

            string ReversedB = ReverseStringMethodA(Forwardinput);

            //Stop the Timer
            TimeSpan SpanB = DateTime.Now.Subtract(TimerB);

            //getMessage
            string finishedmessageB = StringReversedMessage(Forwardinput, SpanB, ReversedB);

           
            Console.WriteLine(finishedmessageB);

            #endregion

            Console.WriteLine("");
            Console.WriteLine("------Method C------");
            Console.WriteLine("");

            #region MethodC
            //Start timer:
            DateTime TimerC = DateTime.Now;

            for (int i = 0; i < 1000000; i++)
            {
                ReverseStringMethodC(Forwardinput);
            }

            string ReversedC = ReverseStringMethodA(Forwardinput);

            //Stop Timer
            TimeSpan SpanC = DateTime.Now.Subtract(TimerC);


            string finishedmessageC = StringReversedMessage(Forwardinput, SpanC, ReversedC);


            Console.WriteLine(finishedmessageC);

#endregion

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Finished, Press any key to escape");
                            Console.WriteLine("--------------------------------");

            Console.ReadLine();
        }

        private static string StringReversedMessage(string Forwardinput, TimeSpan Span, string Reversed)
        {

            StringBuilder Finished = new StringBuilder();

            Finished.Append("String reversed: ");
            Finished.Append(Forwardinput);
            Finished.Append(" -- ");
            Finished.Append(Reversed);
            Finished.Append(" -- Completed in:");
            Finished.Append(Span.Milliseconds);
            Finished.Append(" milliseconds.");
            return Finished.ToString();
        }

        private static string ReverseStringMethodA(string Forwardinput)
        {
            StringBuilder Methoda = new StringBuilder();
            int inputlen = Forwardinput.Length;

            for (int i = 1; i < inputlen + 1; i++)
            {
                Methoda.Append(Forwardinput[inputlen - i]);
            }


            return Methoda.ToString();
        }

        private static string ReverseStringMethodB(string Forwardinput)
        {
            int inputlen = Forwardinput.Length;

            string outputcode = "";

            for (int i = 1; i < Forwardinput.Length + 1; i++)
            {
                outputcode += Forwardinput[inputlen - i];
            }
            return outputcode;
        }

        private static string ReverseStringMethodC(string Forwardinput)
        {
            Array.Reverse(Forwardinput.ToCharArray());

            return Forwardinput;
        }
    }
}
