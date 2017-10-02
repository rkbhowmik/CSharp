using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace CarBuilderApp

{
	class Program
	{
		static void Main(string[] args)
		{
			SpeechSynthesizer synth = new SpeechSynthesizer();
			var aCar = new Car("Mattias Cyber Sportvan");
			var anEngine = new Engine(350, 120000M);
			var door1 = new Door(2000M);
			var door2 = new Door(1500M);
			var chassi = new Chassi(50000M);
			aCar.Parts.Add(anEngine);
			aCar.Parts.Add(door1);
			aCar.Parts.Add(door2);
			aCar.Parts.Add(chassi);
			decimal cost = aCar.Cost;
			Console.WriteLine($"{aCar} cost{cost}");
			synth.Speak($"{aCar} cost{cost}");
		}
	}
}
