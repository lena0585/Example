int[] array = {1, 65, 67, 3, 25, 94, 47, 21 };

int n = array.Length;
int find = 94;

int index = 0;

while (index < n)
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}