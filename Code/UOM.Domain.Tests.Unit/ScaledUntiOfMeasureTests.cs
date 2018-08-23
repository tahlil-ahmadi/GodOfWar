using System;
using FluentAssertions;
using UOM.Domain.Model.Dimensions;
using UOM.Domain.Model.UnitOfMeasures;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class ScaledUntiOfMeasureTests
    {
        private readonly BaseUnitOfMeasure _baseMeasurement;
        public ScaledUntiOfMeasureTests()
        {
            var dimension = new Dimension(1,"Length");
            _baseMeasurement = new BaseUnitOfMeasure(dimension, "Meter", "MR");
        }

        [Fact]
        public void Convert_should_convert_amount_to_a_bigger_unitOfMeasure()
        {
            var sourceMeasurement = new ScaledUnitOfMeasure(_baseMeasurement,"Centimeter","CM",100);
            var targetMeasurement = new ScaledUnitOfMeasure(_baseMeasurement,"Kilometer","KM",0.001M);

            var result = sourceMeasurement.ConvertTo(targetMeasurement, 500000);

            result.Should().Be(5);
        }

        [Fact]
        public void Convert_should_convert_amount_to_a_smaller_unitOfMeasure()
        {
            var targetMeasurement = new ScaledUnitOfMeasure(_baseMeasurement, "Centimeter", "CM", 100);
            var sourceMeasurement = new ScaledUnitOfMeasure(_baseMeasurement, "Kilometer", "KM", 0.001M);

            var result = sourceMeasurement.ConvertTo(targetMeasurement, 5);

            result.Should().Be(500000);
        }

        [Fact]
        public void Convert_should_convert_amount_to_a_itself()
        {
            var sourceMeasurement = new ScaledUnitOfMeasure(_baseMeasurement, "Centimeter", "CM", 100);

            var result = sourceMeasurement.ConvertTo(sourceMeasurement, 5);

            result.Should().Be(5);
        }

        [Fact]
        public void Convert_should_convert_amount_to_BaseUnitOfMeasure()
        {
            var sourceMeasurement = new ScaledUnitOfMeasure(_baseMeasurement, "Centimeter", "CM", 100);

            var result = sourceMeasurement.ConvertToBaseMeasurement(5000);

            result.Should().Be(50);
        }
    }
}
