using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_giera1
{

    public struct Terr_difficulties
    {

        public int Hight { get; }
        public bool Foressted { get; }
        public bool Uncertain_ground { get; }
        public bool Demage_indicating { get; }
        public int Demage { get; }

        public Terr_difficulties(int h, bool f, bool ug, bool dmg, int dmg_lvl)
        {
            Hight = h;
            Foressted = f;
            Uncertain_ground = ug;
            Demage_indicating = dmg;
            Demage = dmg_lvl;

        }


        

    }
    public abstract class Terrain
    {
        public abstract string getName();
        public abstract int get_id_();
        public abstract int Hight();
        public abstract bool Foressted();
        public abstract bool Uncertain_ground();
        public abstract bool Demage_indicating();
        public abstract int Demage();

        public class Meadows : Terrain
        {
            public override string getName() { return "Meadows"; }
            public override int get_id_() { return 0; }
            public override int Hight() { return 1; }
            public override int Demage() { return 0; }
            public override bool Foressted() { return false; }
            public override bool Uncertain_ground() { return false; }
            public override bool Demage_indicating() { return false; }

        }

        public class Forest : Terrain
        {
            public override string getName() { return "Forest"; }
            public override int get_id_() { return 1; }
            public override int Hight() { return 1; }
            public override int Demage() { return 0; }
            public override bool Foressted() { return true; }
            public override bool Uncertain_ground() { return false; }
            public override bool Demage_indicating() { return false; }

        }

        



    }

    
    //public enum Terrain_id
    //    {
    //        Meadows ,
    //        Forest,
    //        Taiga,
    //        Tundra,
    //        Highlands,
    //        Forested_Highlands,
    //        Swamp,
    //        Erg,
    //        Serir,
    //        Hamada_hills,
    //        Deathlands,
    //        Volcano,
    //        Ruins,
    //        Mountains,
    //        Dangeon,
    //        Caves,
    //        Tranches

    //    }
    
    

}
