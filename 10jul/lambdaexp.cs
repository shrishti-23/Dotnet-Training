Func<int,int> square = x => x*x;
Console.WriteLine(square(6));

Func<int,int,int> sub = (a,b) => a-b;
Console.WriteLine(sub(10,50));


Func<int,int,int> mul = (w,v) => w*v;
Console.WriteLine(mul(50,10));

//without lambda
/*void sub(int a , int b){
       int res= a-b;
       Console.WriteLine(res); //same as the second lambda expression
}
sub(10,50);
*/
