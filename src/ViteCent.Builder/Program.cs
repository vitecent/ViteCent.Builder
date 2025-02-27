using Microsoft.Extensions.Configuration;
using ViteCent.Builder.Core;
using ViteCent.Core.Orm;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true);

var configuration = builder.Build();
FactoryConfigExtensions.SetConfig(configuration);

var databases = await DataBaseExtensions.GetDataBase();

new GenerateExtensions().GenerateCode(databases);

Console.WriteLine("ok");

Console.ReadKey();