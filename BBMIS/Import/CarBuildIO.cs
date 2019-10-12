using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using BBMIS.Models;
using CsvHelper;

namespace BBMIS.Import
{
    public  class CarBuildIO
    {
        public void ImportarCarBuild(BBMISContext context) {
            using (var reader = new StreamReader("CarBuildVolumes.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = new List<CarBuildVolumes>();
                csv.Read();
                csv.ReadHeader();


                while (csv.Read())
                {
                    var record = new CarBuildVolumes
                    {
                        CarBuildVolumesID = csv.GetField<string>("CarBuildVolumesID"),
                        CarBuildID = csv.GetField("Mnemonic_Vehicle"),
                        Year = csv.GetField<int>("Year"),
                        Volume = csv.GetField<float>("Volume")

                    };
                    records.Add(record);
                }


                context.Database.ExecuteSqlCommand("DELETE FROM [dbo].[CarBuildVolumes]");

                context.CarBuildVolumes.AddRange(records);
                context.SaveChanges();
            }

        }
    }
}
