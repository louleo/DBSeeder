namespace TaskOrganizorDBSeeder
{
    public static class AppConfig
    {
        public static string HostName { get; set; } = "localhost";

        public static string Port { get; set; } = "5432";

        public static string Password { get; set; } = "password";

        public static string Username { get; set; } = "postgres";

        public static string DatabaseName { get; set; } = "postgres_db";

        public static string ToConnectionString()
        {
            return $"Host={HostName};Database={DatabaseName};Username={Username};Password={Password};Port={Port}";
        }
    }
}