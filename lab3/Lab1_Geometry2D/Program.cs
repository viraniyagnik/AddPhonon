using Psim.Particles;
using Psim.Geometry2D;
using Psim.ModelComponents;
using System;
using System.Collections.Generic;

namespace Psim
{
	class Program
	{
		static void Main(string[] args)
		{
			/// <summary>
			/// AddPhonon and AddIncPhonon into c
			/// </summary>
			Cell c = new Cell(10,10);
			c.AddPhonon(new Phonon(1));
			c.AddIncPhonon(new Phonon(1));
			Console.WriteLine(c);

			/// <summary>
			/// set Direction (0.5, 0.5)
			/// </summary>
			Phonon p = new Phonon(1);
			p.SetDirection(0.5, 0.5);
			BoundarySurface s = new BoundarySurface(SurfaceLocation.left, new Cell(10, 10));
			BoundarySurface s1 = new BoundarySurface(SurfaceLocation.right, new Cell(10, 10));
			BoundarySurface s2 = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
			BoundarySurface s3 = new BoundarySurface(SurfaceLocation.bot, new Cell(10, 10));

			/// <summary>
			/// to set enum value base on enum like left, right, top and botumn
			/// </summary>
			Console.WriteLine(p);
			s.HandlePhonon(p);
			Console.WriteLine(p);
			s1.HandlePhonon(p);
			Console.WriteLine(p);
			s2.HandlePhonon(p);
			Console.WriteLine(p);
			s3.HandlePhonon(p);
			Console.WriteLine(p);




		}
	}
}
