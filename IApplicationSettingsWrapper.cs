using System.Collections;

namespace WP7.TestHelper
{
    public interface IApplicationSettingsWrapper
    {
        /// <summary>
        /// Attempts to read a setting
        /// </summary>
        /// <typeparam name="T">The type of the value you wish to retrieve</typeparam>
        /// <param name="settingName">string containing the name of the setting to read</param>
        /// <returns>if successful value; else default value for type specified</returns>
        T Read<T>(string settingName);

        /// <summary>
        /// Writes the value to the specified setting if it exists or adds it if it doesn't exist
        /// </summary>
        /// <param name="settingName">string containing the name of the setting to write</param>
        /// <param name="value">object holding value to write</param>
        void Write(string settingName, object value);

        /// <summary>
        /// Saves the application settings
        /// </summary>
        void Save();

        /// <summary>
        /// Removes specific setting
        /// </summary>
        /// <param name="settingName">string containing the name of the setting to remove</param>
        /// <returns>true if setting was either not there or sucessfully removed; otherwise returns false</returns>
        bool Remove(string settingName);

        /// <summary>
        /// Clears all application settings
        /// </summary>
        void Clear();

        /// <summary>
        /// Returns a collection of all values held in settings
        /// </summary>
        /// <returns>ICollection of values</returns>
        ICollection Values();

        /// <summary>
        /// Returns collection of all keys held in settings
        /// </summary>
        /// <returns>ICollection of the keys</returns>
        ICollection Keys();

        /// <summary>
        /// Determines if ApplicationSettings contains a specific setting
        /// </summary>
        /// <param name="settingName">string containing name of setting to search for</param>
        /// <returns>true if setting found; otherwise false</returns>
        bool Contains(string settingName);

        /// <summary>
        /// Attempts to retrieve a value
        /// </summary>
        /// <typeparam name="T">The type of the value to be returned</typeparam>
        /// <param name="settingName">string holding name of the setting to return the value from</param>
        /// <param name="value">parameter to hold the value that is extracted</param>
        /// <returns>true if gets the value; otherwise false</returns>
        bool TryGetValue<T>(string settingName, out T value);
    }
}