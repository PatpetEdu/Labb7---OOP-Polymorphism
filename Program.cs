namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel(2, 4);
            rektangel.Area();
            Fyrkant fyrkant = new Fyrkant(4.5);
            fyrkant.Area();           
            Cirkel cirkel = new Cirkel(5);
            cirkel.Area();
            Parallellogram parallellogram = new Parallellogram(14, 5);
            parallellogram.Area();
            Ellips ellips = new Ellips(5.6, 3.2);
            ellips.Area();
        }
    }
}