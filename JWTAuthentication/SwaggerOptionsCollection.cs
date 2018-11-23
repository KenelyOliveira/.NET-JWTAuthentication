namespace JWTAuthentication
{
    public class SwaggerOptionsCollection
    {
        public SwaggerOptions Admin { get; set; }
        public SwaggerOptions FrontEnd { get; set; }
        public SwaggerOptions Secure { get; set; }
    }

    public class SwaggerOptions
    {
        public string APIName { get; set; }
        public string APIVersion { get; set; }
        public string Description { get; set; }
    }
}