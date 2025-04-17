using System;
class app3{
    int x = 25, y = 45; // instance
    static int p = 10, q = 20; // static
    const int a1 = 50; // constant
    readonly int b = 30; // readonly
    void add(){ // local variable
        int c = 40;
        Console.WriteLine(c);
    }
    static void Main(string[] args){
        app3 a = new app3();
        Console.WriteLine(a.x+a.y);
        Console.WriteLine(p-q);
    Console.WriteLine(a1);
    Console.WriteLine(a1,b);
    }
}