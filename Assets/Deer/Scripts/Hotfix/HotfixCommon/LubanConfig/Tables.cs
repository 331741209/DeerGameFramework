//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using Cysharp.Threading.Tasks;


namespace cfg
{
   
public sealed class Tables
{
    public Common.TbGlobalConfig TbGlobalConfig {get; private set; }
    public Error.TbErrorInfo TbErrorInfo {get; private set; }
    public Error.TbCodeInfo TbCodeInfo {get; private set; }
    public Deer.TbUIForm_Config TbUIForm_Config {get; private set; }
    public Deer.TbSounds_Config TbSounds_Config {get; private set; }
    public Deer.TbLanguage_Config TbLanguage_Config {get; private set; }

    public Tables() { }
    
    public async UniTask LoadAsync(System.Func<string, UniTask<ByteBuf>> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbGlobalConfig = new Common.TbGlobalConfig(await loader("common_tbglobalconfig")); 
        tables.Add("Common.TbGlobalConfig", TbGlobalConfig);
        TbErrorInfo = new Error.TbErrorInfo(await loader("error_tberrorinfo")); 
        tables.Add("Error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new Error.TbCodeInfo(await loader("error_tbcodeinfo")); 
        tables.Add("Error.TbCodeInfo", TbCodeInfo);
        TbUIForm_Config = new Deer.TbUIForm_Config(await loader("deer_tbuiform_config")); 
        tables.Add("Deer.TbUIForm_Config", TbUIForm_Config);
        TbSounds_Config = new Deer.TbSounds_Config(await loader("deer_tbsounds_config")); 
        tables.Add("Deer.TbSounds_Config", TbSounds_Config);
        TbLanguage_Config = new Deer.TbLanguage_Config(await loader("deer_tblanguage_config")); 
        tables.Add("Deer.TbLanguage_Config", TbLanguage_Config);

        TbGlobalConfig.Resolve(tables); 
        TbErrorInfo.Resolve(tables); 
        TbCodeInfo.Resolve(tables); 
        TbUIForm_Config.Resolve(tables); 
        TbSounds_Config.Resolve(tables); 
        TbLanguage_Config.Resolve(tables); 
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbGlobalConfig.TranslateText(translator); 
        TbErrorInfo.TranslateText(translator); 
        TbCodeInfo.TranslateText(translator); 
        TbUIForm_Config.TranslateText(translator); 
        TbSounds_Config.TranslateText(translator); 
        TbLanguage_Config.TranslateText(translator); 
    }
}

}