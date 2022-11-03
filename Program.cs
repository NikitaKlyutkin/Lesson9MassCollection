using Lesson9MassCollection;

var collection = new Collection<int>();
int[] nums2 = new int[4] { 1, 2, 3, 5 };
collection.Add(nums2); 

collection[2] = 34;

Console.WriteLine(collection[2]);