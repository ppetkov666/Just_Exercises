﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_Rental_Project.Startup))]
namespace Car_Rental_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
