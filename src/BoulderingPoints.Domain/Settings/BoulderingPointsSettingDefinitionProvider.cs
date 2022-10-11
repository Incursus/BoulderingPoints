using Volo.Abp.Settings;

namespace BoulderingPoints.Settings;

public class BoulderingPointsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BoulderingPointsSettings.MySetting1));
    }
}
