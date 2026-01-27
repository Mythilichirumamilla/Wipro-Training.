using DesignPatternsProject.Singleton;
using DesignPatternsProject.Factory;
using DesignPatternsProject.Observer;

Console.WriteLine("DESIGN PATTERNS DEMO\n");

// Singleton
Logger.Instance.Log("Application started");

// Factory
IDocument pdf = DocumentFactory.CreateDocument("PDF");
pdf.Open();

IDocument word = DocumentFactory.CreateDocument("WORD");
word.Open();

// Observer
WeatherStation station = new WeatherStation();

WeatherDisplay display1 = new WeatherDisplay("Display 1");
WeatherDisplay display2 = new WeatherDisplay("Display 2");

station.Register(display1);
station.Register(display2);

station.SetTemperature(30);

Console.ReadLine();
