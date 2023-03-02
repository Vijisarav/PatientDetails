using PateintDetail;
using PateintDetail.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IPatientServices, PatientServices>();
builder.Services.AddTransient<IJsonSerialization, JsonSerialization>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "";
    options.DefaultChallengeScheme = "";
})  .AddJwtBearer("Bearer", jwtOptions =>
{
    jwtOptions.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
       // IssuerSigningKey = Authenticate.signinKey,
        ValidAudience = "",
        ValidIssuer = "",
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateAudience = true,
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
