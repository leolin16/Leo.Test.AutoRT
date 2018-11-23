using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Leo.Test.AutoRT.Data;
using Leo.Test.AutoRT.Interfaces;
using Leo.Test.AutoRT.Mutations;
using Leo.Test.AutoRT.Queries;
using Leo.Test.AutoRT.Repositories;
using Leo.Test.AutoRT.Schemas;
using Leo.Test.AutoRT.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;


namespace Leo.Test.AutoRT
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; set; }
        public IHostingEnvironment _env { get; set; }
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            _env = environment;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDocumentWriter>(d => new DocumentWriter(true));
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddScoped<InventoryQuery>();
            services.AddScoped<ISchema, InventorySchema>();
            services.AddScoped<ScreenType>();
            services.AddScoped<IDataStore, DataStore>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ScreenInputType>();
            services.AddScoped<InventoryMutation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMiddleware<GraphQLMiddleware>();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // app.Run(async (context) =>
            // {
            //     if (context.Request.Path.StartsWithSegments("/api/graphql") && string.Equals(context.Request.Method, "POST", StringComparison.OrdinalIgnoreCase))
            //     {
            //         string body;
            //         using (var streamReader = new StreamReader(context.Request.Body))
            //         {
            //             body = await streamReader.ReadToEndAsync();
            //             var request = JsonConvert.DeserializeObject<GraphQLRequest>(body);
            //             var schema = new Schema { Query = new InventoryQuery() };
            //             var result = await new DocumentExecuter().ExecuteAsync(doc =>
            //             {
            //                 doc.Schema = schema;
            //                 doc.Query = request.Query;
            //             }).ConfigureAwait(false);
            //             var json = new DocumentWriter(indent: true).Write(result);
            //             await context.Response.WriteAsync(json);
            //         }
            //     }

            // });
        }
    }
}
