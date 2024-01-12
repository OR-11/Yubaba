using System;

namespace Yubaba
{
    class Program
    {
        static void Main(string[] args)
        {
        Writing:
            Console.Clear();
            Console.WriteLine("契約書だよ。そこに名前を書きな。\n");
            Console.WriteLine("甲　油屋当主 湯婆婆");
            Console.Write("乙　");
            (string Old, char New) name = (Console.ReadLine(), ' ');
            if (name.Old.Length == 0) goto Writing;
            for (int i = 0; i < name.Old.Length; i++)
            {
                if (!(name.Old[i] == ' ' || name.Old[i] == '\t' || name.Old[i] == '\n' || name.Old[i] == '\r')) break;
                if (i == name.Old.Length - 1) goto Writing;
            }
            Console.WriteLine(name.Old);
            name.New = name.Old[new Random().Next(name.Old.Length)];
            Console.Write($"\nフン。{name.Old}というのかい？贅沢な名だねぇ。今からおまえの名前は{name.New}だ。いいかい、{name.New}だよ。分かったら返事をするんだ、{name.New}!!");
        }
    }
}
