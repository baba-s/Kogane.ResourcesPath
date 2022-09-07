# Kogane Resources Path

アセットのパスを Resources.Load で使用するパスに変換するクラス

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        // Materials/New Material
        Debug.Log( ResourcesPath.Get( "Assets/@Project/Resources/Materials/New Material.mat" ) );

        // New Material
        Debug.Log( ResourcesPath.Get( "Resources/New Material.mat" ) );

        // DOTweenSettings
        Debug.Log( ResourcesPath.Get( "Assets/Plugins/Demigiant/DOTween/Resources/DOTweenSettings.asset" ) );

        // Assets/Plugins/Demigiant/DOTween/Editor/DOTweenEditor.dll
        Debug.Log( ResourcesPath.Get( "Assets/Plugins/Demigiant/DOTween/Editor/DOTweenEditor.dll" ) );
    }
}
```