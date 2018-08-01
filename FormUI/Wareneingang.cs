using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Wareneingang
    {
        public string Wareneingang_UID { get; set; }
        public int Wareneingang_SID { get; set; }
        public string Lieferschein_Nr { get; set; }
        public string LieferDatum { get; set; }
        public string Modified_von { get; set; }
        public bool IstGebucht { get; set; }
        
        public string FullInfo
        {
            get
            {
                return $"Wareneingang_UID: { Wareneingang_UID } \n " +
                    $"Lieferschein: { Lieferschein_Nr } \n " +
                    $"Modified_von: {Modified_von} \n " +
                    $"{LieferDatum} ({ IstGebucht })";
            }
        }
    }

    public class WareneingangPosZusammenfassung
    {
        public string name { get; set; }

        public string FullInfo
        {
            get
            {
                return $"PositionName: { name} ";
            }
        }
    }

    public class WareneingangPosition
    {
        public int Wareneingang_SID { get; set; }
        public int WareneingangPos_SID { get; set; }
    }

    public class BEPosWEPosERPos
    {
        public int WareneingangPos_SID { get; set; }
        public int BEPosWEPosERPos_SID { get; set; }
    }

    public class BestellPosition
    {
        public int BestellPo_SID { get; set; }
        public string Bezeichnung { get; set; }


    }

}
