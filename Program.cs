string[] array = ["Hello", "2", "world", ":-)"];
string[] array_2 = [];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    {

Array.Resize(ref array_2, array_2.Length+1);
array_2[array_2.Length-1] = array[i];
    }
}
foreach ( string j in array_2)
{
    Console.Write($"{j} ");
}
