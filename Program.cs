using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2сем_4лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Створити суперклас Музичний інструмент і класи Ударний, Струнний, Духовий. 
              Створити масив об'єктів Оркестр. 
              Видати склад оркестру. 
              Видати звук кожного інструменту.*/
            List<IMuzInstr> Orchestra = new List<IMuzInstr>();
            Duh Saksofon = new Duh();
            Saksofon.name= "Саксофон";
            Saksofon.kilk=2;
            Orchestra.Add(Saksofon);
            Duh Fleita = new Duh();
            Fleita.name="Флейта";
            Fleita.kilk=5;
            Orchestra.Add(Fleita);
            Duh Garmoshka = new Duh();
            Garmoshka.name="Гармошка";
            Garmoshka.kilk=4;
            Orchestra.Add(Garmoshka);
            Duh Klarnet = new Duh();
            Klarnet.name="Кларнет";
            Klarnet.kilk=7;
            Orchestra.Add(Klarnet);
            Duh Trombon= new Duh();
            Trombon.name="Тромбон";
            Trombon.kilk=4;
            Orchestra.Add(Trombon);
            Duh Truba = new Duh();
            Truba.name="Труба";
            Truba.kilk=3;
            Orchestra.Add(Truba);
            Udarn Baraban = new Udarn();
            Baraban.name="Барабан";
            Baraban.kilk=5;
            Orchestra.Add(Baraban);
            Udarn Perkusia = new Udarn();
            Perkusia.name="Перкуссия";
            Perkusia.kilk=1;
            Orchestra.Add(Perkusia);
            Udarn Tarelka = new Udarn();
            Tarelka.name="Тарелка";
            Tarelka.kilk=6;
            Orchestra.Add(Tarelka);
            Strun Gitara = new Strun();
            Gitara.name="Гитара";
            Gitara.kilk=2;
            Orchestra.Add(Gitara);
            Strun Balalaika = new Strun();
            Balalaika.name="Балалайка";
            Balalaika.kilk=4;
            Orchestra.Add(Balalaika);
            Strun Bandura = new Strun();
            Bandura.name="Бандура";
            Bandura.kilk=5;
            Orchestra.Add(Bandura);
            Strun  Gusli= new Strun();
            Gusli.name="Гусли";
            Gusli.kilk=4;
            Orchestra.Add(Gusli);
            Strun Domra= new Strun();
            Domra.name="Домра";
            Domra.kilk=3;
            Orchestra.Add(Domra);
            Strun Kobza = new Strun();
            Kobza.name="Кобза";
            Kobza.kilk=1;
            Orchestra.Add(Kobza);
            Strun Tsimbala = new Strun();
            Tsimbala.name="Цимбала";
            Tsimbala.kilk=6;
            Orchestra.Add(Tsimbala);
            Strun Bandzho= new Strun();
            Bandzho.name="Банджо";
            Bandzho.kilk=2;
            Orchestra.Add(Bandzho);
            Console.WriteLine("Состав оркестра: \n");
            int kilkosti = 0;
            for (int i = 0;i<Orchestra.Count;i++)
            {
                kilkosti += Orchestra[i].kilk;
                Console.WriteLine(Orchestra[i].name+" "+Orchestra[i].kilk+"шт "+Orchestra[i].zvuk());
            }
            Console.WriteLine($"\nВсего видов инструментов: {Orchestra.Count};\nВсего инструментов: {kilkosti}шт.");
        }
    }
}
