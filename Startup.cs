using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace App_Start
{
    public partial class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}