namespace AnhNgocPackaging.Infrastructure.Extenstions
{
    public class ServiceAttribute
    {
        [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
        public class SingletonServiceAttribute : Attribute { }

        [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
        public class ScopedServiceAttribute : Attribute { }

        [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
        public class TransientServiceAttribute : Attribute { }
    }
}
