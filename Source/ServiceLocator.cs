namespace ZenServiceLocator.Source
{
    /// <summary>
    /// Service Locator. Used for services that need to exist before the creation of a <see cref="Engine"/> instance e.g. Logging
    /// </summary>
    public class ServiceLocator : AbstractServiceLocator<IService>
    {

        public static ServiceLocator Instance { get; } = new ServiceLocator();

        public static T GetService<T>(string id = null) where T : IService
        {
            return Instance.BaseGetService<T>(id);
        }

        public static void RegisterService<T>(IService service, string id = null) where T : IService
        {
            Instance.BaseRegisterService<T>(service, id);
        }

        public static void UnregisterService<T>(string id = null) where T : IService
        {
            Instance.BaseUnregisterService<T>(id);
        }
    }
}