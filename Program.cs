class Program
{
    private static void Main(string[] args)
    {
        string[] studentList = { "Nam", "Oanh", "Thu", "Son", "Nga", "Thang", "Dat" };
        Console.WriteLine("Nhap ten muon tim");
        string student = Console.ReadLine();
        bool isTrue = false;
        for (int i = 0; i <= studentList.Length-1; i++)
        {
            if (studentList[i].Equals(student))
            {
                Console.WriteLine("Co trong danh sach va so thu tu la " +(i+1));
                isTrue = true;
                break;

            }
        }
        if (!isTrue)
        {
            Console.WriteLine("Khong co trong danh sach");
        }

    }
}