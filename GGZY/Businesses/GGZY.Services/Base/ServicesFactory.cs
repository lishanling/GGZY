using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;

namespace GGZY.Services.Base
{
    public class ServicesFactory
    {
        private static ServicesFactoryJh _instance;

        /// <summary>
        /// 招标采购
        /// </summary>
        public static ServicesFactoryJh ZBCG
        {
            get
            {
                if (_instance == null)
                {
                    var builder = new RegistrationBuilder();
                    builder
                        .ForTypesMatching(c => c.Name.EndsWith("Service"))
                        .Export();
                    builder
                        .ForType<ServicesFactoryJh>()
                        .Export()
                        .ImportProperties(c => c.Name.EndsWith("Service"));
                    var cat =
                        new AssemblyCatalog(typeof(ServicesFactoryJh).Assembly, builder);
                    var container = new CompositionContainer(cat);

                    _instance = container.GetExportedValue<ServicesFactoryJh>();
                }
                return _instance;
            }
        }

        private static ServicesFactoryFw _fwInstance;

        /// <summary>
        /// 公告资源服务
        /// </summary>
        public static ServicesFactoryFw GGZYFW
        {
            get
            {
                if (_fwInstance == null)
                {
                    var builder = new RegistrationBuilder();
                    builder
                        .ForTypesMatching(c => c.Name.EndsWith("Service"))
                        .Export();
                    builder
                        .ForType<ServicesFactoryFw>()
                        .Export()
                        .ImportProperties(c => c.Name.EndsWith("Service"));
                    var cat =
                        new AssemblyCatalog(typeof(ServicesFactoryFw).Assembly, builder);
                    var container = new CompositionContainer(cat);

                    _fwInstance = container.GetExportedValue<ServicesFactoryFw>();
                }
                return _fwInstance;
            }
        }


        private static ServicesFactoryJd _jdInstance;
        /// <summary>
        /// 公共资源监督
        /// </summary>
        public static ServicesFactoryJd GGZYJD
        {
            get
            {
                if (_jdInstance == null)
                {
                    var builder = new RegistrationBuilder();
                    builder
                        .ForTypesMatching(c => c.Name.EndsWith("Service"))
                        .Export();
                    builder
                        .ForType<ServicesFactoryJd>()
                        .Export()
                        .ImportProperties(c => c.Name.EndsWith("Service"));
                    var cat =
                        new AssemblyCatalog(typeof(ServicesFactoryJd).Assembly, builder);
                    var container = new CompositionContainer(cat);

                    _jdInstance = container.GetExportedValue<ServicesFactoryJd>();
                }
                return _jdInstance;
            }
        }
    }
}