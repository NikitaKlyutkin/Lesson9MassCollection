﻿using Lesson9MassCollection;

var collection = new Collection<int>();
var collection2 = new Collection<int>();
int[] nums2 = new int[4] { 1, 2, 3, 5 };
collection.Add(nums2);

collection[2] = 34;
collection[3] = 35;
Console.WriteLine(collection[2]);
Console.WriteLine(collection[3]);
int[] nums3 = new int[4] { 1, 2, 3, 5 };
collection2.Add(nums3);
CollectionInt conteiner1 = new CollectionInt {Value = };
CollectionInt conteiner2 = new CollectionInt {};
var result = conteiner1 + conteiner2;