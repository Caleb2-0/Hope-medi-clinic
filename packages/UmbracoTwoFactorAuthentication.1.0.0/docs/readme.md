Plugin based on Twillio sms provide

After package installed you need to connfigure your web.config Twilio.AccountSID, Twilio.AuthToken, Twilio.ServiceSid and key to connect to Twilio services.

<add key="Twilio.AccountSID" value="Value" />
<add key="Twilio.AuthToken" value="Value" />
<add key="Twilio.ServiceSid" value="Value" />

You need to change owin:appStartup to TwoFactorBackOfficeOwinStartup
<add key="owin:appStartup" value="TwoFactorBackOfficeOwinStartup" />

If you use custom owin:appStartup you just need to change UmbracoBackOfficeUserManager on override ConfigureUmbracoAuthentication method
Example:

 protected override void ConfigureUmbracoAuthentication(IAppBuilder app)
{
    base.ConfigureUmbracoAuthentication(app);

    app.SetUmbracoLoggerFactory();

    var applicationContext = Services;
    // There are several overloads of this method that allow you to customize the BackOfficeUserManager or even custom BackOfficeUserStore.
    app.ConfigureUserManagerForUmbracoBackOffice<TwoFactorBackOfficeUserManager, BackOfficeIdentityUser>(
            Umbraco.Web.Composing.Current.RuntimeState,
            GlobalSettings,
            (options, context) =>
            {
                var membershipProvider = MembershipProviderExtensions
                .GetUsersMembershipProvider()
                .AsUmbracoMembershipProvider();

                var userManager = TwoFactorBackOfficeUserManager.Create(
                    options,
                    applicationContext.UserService,
                    applicationContext.MemberTypeService,
                    applicationContext.EntityService,
                    applicationContext.ExternalLoginService,
                    membershipProvider,
                    GlobalSettings,
                    Mapper);

                return userManager;
            });

    app
        .UseUmbracoBackOfficeCookieAuthentication(UmbracoContextAccessor, RuntimeState, Services.UserService, GlobalSettings, UmbracoSettings.Security, PipelineStage.Authenticate)
        .UseUmbracoBackOfficeExternalCookieAuthentication(UmbracoContextAccessor, RuntimeState, GlobalSettings, PipelineStage.Authenticate)
        .UseUmbracoPreviewAuthentication(UmbracoContextAccessor, RuntimeState, GlobalSettings, UmbracoSettings.Security, PipelineStage.Authorize)
        // For 2 fa auth
        .UseTwoFactorSignInCookie(global::Umbraco.Core.Constants.Security.BackOfficeTwoFactorAuthenticationType, TimeSpan.FromMinutes(5));
}