using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wsc2020Day2Session2ConsoleApp
{
    internal class Program
    {
        static Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        static void Main(string[] args)
        {
            populateCriteria();
            populateCompetitors();
            populateJudges();
            populateCompetition();

        }

        public static void populateCriteria()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var filePath = "C:\\WS C#\\Wsc2020Day2Session2App\\Wsc2020Day2Session2ConsoleApp\\Wsc2020Day2Session2ConsoleApp\\Area-Criteria.csv";

            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields();
                try
                {
                    var i = 1;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        var area = fields[0];
                        var criteria = fields[1];
                        var maxmarks = fields[2];

                        var areaId = context.Areas.Where(a => a.area1 == area).Select(a => a.id).FirstOrDefault();

                      
                        var newcriteria = new AreaCriteria
                        {
                            areaId = areaId,
                            criteria = criteria,
                            maximumMarks = Convert.ToDecimal(maxmarks),
                        };
                            

                        context.AreaCriterias.Add(newcriteria);
                        context.SaveChanges();
                        Console.WriteLine("newcriteria " + i + " added");
                        i++;
                        




                    }
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }

                stopwatch.Stop();
                Console.WriteLine($"Data loading completed in {stopwatch.Elapsed.TotalSeconds:F2} seconds.", "Load Time");


            }

        }


        public static void populateCompetition()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var filePath = "C:\\WS C#\\Wsc2020Day2Session2App\\Wsc2020Day2Session2ConsoleApp\\Wsc2020Day2Session2ConsoleApp\\Area-Competition.csv";

            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields();
                try
                {
                    var i = 1;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        var id = fields[0];
                        var area = fields[1];
                        var round = fields[2];

                        var areaId = context.Areas.Where(a => a.area1 == area).Select(a => a.id).FirstOrDefault();

                        if (context.AreaCompetitions.Any(u => u.id == id))
                        {
                            Console.WriteLine("competition " + i + " already exists");
                        }
                        else
                        {
                            var competition = new AreaCompetition
                            {
                                id = id,
                                areaId = areaId,
                                round = round,
                            };
                            
                            context.AreaCompetitions.Add(competition);
                            context.SaveChanges();
                            Console.WriteLine("competition " + i + " added");
                            i++;
                        }




                    }
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }

                stopwatch.Stop();
                Console.WriteLine($"Data loading completed in {stopwatch.Elapsed.TotalSeconds:F2} seconds.", "Load Time");
                Console.ReadLine();


            }

        }


        public static void populateJudges()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var filePath = "C:\\WS C#\\Wsc2020Day2Session2App\\Wsc2020Day2Session2ConsoleApp\\Wsc2020Day2Session2ConsoleApp\\Area-Judge.csv";

            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields();
                try
                {
                    var i = 1;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        var id = fields[0];
                        var area = fields[1];
                        var name = fields[2];
                        var password = fields[3];

                        var areaId = context.Areas.Where(a => a.area1 == area).Select(a => a.id).FirstOrDefault();

                        if (context.Users.Any(u => u.id == id))
                        {
                            Console.WriteLine("User " + i + " already exists");
                        }
                        else
                        {
                            var user = new User
                            {
                                id = id,
                                userTypeId = 3,
                                name = name,
                                areaId = areaId,
                                password = password,
                            };
                            context.Users.Add(user);
                            context.SaveChanges();
                            Console.WriteLine("User " + i + " added");
                            i ++;
                        }




                    }
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }

                stopwatch.Stop();
                Console.WriteLine($"Data loading completed in {stopwatch.Elapsed.TotalSeconds:F2} seconds.", "Load Time");


            }

        }

        public static void populateCompetitors()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var filePath = "C:\\WS C#\\Wsc2020Day2Session2App\\Wsc2020Day2Session2ConsoleApp\\Wsc2020Day2Session2ConsoleApp\\Area-Competitor.csv";

            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields();
                try
                {
                    var i = 1;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                       
                        var id = fields[0];
                        var area = fields[1];
                        var name = fields[2];

                        var areaId = context.Areas.Where(a => a.area1 == area).Select(a => a.id).FirstOrDefault();
                            
                        if(context.Users.Any(u => u.id == id))
                        {
                            Console.WriteLine("User " + i + " already exists");
                        }
                        else
                        {
                            var user = new User
                            {
                                id = id,
                                userTypeId = 2,
                                name = name,
                                areaId = areaId,
                                password = id,
                            };
                            context.Users.Add(user);
                            context.SaveChanges();
                            Console.WriteLine("User " + i + " added");
                            i++;

                        }




                    }
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }

                stopwatch.Stop();
                Console.WriteLine($"Data loading completed in {stopwatch.Elapsed.TotalSeconds:F2} seconds.", "Load Time");


            }

        }
    }
}
