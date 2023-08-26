using Microsoft.Extensions.DependencyInjection;
using OrsyxSudoku.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Paperless.Test
{
    public class Helper
    {
        public static IServiceProvider Provider()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IInputFile, InputFile>();

            return services.BuildServiceProvider();

        }

        public static T GetRequiredService<T>()
        {
            var provider = Provider();
            return provider.GetRequiredService<T>();
        }
    }
}
