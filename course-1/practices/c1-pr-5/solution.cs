// FIRST TASK

int[] ar = { 1, 2, 3, 4, 5 };
for (int i = 0; i < ar.Length; i++) {
    Console.WriteLine(ar[i]);
}

// SECOND TASK
int[] arr = {1, 2, 3, 4, 5, 6};
int sum = 0;
for (int i = 0; i < arr.Length; i++) {
    sum += arr[i];
}
Console.WriteLine(sum / arr.Length);

// THRID TASK
int[] arra = { 12, 65, 34, 89, 14, 17, 39, 98 };
int best = 0;
for (int i = 0; i < arra.Length; i++) {
    if (arra[i] > best) {
        best = arra[i];
    }
}
Console.WriteLine(best);

// FOURTH TASK
string[] fruits = { "Apple", "Mango", "Orange", "Watermelon", "Papaia" };
foreach (string fruit in fruits) {
    Console.WriteLine(fruit);
}

// FIFTH TASK
int[,] array = {
	{ 1, 2, 3},
	{ 4, 5, 6},
	{ 7, 8, 9}
};
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

// SIXTH TASK
int pass = 0;
do {
    string inp = Console.ReadLine();
    pass = int.Parse(inp);
} while (pass != 1234);
