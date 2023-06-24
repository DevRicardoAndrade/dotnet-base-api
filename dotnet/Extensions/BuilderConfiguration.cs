namespace dotnet.Extensions
{
    public static class BuilderConfiguration
    {
        public static WebApplication BuilderConfigurationDefault(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();  

            app.UseAuthorization();

            app.MapControllers();   
            return app;
        }
    }
}
