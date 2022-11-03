using Lesson9MassCollection;

var collection = new Collection<int>();
int[] nums2 = new int[4] { 1, 2, 3, 5 };
collection.Add(nums2); 

collection[2] = 34;
collection.Remove(collection[3]);
collection[3] = 35;
Console.WriteLine(collection[2]);
Console.WriteLine(collection[3]);