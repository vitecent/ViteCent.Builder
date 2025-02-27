using log4net;
using ViteCent.Builder.Data;
using ViteCent.Core;

namespace ViteCent.Builder.Core
{
    /// <summary>
    ///     GenerateExtensions
    /// </summary>
    public class GenerateExtensions
    {
        /// <summary>
        ///     ILog
        /// </summary>
        private readonly ILog _logger;

        /// <summary>
        ///     GenerateExtensions
        /// </summary>
        public GenerateExtensions()
        {
            _logger = BaseLogger.GetLogger();
        }

        /// <summary>
        ///     GenerateCode
        /// </summary>
        /// <param name="databases"></param>
        public void GenerateCode(List<DataBase> databases)
        {
            foreach (var database in databases)
            {
                var setting = new Setting
                {
                    ProjrectName = database.Name
                };

                var root = Path.Combine(setting.Root, setting.SolutionName, "src");

                _logger.Info($"Root {root}");

                var dir = Directory.GetCurrentDirectory();
                var nh = new NVelocityExpand(dir);

                nh.Put("DataBase", database);
                nh.Put("Setting", setting);

                GenerateData(setting, root, database, nh);

                GenerateEntity(setting, root, database, nh);

                GenerateApi(setting, root, database, nh);

                GenerateMapper(setting, root, database, nh);

                GenerateApplication(setting, root, database, nh);

                GenerateDomain(setting, root, database, nh);
            }
        }

        /// <summary>
        ///     GenerateApi
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateApi(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (!settings.GenerateApi) return;

            foreach (var table in database.Tables)
            {
                var path = Path.Combine(root, settings.ProjrectName, $"{settings.ProjrectName}.{settings.ApiName}", table.Name.ToCamelCase());

                _logger.Info($"Generate Api {table.Name.ToCamelCase()}");

                nh.Put("Table", table);

                nh.Save(@"Template\Api\Add", Path.Combine(path, $"{settings.AddName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Api\Edit", Path.Combine(path, $"{settings.EditName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Api\Get", Path.Combine(path, $"{settings.GetName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Api\Page", Path.Combine(path, $"{settings.PageName}{table.Name.ToCamelCase()}.cs"));
            }
        }

        /// <summary>
        ///     GenerateApplication
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateApplication(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (!settings.GenerateApplication) return;

            foreach (var table in database.Tables)
            {
                var path = Path.Combine(root, settings.ProjrectName, $"{settings.ProjrectName}.{settings.ApplicationName}", table.Name.ToCamelCase());

                _logger.Info($"Generate Application {table.Name.ToCamelCase()}");

                nh.Put("Table", table);

                nh.Save(@"Template\Application\Add", Path.Combine(path, $"{settings.AddName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Application\Edit", Path.Combine(path, $"{settings.EditName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Application\Get", Path.Combine(path, $"{settings.GetName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Application\Page", Path.Combine(path, $"{settings.PageName}{table.Name.ToCamelCase()}.cs"));
            }
        }

        /// <summary>
        ///     GenerateData
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateData(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (!settings.GenerateData) return;

            foreach (var table in database.Tables)
            {
                var path = Path.Combine(root, settings.DataProjrectName, $"{settings.ProjrectName}.{settings.DataName}", table.Name.ToCamelCase());

                _logger.Info($"Generate Data {table.Name.ToCamelCase()}");

                var removeField = new List<string>() { "Id", "Status", "DataVersion", "Creator", "CreateTime", "Updater", "UpdateTime" };
                var addField = table.Fields.Where(x => !removeField.Contains(x.Name.ToCamelCase())).ToList();

                nh.Put("Table", table);
                nh.Put("AddFields", addField);
                nh.Put("Fields", table.Fields);

                nh.Save(@"Template\Data\AddArgs", Path.Combine(path, $"{settings.AddName}{table.Name.ToCamelCase()}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\EditArgs", Path.Combine(path, $"{settings.EditName}{table.Name.ToCamelCase()}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\GetArgs", Path.Combine(path, $"{settings.GetName}{table.Name.ToCamelCase()}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\GetEntityArgs", Path.Combine(path, $"{settings.GetName}{table.Name.ToCamelCase()}{settings.EntityName}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\SearchArgs", Path.Combine(path, $"{settings.DataSearchPrefix}{table.Name.ToCamelCase()}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\SearchEntityArgs", Path.Combine(path, $"{settings.DataSearchPrefix}{table.Name.ToCamelCase()}{settings.EntityName}{settings.DataArgsSuffix}.cs"));
                nh.Save(@"Template\Data\Result", Path.Combine(path, $"{table.Name.ToCamelCase()}{settings.DataResultSuffix}.cs"));
            }
        }

        /// <summary>
        ///     GenerateDomain
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateDomain(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (!settings.GenerateDomain) return;

            foreach (var table in database.Tables)
            {
                var path = Path.Combine(root, settings.ProjrectName, $"{settings.ProjrectName}.{settings.DomainName}", table.Name.ToCamelCase());

                _logger.Info($"Generate Domain {table.Name.ToCamelCase()}");

                nh.Put("Table", table);

                nh.Save(@"Template\Domain\Add", Path.Combine(path, $"{settings.AddName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Domain\Edit", Path.Combine(path, $"{settings.EditName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Domain\Get", Path.Combine(path, $"{settings.GetName}{table.Name.ToCamelCase()}.cs"));
                nh.Save(@"Template\Domain\Page", Path.Combine(path, $"{settings.PageName}{table.Name.ToCamelCase()}.cs"));
            }
        }

        /// <summary>
        ///     GenerateEntity
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateEntity(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (!settings.GenerateEntity) return;

            var path = Path.Combine(root, settings.ProjrectName, $"{settings.ProjrectName}.{settings.EntityName}");

            _logger.Info($"Generate Entity {path}");

            foreach (var table in database.Tables)
            {
                var baseName = "BaseEntity";
                var removeField = new List<string>() { "Id", "Status", "DataVersion", "Creator", "CreateTime", "Updater", "UpdateTime" };

                if (table.Fields.Any(x => x.Name.ToCamelCase() == "CompanyId"))
                {
                    baseName = "CompanyEntity";
                    removeField.Add("CompanyId");
                }

                var fields = table.Fields.Where(x => !removeField.Contains(x.Name.ToCamelCase())).ToList();

                nh.Put("Table", table);
                nh.Put("BaseName", baseName);
                nh.Put("Fields", fields);

                nh.Save(@"Template\Entity", Path.Combine(path, $"{table.Name.ToCamelCase()}{settings.EntitySuffix}.cs"));
            }
        }

        /// <summary>
        ///     GenerateMapper
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="root"></param>
        /// <param name="database"></param>
        /// <param name="nh"></param>
        private void GenerateMapper(Setting settings, string root, DataBase database, NVelocityExpand nh)
        {
            if (settings is not
                { GenerateData: true, GenerateEntity: true, GenerateApi: true, GenerateMapper: true }) return;

            var path = Path.Combine(root, settings.ProjrectName, $"{settings.ProjrectName}.{settings.ApiName}");

            _logger.Info($"Generate Mapper {path}");

            nh.Put("Tables", database.Tables);

            nh.Save(@"Template\AutoMapperConfig", Path.Combine(path, $"{settings.MapperName}.cs"));
        }
    }
}