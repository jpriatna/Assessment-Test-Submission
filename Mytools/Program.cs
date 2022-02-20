using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Text.Json;

namespace Mytools
{
    class Program
    {
        static int Main(string[] args)
        {

            var input = new Argument<string>("input", "Select File in directory");

            var tag = new Option<string>("--tag", "Format File");
            tag.AddAlias("-t");


            var output = new Option<string>("--output", "output file change destination directory and filename");
            output.AddAlias("-o");

            var cmd = new RootCommand();
            cmd.AddArgument(input);
            cmd.AddOption(tag);
            cmd.AddOption(output);

            cmd.Handler = CommandHandler.Create<string, string, string>(ShowOutput);

            return cmd.Invoke(args);
        }

        static void ShowOutput(string input, string tag, string output)
        {
            string message;
            if (output != null && output != "")
            {
                message = SetOutput(input, tag, output);
            }
            if(tag != "" && tag != null)
            {
                message = SetFormatFile(input, tag);
            }
            else
            {
                var path = Path.ChangeExtension(input, ".txt");
                File.Create(path);
                message = "Success";
            }
            Console.WriteLine($"Result : {message}\x00B0");
        }

        static string SetOutput(string input, string tag, string output)
        {
            try
            {
                if (tag != "" || tag != null)
                {
                    var path = Path.ChangeExtension(output, "." + tag);
                    File.Create(path);
                }
                else
                {
                    File.Copy(input, output, true);
                }

                return ("Success");
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        static string SetFormatFile(string input, string tag)
        {
            try
            {
                if (tag != "" || tag != null)
                {
                    var path = Path.ChangeExtension(input, "." + tag);
                    File.Create(path);
                }
                return ("Success");
            }
            catch(Exception e)
            {
                return (e.Message);
            }
        }
    }
}
