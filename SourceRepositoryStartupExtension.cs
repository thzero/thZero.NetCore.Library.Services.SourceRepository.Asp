/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Factories.DryIoc
Copyright (C) 2016-2019 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using System;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using thZero.Configuration;

namespace thZero.AspNetCore
{
    public class SourceRepositoryStartupExtension : BaseStartupExtension
    {
        #region Protected Methods
        public override void ConfigureServicesInitializeMvcPost(IServiceCollection services, IWebHostEnvironment env, IConfiguration configuration)
        {
            base.ConfigureServicesInitializeMvcPost(services, env, configuration);

            var config = configuration.GetSection("Application").GetSection("SourceRepository");
            services.Configure<SourceRepository>(config);
        }
        #endregion
    }
}
