using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    Pupil[] arrPupil;

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
        arrPupil = new Pupil[] { p1, p2, p3, p4 };
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        arrPupil = new Pupil[] { p1, p2, p3 };
    }
    public ClassRoom(Pupil p1, Pupil p2)
    {
        arrPupil = new Pupil[] { p1, p2 };
    }

    public void PrintInfoStudy()
    {
        Console.WriteLine("Study: ");
        foreach (Pupil item in arrPupil)
            item.Study();
    }
    public void PrintInfoRead()
    {
        Console.WriteLine("Read: ");
        foreach (Pupil item in arrPupil)
            item.Read();
    }
    public void PrintInfoWrite()
    {
        Console.WriteLine("Write: ");
        foreach (Pupil item in arrPupil)
            item.Write();
    }
    public void PrintInfoRelax()
    {
        Console.WriteLine("Relax: ");
        foreach (Pupil item in arrPupil)
            item.Relax();
    }
}

class Program
{
    static void Main()
    {
        ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

        cRoom.PrintInfoRead();
        cRoom.PrintInfoRelax();
        cRoom.PrintInfoStudy();
        cRoom.PrintInfoWrite();

        Console.ReadKey();
    }
}