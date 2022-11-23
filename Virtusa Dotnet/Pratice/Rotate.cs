
using System;
public class Rotate
{
    public static void Main(string[] args)
    {
        int num;
        char ch;
        string w=Console.ReadLine();
        string n=Console.ReadLine();
        num = Convert.ToInt32(n);
        ch = Convert.ToChar(Console.ReadLine());
        char[] arr= w.ToCharArray();
        char[] a=new char[w.Length];
        char[] ans=new char[w.Length];
        if(ch=='L'){
              for(int i=num;i<w.Length;i++){
                  a[i]+=arr[i];
                  Console.Write(a[i]);
                }
                for(int i=0;i<num;i++){
                   ans[i]+=arr[i];
                   Console.Write(ans[i]);
                }
        }
        int s=w.Length-num;
        if(ch=='R'){
            for(int i=s;i<w.Length;i++){
                a[i]+=arr[i];
                Console.Write(a[i]);
            }
            for(int i=0;i<s;i++){
                ans[i]+=arr[i];
                Console.Write(ans[i]);
            }
        }
    }
}