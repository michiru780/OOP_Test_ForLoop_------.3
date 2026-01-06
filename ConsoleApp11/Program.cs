using System;
class NumberCalculator
{
    // สร้างเมธอด ShowAndSum รับค่า n
    public void ShowAndSum(int n)
    {
        int sum = 0;
        // ตัวแปรเก็บผลรวมของตัวเลข

        // for-loop ใช้วนแสดงตัวเลขตั้งแต่ 1 ถึง n
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            // แสดงค่าของ i ทีละตัว

            sum += i;
            // นำค่า i มาบวกสะสมใน sum
        }

        // แสดงผลรวมทั้งหมด
        Console.WriteLine("\nผลรวม = " + sum);
    }
}

// คลาสหลักของโปรแกรม
class Program
{
    static void Main()
    {
        // รับค่าตัวเลขจากผู้ใช้
        Console.Write("ป้อนตัวเลข: ");
        int n = int.Parse(Console.ReadLine());

        // สร้างอ็อบเจกต์จากคลาส NumberCalculator
        NumberCalculator nc = new NumberCalculator();

        // เรียกใช้เมธอด ShowAndSum
        nc.ShowAndSum(n);
    }
}
