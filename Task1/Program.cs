Console.Clear();
Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] CreateArrayDouble(int size)
{
            string[] strs = new string[n]; 
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine(); 
            }
    return strs;
}

void PrintMatrix(string[] strs)
{
    Console.Write("[");
            for (int i = 0; i < n; i++)
            {
                if (i==n-1)
                Console.Write($"'{strs[i]}'");
                else
                Console.Write($"'{strs[i]}',");
            }
            Console.WriteLine("]");

}
string[] calculations(string[] strs,int size)
   {
    int sum=0;
    for (int i = 0; i < size; i++)
        {
        string characters = strs[i];
        int t=characters.Length;
                if (t<4){
                sum++;
                }
        }      
    string[] strs2 = new string[sum];
    int j=0;
     for (int i = 0; i < size; i++)
        {
           string characters = strs[i];
           int t=characters.Length;
                if (t<4)
                {
                strs2[j] = strs[i];
                j++;
                }
                
            
        } 
    Console.Write("[");
            for (int i = 0; i < sum; i++)
            {
                if (i==sum-1)
                Console.Write($"'{strs2[i]}'");
                else
                Console.Write($"'{strs2[i]}',");
            }
            Console.WriteLine("]");  
   return strs2;
   }
   
String[] array2D=CreateArrayDouble(n);
PrintMatrix(array2D); 
String[] array3D=calculations(array2D,n);

