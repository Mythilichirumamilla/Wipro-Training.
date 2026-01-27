using SolidPrinciplesProject.SRP;

Console.WriteLine("SOLID Principles Demo");

ReportGenerator generator = new ReportGenerator();
ReportSaver saver = new ReportSaver();

string report = generator.GenerateReport();
saver.SaveReport(report);

Console.ReadLine();
