using System.IO;
using System.Text;

var memory = new MemoryStream(Encoding.UTF8.GetBytes("Hello,world"));
var twoMemory = new MemoryStream();
memory.Seek(2, SeekOrigin.Begin);
memory.CopyTo(twoMemory);

Console.WriteLine("{0}=={1}",
    Encoding.UTF8.GetString(twoMemory.ToArray()),
    Encoding.UTF8.GetString(memory.ToArray()));
bool check = 
    Encoding.UTF8.GetString(twoMemory.ToArray()) ==
    Encoding.UTF8.GetString(memory.ToArray());

//if (!check)
//    throw new Exception("is not equals");
Console.ReadKey();