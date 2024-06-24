using Insphere.Reader.Extensions;
using Insphere.Reader.Models;

namespace Insphere.Reader.Testing
{
    public class DriftPathRawDataExtensionsTests
    {
        [Fact]
        public void ValidPathDriftRawDataPassesValidityCheck()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            double x = random.NextDouble();
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.Validate();

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void PathDriftRawDataWithNullValueFailsValidityCheck()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            double? x = null;
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.Validate();

            //Assert
            Assert.False(result);
        }
        [Fact]
        public void PathDriftRawDataWithIncorrectFieldValueTypeFailsValidityCheck()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            string x = "string";
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.Validate();

            //Assert
            Assert.False(result);
        }
        [Fact]
        public void PathDriftRawDataWithEmptyStringFailsValidityCheck()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            string x = "";
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.Validate();

            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ValidPathDriftRawDataConversionSuccessful()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            double x = random.NextDouble();
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.ConvertToPathDriftCoordinate();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.ID);
            Assert.Equal(index, result.Index);
            Assert.Equal(x, result.X);
            Assert.Equal(y, result.Y);
            Assert.Equal(z, result.Z);
            Assert.Equal(rx, result.Rx);
            Assert.Equal(ry, result.Ry);
            Assert.Equal(rz, result.Rz);
            Assert.Equal(ux, result.Ux);
            Assert.Equal(uy, result.Uy);
            Assert.Equal(uz, result.Uz);
            Assert.Equal(utranslation, result.UTranslation);
            Assert.Equal(urx, result.URx);
            Assert.Equal(ury, result.URy);
            Assert.Equal(urz, result.URz);
        }
        [Fact]
        public void InvalidPathDriftRawDataConversionUnsuccessful()
        {
            // Arrange
            string id = "Path_2";
            int index = 1;
            var random = new Random();
            string x = "string";
            double y = random.NextDouble();
            double z = random.NextDouble();
            double rx = random.NextDouble();
            double ry = random.NextDouble();
            double rz = random.NextDouble();
            double ux = random.NextDouble();
            double uy = random.NextDouble();
            double uz = random.NextDouble();
            double utranslation = random.NextDouble();
            double urx = random.NextDouble();
            double ury = random.NextDouble();
            double urz = random.NextDouble();
            var data = new PathDriftRawData
            {
                ID = id.ToString(),
                Index = index.ToString(),
                X = x.ToString(),
                Y = y.ToString(),
                Z = z.ToString(),
                Rx = rx.ToString(),
                Ry = ry.ToString(),
                Rz = rz.ToString(),
                Ux = ux.ToString(),
                Uy = uy.ToString(),
                Uz = uz.ToString(),
                UTranslation = utranslation.ToString(),
                URx = urx.ToString(),
                URy = ury.ToString(),
                URz = urz.ToString(),
            };

            // Act
            var result = data.ConvertToPathDriftCoordinate();

            //Assert
            Assert.Null(result);
        }
    }
}