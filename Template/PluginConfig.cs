using BepInEx.Configuration;

namespace Template
{
    public class PluginConfig
    {
        ConfigEntry<bool> CustomConfigValue;

        // Constructor
        public PluginConfig()
        {
        }

        // Bind config values to fields
        public void BindConfig(ConfigFile _config)
        {
            CustomConfigValue = _config.Bind("General", "CustomConfigValue", true, "A custom configuration value.");
        }

        public bool GetCustomConfigValue()
        {
            return CustomConfigValue.Value;
        }
    }
}
