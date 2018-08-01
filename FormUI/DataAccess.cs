using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Wareneingang> GetWareneingang(string wareneingang_UID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Wareneingang>($"select top 10 * from Wareneingang order by Wareneingang_SID desc").ToList();//where Wareneingang_UID = '{ wareneingang_UID }'
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }


        public List<WareneingangPosZusammenfassung> GetPosition(int wareneingang_SID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                
                var output = connection.Query<WareneingangPosition>($"select * from WareneingangPosition where Wareneingang_SID = { wareneingang_SID } order by WareneingangPos_SID desc").ToList();
                List<WareneingangPosZusammenfassung> wareneingangPosZusammenfassungs = new List<WareneingangPosZusammenfassung>();
                
                foreach (var lala in output)
                {
                  var lllll = connection.Query<BEPosWEPosERPos>($"select * from BEPosWEPosERPos_ZuO where WareneingangPos_SID = { lala.WareneingangPos_SID } ").ToList();
                  var wwww = connection.Query<BestellPosition>($"select * from BestellPosition where BestellPos_SID = { lllll[0].BEPosWEPosERPos_SID } ").ToList();
                    wareneingangPosZusammenfassungs.Add(new WareneingangPosZusammenfassung()
                    {
                        name = wwww[0].Bezeichnung
                    });
                }

                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return wareneingangPosZusammenfassungs;
            }
        }
        //public void InsertPerson(string firstName, string lastName, string emailAddress, string bezeichnung)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
        //    {
        //        //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
        //        List<Wareneingang> people = new List<Wareneingang>();

        //        people.Add(new Wareneingang { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, Bezeichnung = bezeichnung });

        //        connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @Bezeichnung", people);

        //    }
        //}
    }
}
