namespace GeometryLibrary.UnitTest
{
    public class LibraryGeometryTests
    {
        
        [Fact]
        public void LibraryGeometry_AreaCircleTest()
        {
            Circle circle = new Circle(5);
            Assert.Equal(78.53981633974483, circle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_AreaCircleTest2()
        {
            Circle circle = new Circle(100);
            Assert.Equal(31415.926535897932, circle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_AreaCircleTest3()
        {
            Circle circle = new Circle(0);
            Assert.Equal(0, circle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_AreaTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(3.4641016151377544, triangle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_AreaTriangleTest2()
        {
            Triangle triangle = new Triangle(8, 4, 5);
            Assert.Equal(21.646304534492717, triangle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_AreaTriangleTest3()
        {
            Triangle triangle = new Triangle(10, 10, 10);
            Assert.Equal(43.30127018922193, triangle.GetArea());
        }

        [Fact]
        public void LibraryGeometry_TriangleIsRightTest()
        {
            Triangle triangle = new Triangle(10, 10, 10);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void LibraryGeometry_TriangleIsRightTest2()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }
    }
}