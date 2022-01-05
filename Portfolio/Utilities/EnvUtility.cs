namespace Portfolio.Utilities
{
    /// <summary>
    ///     Utility functions related to <see cref="Environment"/>.
    /// </summary>
    public static class EnvUtility
    {
        /// <summary>
        ///     Checks if the current host environment is a development environment.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if ASPNETCORE_ENVIRONMENT environment variable exists
        ///     and contains "Development", otherwise, <see langword="false" />
        /// </returns>
        public static bool IsDevelopmentEnv()
        {
            string? developmentEnvValue = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (developmentEnvValue == null)
                return false;
            if (!developmentEnvValue.Equals("Development", StringComparison.OrdinalIgnoreCase))
                return false;
            return true;
        }
    }
}
