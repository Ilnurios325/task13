Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int size = 0;
int numUsed = num;
while(numUsed != 0){
    numUsed = numUsed/10;
    size++;
}
if (size > 2){
    int div = 10;
    for (int i = 0; i < size - 4; i++){
        div = div*10;
    }
    Console.WriteLine($"third digit: {num/(div)%10}");
}
else
   Console.WriteLine($"its non 3-digit number");
           

