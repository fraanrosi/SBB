using SBB.Core.Interfaces;

namespace SBB.Core.Services;

public class UriComposer : IUriComposer
{
    private readonly SBBSettings _SBBSettings;

    public UriComposer(SBBSettings SBBSettings) => _SBBSettings = SBBSettings;

    public string ComposePicUri(string uriTemplate)
    {
        return uriTemplate.Replace("http://SBBbaseurltobereplaced", _SBBSettings.SBBBaseUrl);
    }
}
