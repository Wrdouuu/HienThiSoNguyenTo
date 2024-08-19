using System;

namespace SONGUYENTO
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int countNum=0;
            int quantityNum;
            int i;

            Console.WriteLine("Nhap so luong so nguyen to can in ra: ");
            quantityNum=Int32.Parse(Console.ReadLine());

            for(num=0;;num++)
            {
                int count=0;
                if(countNum<quantityNum)
                {
                    if (num>=2)
                    {
                        for (i=2;i<num;i++)
                        {
                            if(num%i==0)
                            {
                                count++;
                            }

                        }
                         if(count==0)
                         {
                             Console.Write("{0,5}",num);
                             countNum++;
                         }
                    }
                }
                else
                {
                    break;
                }
            }



        }
    }
}
