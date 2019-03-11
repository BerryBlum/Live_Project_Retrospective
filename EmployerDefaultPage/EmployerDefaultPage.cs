 public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "Employer_default",
                url: "Employer/{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"ScheduleUsers.Areas.Employer.Controllers"}
            );
        }