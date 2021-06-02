﻿using System;
using System.IO;

namespace aevz
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "-h":
                    case "--help":
                        Console.Write("Options: \n" +
                            "  -h --help      Shows help options \n" +
                            "  -v --version   Shows version info \n" +
                            "\nUsages:\n" +
                            "  aevz (-h|--help)\n" +
                            "  aevz (-v|--version)\n" +
                            "  aevz <search-for-text> <replace-with-text>\n"
                        );
                        break;
                    case "-v":
                    case "--version":
                        Console.WriteLine("Aevz - Substituter \n"+
                            "Version 1.0.0 \n" +
                            "A tool to search string and replace that with substitute. \n");
                        break;
                    default:
                        if (args.Length == 3)
                        {
                            string searchFor = args[0];
                            string replaceWith = args[1];
                            string inFileAtPath = args[2];
                            Console.WriteLine($"Search for '{searchFor}' & replace with '{replaceWith}' in file '{inFileAtPath}'.");

                            if (File.Exists(inFileAtPath))
                            {
                                string fileContent = File.ReadAllText(inFileAtPath);
                                fileContent = fileContent.Replace(searchFor, replaceWith);
                                File.WriteAllText(inFileAtPath, fileContent);
                            }
                            else
                            {
                                Console.WriteLine("Error: File path doesn't exist");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Arguments are missing");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Arguments are missing");
            }
        }
    }
}
