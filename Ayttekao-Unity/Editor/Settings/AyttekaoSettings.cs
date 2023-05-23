namespace Ayttekao.Unity.Editor
{
    public class AyttekaoSettings : AyttekaoScriptableSingleton<AyttekaoSettings>
    {
        internal const string FilePath = "UserSettings/AyttekaoSettings.asset";

        public AyttekaoSettingsGeneral General = new AyttekaoSettingsGeneral();

        public AyttekaoSettingsGrid2D Grid2D = new AyttekaoSettingsGrid2D();

        public void Save()
        {
            Save(true);
        }
    }
}