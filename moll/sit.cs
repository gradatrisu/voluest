public float GetFloat(string key, float defaultValue = 0f)
{
    if (string.IsNullOrEmpty(key))
    {
        throw new ArgumentNullException(nameof(key));
    }

    if (_config == null)
    {
        throw new InvalidOperationException("Config not initialized");
    }

    if (_config.ContainsKey(key))
    {
        string value = _config[key].ToString();
        if (float.TryParse(value, out float result))
        {
            return result;
        }
    }

    return defaultValue;
}
