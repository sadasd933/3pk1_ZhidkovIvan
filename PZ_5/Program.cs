using System;

namespace PZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoreDetails track1 = new MoreDetails("fng", "1");
            trackmuzikant muzikant = new trackmuzikant("fem", 7777777, "fng", 1, track1);
            Console.WriteLine(muzikant.ToString());

            Console.WriteLine();

            MoreDetails track2 = new MoreDetails("formula 1", "3");
            trackmuzikant muzikant2 = new trackmuzikant("Obladaet", 666666, "formula 1", 3, track2);
            Console.WriteLine(muzikant2.ToString());
            
            Console.WriteLine();

            trackmuzikant muzikant3 = (trackmuzikant)muzikant2.Clone();
            Console.WriteLine(muzikant3.ToString());
        }
    }
    internal class MoreDetails
    {
        public string Name { get; set; }
        public string PlaceInPlaylist { get; set; }
        public MoreDetails(string name, string place)
        {
            Name = name;
            PlaceInPlaylist = place;
        }
    }

    internal class trackmuzikant : ICloneable 
    {
        private MoreDetails _dtM;
        public string Name { get; set; }
        public int NumberListeners { get; set; }
        public trackmuzikant (string name, int listen, string songn, int place, MoreDetails md)
        {
            Name = name;
            NumberListeners = listen;
            NameSong = songn;
            PlacePlaylist = place;
            _dtM = md;
        }

        
        public override string ToString()
        {
            return $"Музыкальный исполнитель {Name} имеет в месяц " +
                $"{NumberListeners} слушателей, " +
                $"самая популярная песня {MoreDetails}";
        }

        private string nameS;
        private int placeS;
        public string NameSong { get { return nameS; } set { nameS = value; } }
        public int PlacePlaylist { get { return placeS; } set { placeS = value; } }
        public string MoreDetails { get { return _dtM.Name; } set { _dtM.Name = value; } }
        public object Clone() => new trackmuzikant(Name, NumberListeners, NameSong, PlacePlaylist, 
            new MoreDetails(_dtM.Name, _dtM.PlaceInPlaylist));
    }
}