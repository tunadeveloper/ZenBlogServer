namespace ZenBlog.API.Endpoints.Registration;

public static class EndpointRegistations
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder app)
    {
        app.RegisterCategoryEndPoints();
    }
}