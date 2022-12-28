using System.Security.Cryptography.X509Certificates;
using T2203E_CSharp.Exercise.Phone;
using T2203E_CSharp.Exercise.Tiendien;
using T2203E_CSharp.Session1;
using T2203E_CSharp.Session2;
using T2203E_CSharp.Session3;
using T2203E_CSharp.Session4;

public class Program
{
    static void Main(string[] args)
    {
        KhachHangVN a = new KhachHangVN(1, "Nguyen Van An", "2022-09-22", 219, "Cá nhân");
        KhachHangNN b = new KhachHangNN(2, "Donal Trump", "2022-09-21", 156, "US");
        Console.WriteLine(a.ThanhTien);
        Console.WriteLine(b.ThanhTienNN);
        
    }
    static void Main5(string[] args)
    {
        StringToVoid stv = new StringToVoid(ShowMessage);
        StringToVoid stv2 = new StringToVoid(DemoDelegate.SayHello);
        StringToVoid stv3 = new StringToVoid(new DemoDelegate().ShowInfo);

        stv += DemoDelegate.SayHello;
        stv += new DemoDelegate().ShowInfo;

        stv += stv3;

        stv("Xin chao cac ban");//ShowMessage("Xin chao cac ban");

        DemoEvent de = new DemoEvent();
        de.Invoke();

    }
    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static string GetMessage(string s)
    {
        return "Hello" + s;
    }
    static void Main4(string[] args)
    {
        PhoneBook pb = new PhoneBook();
        pb.InsertPhone("Nam", "0986454545");
        pb.InsertPhone("Minh", "0123456789");
        pb.InsertPhone("Duy", "0888222555");
        pb.InsertPhone("Huynh", "0111222333");
        pb.InsertPhone("Vu", "0986454545");

        foreach(PhoneNumber p in pb.PhoneList)
        {
            p.ToString();
        }
    }
    static void Main3(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception("Y bằng 0 Mất rồi");
            y++;
            float z = x / y;
            Console.WriteLine("z = " + z);
        } catch(Exception e)
        {
            Console.WriteLine(e.Message);
        } finally
        {

        }
    }
    static void Main2(string[] args)
    {
        Human h = new Human();
        h.Run();
        h.Age = 19;
        h.Email = "abc@gmail.com";
        Console.WriteLine(h.Age);

        Student s = new Student();
        // s.telephone[0] = "0123345664";
        s[0] = "02335656563";

        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world");
        ls.Add("morning");

        for(int i = 0; i < ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }

        foreach(string l in ls)
        {
            Console.WriteLine(l);
        }
    }
}