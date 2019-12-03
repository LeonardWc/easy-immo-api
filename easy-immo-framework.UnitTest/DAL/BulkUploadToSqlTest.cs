using easy_immo_framework.DAL;
using easy_immo_framework.Data;
using easy_immo_framework.Interface;
using easy_immo_framework.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace easy_immo_framework.UnitTest.DAL
{
    public class BulkUploadToSqlTest
    {
        private BulkUploadToSql _database;
        private ITextParser _textParser;

        [SetUp]
        public void Init()
        {
            _database = new BulkUploadToSql(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=true");
            _textParser = new TextParser();
        }

        [Test]
        public void Insert2014()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2014.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }

        [Test]
        public void Insert2015()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2015.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }

        [Test]
        public void Insert2016()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2016.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }

        [Test]
        public void Insert2017()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2017.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }

        [Test]
        public void Insert2018()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2018.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }

        [Test]
        public void Insert2019()
        {
            //var apparts = _textParser.Parse<Appart>(@"C:\GIt\Data\immo-data-2019.csv", ",");
            //_database.Insert<Appart>(apparts, "[EasyImmo].[dbo].[Apparts]");
        }
    }
}
