using System;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Soenneker.Reddit.Ads.OpenApiClient.Models;

public partial class ComponentsSchemaPostCreativeAssetsImageCreativeAsset
{
    /// <summary>Creates an image creative asset for deserialization.</summary>
    public static ComponentsSchemaPostCreativeAssetsImageCreativeAsset CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        ArgumentNullException.ThrowIfNull(parseNode);
        return new ComponentsSchemaPostCreativeAssetsImageCreativeAsset();
    }
}