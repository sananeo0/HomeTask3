using System.Text;

namespace HomeTask3
{
    interface IPerson
    {
        public void Speak();
    }

    public  class Program
    {
        static void Main(string[] args)
        {
           SpanishPerson person = new SpanishPerson();
            person.Speak();
            FrenchPerson french = new FrenchPerson();
            french.Speak();
            RussianPerson russian = new RussianPerson();
            russian.Speak();
        }
       
    }
}