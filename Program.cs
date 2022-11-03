using Lesson9MassCollection;

Collection<int> collection = new Collection<int>();
collection.ListCollection = new List<int>();
int[] nums2 = new int[4] { 1, 2, 3, 5 };
collection.Add(nums2);
var elem2 = nums2[2];
Console.WriteLine(elem2);