using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Psim.Geometry2D;
using Psim.ModelComponents;
using Psim.Particles;

namespace CellunitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            /// <summary>
			/// to test length and width of cell
			/// </summary>
            Cell c = new Cell(10, 10);
            Assert.AreEqual(10, c.Length);
            Assert.AreEqual(10, c.Width);

            /// <summary>
			/// to test Phonons.count after addPhonon
			/// </summary>
            c.AddPhonon(new Phonon(1));
            c.AddIncPhonon(new Phonon(1));
            Assert.AreEqual(1, c.Phonons.Count);

            /// <summary>
			/// to setDirection (0.5, 0.5) and test it
			/// </summary>
            Phonon p = new Phonon(1);
            p.SetDirection(0.5, 0.5);
            Assert.AreEqual(0.5, p.Direction.DX);
            Assert.AreEqual(0.5, p.Direction.DY);

            /// <summary>
			/// to move cell left and test it 
			/// </summary>
            BoundarySurface s = new BoundarySurface(SurfaceLocation.left, new Cell(10, 10));
            s.HandlePhonon(p);
            Assert.AreEqual(-0.5, p.Direction.DX);
            Assert.AreEqual(0.5, p.Direction.DY);


            /// <summary>
            /// to move cell top and test it 
            /// </summary>
            BoundarySurface s2 = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
            s2.HandlePhonon(p);
            Assert.AreEqual(-0.5, p.Direction.DX);
            Assert.AreEqual(-0.5, p.Direction.DY);


            /// <summary>
			/// to move cell bot and test it 
			/// </summary>
            BoundarySurface s3 = new BoundarySurface(SurfaceLocation.bot, new Cell(10, 10));
            s3.HandlePhonon(p);
            Assert.AreEqual(-0.5, p.Direction.DX);
            Assert.AreEqual(0.5, p.Direction.DY);






        }
    }
}
