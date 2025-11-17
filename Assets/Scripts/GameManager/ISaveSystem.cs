public interface ISaveSystem
{
    void Save(string key, int value);
    int Load(string key, int defaultValue = 0);
}
