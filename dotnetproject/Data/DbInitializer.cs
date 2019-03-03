using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetproject.Data
{
    public static class DbInitializer
    {

   public static void Initialize(ApplicationDbContext context)
        {
            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist");
            }
            else {
                var slots = new Slot[] {
                    new Slot{SlotID =1,DegreePlanID =7255,Term=1,CreditID=356,Status='B'}
                    new Slot{SlotID =2,DegreePlanID =7255,Term=1,CreditID=542,Status='B'}
                };
                Console.WriteLine($"Inserted{slots.Length} new slots.");
                foreach (Slot s in slots) {
                    context.Slots.Add(s);
                }
                context.SaveChanges();
            }
             if (context.Students.Any())
            {
                Console.WriteLine("Students already exist");
            }
            else {
                var students = new Student[] {
                    new Student{StudentID =1,LastName = Singam,FirstName = Poojitha,919 = 919571721}
                    new Student{StudentID =2,LastName = Konidela,FirstName = RamCharan,919 = 919571722}
                };
                Console.WriteLine($"Inserted{students.Length} new students.");
                foreach (Student s in students) {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }
             if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist");
            }
            else {
                var credits = new Credit[] {
                     new Credit{CreditID =1,CreditAbbrev = NF,CreditName = NetworkFundamentals,IsSummer = 0,ISSpring = 1, IsFall = 1}
                     new Credit{CreditID =2,CreditAbbrev = 542,CreditName = OOPSwithJAVA,IsSummer = 0,ISSpring = 1, IsFall = 1}
                };
                Console.WriteLine($"Inserted{credits.Length} new students.");
                foreach (Credit s in credits) {
                    context.Credits.Add(s);
                }
                context.SaveChanges();
            }
             if (context.Degrees.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else {
                var degrees = new Degree[] {
                     new Degree{DegreeID =1,DegreeAbbrev = ACS+2,DegreeName = MsACS+2,NumberOFTerms = 5},
                     new Degree{DegreeID =2,DegreeAbbrev = ACS+DB,DegreeName = MsACS+DB,NumberOFTerms = 5},
                      new Degree{DegreeID =3,DegreeAbbrev = ACS+NF,DegreeName = MsACS+NF,NumberOFTerms = 5},
                       new Degree{DegreeID =4,DegreeAbbrev = ACS,DegreeName = MsACS,NumberOFTerms = 5}
                };
                Console.WriteLine($"Inserted{degrees.Length} new students.");
                foreach (Degree s in degrees) {
                    context.Degrees.Add(s);
                }
                context.SaveChanges();
            }
        }

    }
}
