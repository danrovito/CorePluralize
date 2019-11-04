using CorePluralize.Tests;
using System;
using Xunit;

namespace Pluralize.NET.Core.Tests
{
	public class PluralizerTests
    {
		Pluralizer _pluralizer = new Pluralizer();

        [Fact]
		public void InputData()
        {
			var input = Resources.InputData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
                Assert.Equal(plural, _pluralizer.Pluralize(singular));
				Assert.Equal(plural, _pluralizer.Pluralize(plural));
				Assert.Equal(singular, _pluralizer.Singularize(plural));
				Assert.Equal(singular, _pluralizer.Singularize(singular));
            }

        }

		[Fact]
		public void ExceptionPluralToSingularException()
        {
			var input = Resources.PluralToSingularExceptions.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
				Assert.Equal(singular, _pluralizer.Singularize(plural));
				Assert.Equal(singular, _pluralizer.Singularize(singular));
            }
        }

		[Fact]
		public void ExceptionSingularToPluralException()
        {
			var input = Resources.SingularToPluralExceptions.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
				Assert.Equal(plural, _pluralizer.Pluralize(singular));
				Assert.Equal(plural, _pluralizer.Pluralize(plural));
            }
        }
    }
}
