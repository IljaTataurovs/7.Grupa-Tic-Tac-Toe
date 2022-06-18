using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class SpelesLogika
    {
        public string CheckAndOrder(string input, string[] board)
        {
            int count1 = 0;
            int count2 = 0;
            string ret = "";
            string sym1 = "";
            string sym2 = "";
/*
            try
            {
                int userNumber = int.Parse(numberText);
                Console.WriteLine($"Tu ievadīji skaitli: {userNumber}");
            }
            catch (FormatException ex)
            {
                string exceptionMessage = ex.Message;

                Console.WriteLine("Tas nebija skaitlis");
                Console.WriteLine($"Apstrādes kļūda: {exceptionMessage}");
            }
*/
            if (input.Length != 2)
            {
                if (input.Length == 1)
                {
                    throw new DimensionException($"Tu ievadīji vienu zīmi! Vajadzīgas 2 zīmes!");
                }
                else
                {
                    throw new DimensionException($"Tu ievadīji {input.Length} zīmes! Vajadzīgas 2 zīmes!");
                }
            }
            
                string sym01 = input.Substring(0, 1);
                string sym02 = input.Substring(1, 1);

                if (sym01 == sym02)
                {
                    throw new DimensionException($"Ievadīta nepieļaujama kombinācija {input}!");
                }

                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == sym01)
                    {
                        if (i >= board.Length / 2)
                        {
                            sym2 = sym01;
                            count2++;
                        }
                        else
                        {
                            sym1 = sym01;
                            count1++;
                        }
                    }
                    if (board[i] == sym02)
                    {
                        if (i >= board.Length / 2)
                        {
                            sym2 = sym02;
                            count2++;
                        }
                        else
                        {
                            sym1 = sym02;
                            count1++;
                        }
                    }
                }
                if (count1 == 1 && count2 == 1)
                {
                    ret = sym1 + sym2;
                }
                else
                {
                    throw new DimensionException($"Ievadīta nepieļaujama kombinācija {input}!");
                }

            return ret;
        }
        public void DisplayBoard(string[] input, string[] log, string[] board)
        {
            string displayInfo = "Jāievada koordinātes, piemēram 1a vai b3... utt, pēc tam Enter. Ievadot X spēle beidzas.";
            int half = board.Length / 2;
            string info = "  | ";
            int count = 0;
            Console.Clear();
            Console.WriteLine("Tic Tac Toe, Version DM :)");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < half; i++)
            {
                info = info + board[i] + " | ";
            }
            Console.WriteLine(info + "          " + log[0]);

            info = "----";
            for (int i = 0; i < half; i++)
            {
                info = info + "----";
            }
            Console.WriteLine(info + "          " + log[1]);

            for (int i = half; i < board.Length; i++)
            {
                info = board[i] + " | ";
                for (int i2 = 0; i2 < half; i2++)
                {
                    info = info + input[count] + " | ";
                    count++;
                }
                Console.WriteLine(info);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(displayInfo);

        }
        public string[] FillDisplayInfo(string[] input, string user, string code, string[] log, string[] board)
        {
            int half = board.Length / 2;
            int counter = 0;
            bool winner = false;

            for (int i = 0; i < half; i++)
            {
                if (code.Substring(0, 1) == board[i])
                {
                    //counter = half * i;
                    for (int i2 = half; i2 < board.Length; i2++)
                    {
                        if (code.Substring(1, 1) == board[i2])
                        {
                            if (input[counter] == " ")
                            {
                                input[counter] = user;
                                DisplayBoard(input, log, board);
                                winner = CheckResult(input, user, board);
                                if (winner)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("====================================");
                                    Console.WriteLine("");
                                    Console.WriteLine("    " + user + " ir uzvarējis!");
                                    Console.WriteLine("");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Lūdzu uzmanīgāk! Lauciņš " + code + " ir jau izmantots!");
                                Console.WriteLine("Tavs gājiens tiek izlaists!");
                                Console.WriteLine("");
                            }
                            break;
                        }
                        counter = counter + half;
                    }
                }
                counter++;
            }
            return input;
        }
        public bool CheckResult (string[] input, string user, string[] board)
        {
            int half = board.Length / 2;
            int counter = 0;
            int desasGarums = 3;

            for (int i = 0; i < half; i++)
            {
                for (int i2 = half; i2 < board.Length; i2++)
                {
                    if (input[counter] == user)
                    {

                        if ((i2 - half + desasGarums > half) || counter + desasGarums > input.Length)
                        {
                            continue;
                        }
                        if (counter / half == (counter + desasGarums - 1) / half)
                        {
                            if (input[counter] == input[counter + 1] && input[counter] == input[counter + 2])
                            {
                                return true;
                            }
                        }
                        if(counter + (2 * half) < input.Length)
                        {
                            if (counter / half == ((counter + half) / half - 1) && counter / half == ((counter + 2 * half) / half - 2))
                            {
                                if (input[counter] == input[counter + half] && input[counter] == input[counter + (2 * half)])
                                {
                                    return true;
                                }
                            }
                        }
                        if (counter + (2 * half) + 2 < input.Length)
                        { 
                            if (input[counter] == input[counter + half + 1] && input[counter] == input[counter + (2 * half) + 2])
                            {
                                return true;
                            }
                        }
                        if (counter + (2 * half) < input.Length)
                        {
                            if (counter / half == ((counter + half - 1) / half - 1) && counter / half == ((counter + 2 * half - 2) / half - 2))
                            {
                                if (input[counter] == input[counter + half - 1] && input[counter] == input[counter + (2 * half) - 2])
                                {
                                    return true;
                                }
                            }
                        }

                    }
                    counter++;
                }
            }
            return false;
        }
    }
}
