using System;
using System.Data.Entity.Migrations;
using AutoMapper;
using NUnit.Framework;

namespace InternPortal.IntegrationTests
{

    [SetUpFixture]
    public class GlobalSetUp
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            var configuration = new TemplateProject.UI.Migrations.Configuration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }
    }
}