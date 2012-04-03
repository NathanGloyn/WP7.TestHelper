using System.Collections;
using System.IO.IsolatedStorage;

namespace WP7.TestHelper
{

    public class ApplicationSettingsWrapper : IApplicationSettingsWrapper
    {
        public T Read<T>(string settingName)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(settingName))
                return (T) IsolatedStorageSettings.ApplicationSettings[settingName];

            return default(T);
        }

        public void Write(string settingName, object value)
        {
            if (!IsolatedStorageSettings.ApplicationSettings.Contains(settingName))
                IsolatedStorageSettings.ApplicationSettings.Add(settingName, value);
            else
                IsolatedStorageSettings.ApplicationSettings[settingName] = value;
        }

        public bool Remove(string settingName)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(settingName))
                return IsolatedStorageSettings.ApplicationSettings.Remove(settingName);

            return true;
        }

        public ICollection Values()
        {
            return IsolatedStorageSettings.ApplicationSettings.Values;
        }

        public ICollection Keys()
        {
            return IsolatedStorageSettings.ApplicationSettings.Keys;
        }

        public bool Contains(string settingName)
        {
            return IsolatedStorageSettings.ApplicationSettings.Contains(settingName);
        }

        public void Clear()
        {
            IsolatedStorageSettings.ApplicationSettings.Clear();
        }

        public void Save()
        {
            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        public bool TryGetValue<T>(string settingName, out T value)
        {
            return IsolatedStorageSettings.ApplicationSettings.TryGetValue(settingName, out value);
        }
    }
}
