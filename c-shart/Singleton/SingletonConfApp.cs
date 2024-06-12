using System.Collections.Generic;
using System;
namespace Singleton
{
    public sealed class SingletonConfApp
    {
        private static SingletonConfApp? Instance;
        private Dictionary<string, string> setting = new Dictionary<string, string>();
        private SingletonConfApp(){}

        public static SingletonConfApp GetInstance{
            get{
            if(Instance == null){
                return new SingletonConfApp();
            }
            return Instance;
            }
        }

        public string? GetSetting(string key){
            if(setting.ContainsKey(key)){
                return setting[key];
            }else
            {
                return null;
            }
        }
        /// <summary>
        /// The function `SetSetting` updates an existing setting value if the key already exists in the
        /// dictionary, or adds a new key-value pair if the key does not exist.
        /// </summary>
        /// <param name="key">The `key` parameter is a string that represents the identifier or name of
        /// a setting in the settings collection.</param>
        /// <param name="value">The `value` parameter in the `SetSetting` method represents the value
        /// that you want to associate with a specific key in the settings dictionary. This method
        /// checks if the key already exists in the dictionary. If it does, the value associated with
        /// that key is updated to the new value provided. If</param>
        public void SetSetting(string key, string value){
            if (setting.ContainsKey(key))
            {
                setting[key] = value;
            }
            else
            {
                setting.Add(key, value);
            }
        }
    }
}