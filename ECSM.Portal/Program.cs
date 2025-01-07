#region usings
using EC.DynamicsClient;
using ECSM.Portal.Components;
using ECSM.Portal.Components.Sections.KnowledgeArticle;
using ECSM.Portal.Managers;
using ECSM.Services;
using ECSM.Services.Cases;
using ECSM.Services.CatalogueItem;
using ECSM.Services.Category;
using ECSM.Services.PortalLink;
using ECSM.Services.ServiceCatalogue;
using ECSM.Services.ServiceCatalogueItem;
using ECSM.Services.SettingsService;
using ECSM.Services.Sites;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
#endregion

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();

builder.Services.AddDynamicsClients();

// Add services to the container.
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

builder.Services.AddSession(options =>
{
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.IsEssential = true;
});

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.OnAppendCookie = cookieContext =>
      CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
    options.OnDeleteCookie = cookieContext =>
      CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
});

void CheckSameSite(HttpContext httpContext, CookieOptions options)
{
    if (options.SameSite == SameSiteMode.None)
    {
        options.SameSite = (SameSiteMode)(-1);
    }
}

// Add services to the container.
builder.Services.AddMemoryCache();

// Add auth for AAD
builder.Services.AddAuthentication()
                .AddMicrosoftIdentityWebApp(options =>
                {
                   builder.Configuration.Bind("AzureActivedirectory", options);
                }, null,
                openIdConnectScheme: "AAD", null);

// Add auth for B2C
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApp(options =>
                {
                   builder.Configuration.Bind("AzureB2C", options);
                },
                openIdConnectScheme: "B2C", cookieScheme: OpenIdConnectDefaults.AuthenticationScheme);

builder.Services.AddControllersWithViews()
                .AddMicrosoftIdentityUI();

builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<SearchResults>();
builder.Services.AddScoped<AuthManager>();
builder.Services.AddScoped<NavManager>();
builder.Services.AddScoped<IAnnouncementQueryService, AnnouncementQueryService>();
builder.Services.AddScoped<IUserRolesQueryService, UserRolesQueryService>();
builder.Services.AddScoped<IContactQueryService, ContactQueryService>();
builder.Services.AddScoped<IKnowledgeService, KnowledgeService>();
builder.Services.AddScoped<ICaseService, CaseService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IServiceCatalogueService, ServiceCatalogueService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISiteService, SiteService>();
builder.Services.AddScoped<IServiceCatalogueItemService, ServiceCatalogueItemService>();
builder.Services.AddScoped<ICatalogueItemService, CatalogueItemService>();
builder.Services.AddScoped<IPortalLinkService, PortalLinkService>();
builder.Services.AddScoped<ISettingsService, SettingsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
