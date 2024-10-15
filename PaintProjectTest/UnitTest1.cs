using PaintProject;
using floorAndWalls;

namespace floorAndWalls
{
    public class PaintProjectUnitTest
    {
        [Fact]
        public void TestFloorArea()
        {
            //Arrange: set up the inputs and the units under testing
            float floorWidth = 4f;
            float floorHeight = 10f;
            float expected = 40f;

            //Act: Execute the function to test
            Floor floor = new Floor(floorHeight, floorWidth);
            float actual = floor.Area;
            //Assert: Make assertions to compared actual results
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFloorConstructorForInvalidDimensionsException()
        {
            // Arrange
            float invalidWidth = -4f;
            float invalidHeight = 10f;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Floor(invalidHeight, invalidWidth));
        }

        [Fact]
        public void TestWallArea()
        {
            //Arrange: set up the inputs and outputs
            float WallWidth = 1f;
            float WallHeight = 2.7f;
            float expected = 2.7f;

            //Act: Execute the function to test
            Wall wall1 = new Wall(WallHeight, WallWidth);
            float actual = wall1.Area;

            //Assert: Make assertion to compare actual results
            Assert.Equal(actual, expected);

        }

        public void TestWallConstructorForInvalidDimensionsException()
        {
            // Arrange
            float invalidWidth = -4f;
            float invalidHeight = 10f;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Floor(invalidHeight, invalidWidth));
        }

        //[Fact]
        //public void TestFloorAreaForException()
        //{
        //    //Arrange: set up the inputs and the units under testing
        //    float floorWidth = 4f;
        //    float floorHeight = 10f;
        //    float expected = 40f;
        //    string error = "error una";

        //    //Act: Execute the function to test
        //    Floor floor = new Floor(floorHeight, floorWidth);
        //    float actual = floor.Area;
        //    //Assert: Make assertions to compared actual results
        //    Assert.IsNotAssignableFrom(Type.GetType(error), expected);
        //}

        //[Fact]
        //public void TestWallAreaForException()
        //{
        //    //Arrange: set up the inputs and the units under testing
        //    float floorWidth = 4f;
        //    float floorHeight = 10f;
        //    float expected = 40f;
        //    string error = "error una"

        //    //Act: Execute the function to test
        //    Floor floor = new Floor(floorHeight, floorWidth);
        //    float actual = floor.Area;
        //    //Assert: Make assertions to compared actual results
        //    Assert.IsNotAssignableFrom(Type.GetType(error), expected);
        //}


        //[Fact]
        //public void TestPaint()
        //{
        //    //Arrange
        //    Wall wall1 = new Wall(2, 10);
        //    Wall wall2 = new Wall(2, 10);
        //    Wall wall3 = new Wall(2, 10);
        //    Wall wall4 = new Wall(2, 10);

        //    wa


        //}

    }

}