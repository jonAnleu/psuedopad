// The Replicator of D'To

int[] array = {5,3,7,4,6};
int[] secondArray = new int[5];

for(int i = 0; i < array.Length; i++)
{
  secondArray[i] = array[i];
  Console.WriteLine(secondArray[i]);
}
