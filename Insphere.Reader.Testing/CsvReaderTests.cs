using Insphere.Reader.Services.CsvReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Insphere.Reader.Testing
{
    public class CsvReaderTests
    {
        [Fact]
        public async void CsvReaderReadsValidDriftPathDataReadsDataSuccessfully()
        {
            // Arrange
            var path = Path.Combine(Environment.CurrentDirectory, "Data", "valid.csv");
            var csvReader = new CsvReader();

            // Act
            var response = await csvReader.ReadDriftPathData(path, CancellationToken.None);

            // Assert
            Assert.NotNull(response);
            Assert.True(response.Success);

            // Ensure that all fields are being read correctly
            var first = response.RawData.FirstOrDefault();
            Assert.NotNull(first);
            Assert.Equal("Path_2", first.ID);
            Assert.Equal("0", first.Index);
            Assert.Equal("-308.3428217", first.X);
            Assert.Equal("-104.3258526", first.Y);
            Assert.Equal("614.7202431", first.Z);
            Assert.Equal("1.470218752", first.Rx);
            Assert.Equal("2.290488904", first.Ry);
            Assert.Equal("-91.87757768", first.Rz);
            Assert.Equal("0", first.Ux);
            Assert.Equal("0", first.Ux);
            Assert.Equal("0", first.Uz);
            Assert.Equal("0", first.UTranslation);
            Assert.Equal("0", first.URx);
            Assert.Equal("0", first.URy);
            Assert.Equal("0", first.URz);

            Assert.Equal(5, response.RawData.Count());
        }
        [Fact]
        public async void CsvReaderReadsInvalidDriftPathDataReadsDataUnsuccessfully()
        {
            // Arrange
            var path = Path.Combine(Environment.CurrentDirectory, "Data", "invalid.csv");
            var csvReader = new CsvReader();

            // Act
            var response = await csvReader.ReadDriftPathData(path, CancellationToken.None);

            // Assert
            Assert.NotNull(response);

            // Ensure that all invalid (null/string/empty) values are read
            Assert.Equal("", response.RawData[1].Uz);
            Assert.Equal("null", response.RawData[2].URx);
            Assert.Equal("hello", response.RawData[2].X);
            Assert.Equal("", response.RawData[4].Y);

            Assert.Equal(5, response.RawData.Count());
        }
    }
}
