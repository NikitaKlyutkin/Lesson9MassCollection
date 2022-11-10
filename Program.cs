using Lesson9MassCollection;

var collection1 = new Collection<int>();
var collection2 = new Collection<int>();
int[] nums1 = new int[4] { 1, 2, 3, 5 };
collection1.Add(nums1);

int[] nums2 = new int[4] { 1, 2, 3, 5 };
collection2.Add(nums2);

CollectionInt conteiner1 = new CollectionInt { };
var listOfCol1 = collection1.AsList();
conteiner1.Add(listOfCol1.ToArray());

CollectionInt conteiner2 = new CollectionInt { };
var listOfCol2 = collection2.AsList();
conteiner2.Add(listOfCol2.ToArray());

Console.WriteLine("Sum:");
var result = conteiner1 + conteiner2;

for(int i = 0; i < result.Count(); i++)
{
    Console.WriteLine(result[i]);
}

Console.WriteLine("==");
var result2 = conteiner1 == conteiner2;
Console.WriteLine(result2);

Console.WriteLine("!=");
var result3 = conteiner1 != conteiner2;
Console.WriteLine(result3);
