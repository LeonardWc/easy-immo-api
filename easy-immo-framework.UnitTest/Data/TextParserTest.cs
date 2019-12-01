using easy_immo_framework.Data;
using easy_immo_framework.Interface;
using easy_immo_framework.Model;
using NUnit.Framework;
using System;

namespace easy_immo_framework.UnitTest.Data
{
    internal class TextParserTest
    {
        private ITextParser _textParser;

        [SetUp]
        public void Init()
        {
            _textParser = new TextParser();
        }

        [Test]
        public void Parse()
        {
            var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2018.csv", ",");
            Console.WriteLine($"Number of lines : {apparts.Count}");
            Assert.IsNotNull(apparts);
        }
    }
}