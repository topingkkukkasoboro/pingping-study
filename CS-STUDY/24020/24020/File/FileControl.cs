using System;
using System.Collections.Generic;
using System.IO;


namespace _24020.File
{
    public class FileControl
    {
        String filepath = "data.txt";
        public void write(String text, List<String> list)
        {
/*            Console.WriteLine($"write {text}");
            System.IO. File.WriteAllText(filepath, text);*/

            foreach (var item in list)
            { 
                Console.WriteLine(item);
            }
            System.IO.File.WriteAllLines(filepath, list);
        }
        public List<String> read()
        {
/*            Console.WriteLine("read");
            String text = System.IO.File.ReadAllText(filepath);
            Console.WriteLine($"text = {text}");*/

            List<String>list = new List<String>(System.IO.File.ReadAllLines(filepath));
            return list;

        }
    }
}
