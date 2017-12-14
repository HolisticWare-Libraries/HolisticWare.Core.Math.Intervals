# Dotnet new template of the Xamarin Components team

This is folder structure used by Xamarin Components team:


*   source
    
    bindings libraries and/or cross platform libraries with extensions

    NOTE: assembly-names and namespaces are prepared for nuget bait-n-switch

*   samples

    Samples for the libraries

*   tests

    *   unit tests

    *   ui tests




## Structure

    ├── External-Dependency-Info.txt
    ├── LICENSE.md
    ├── build.cake
    ├── docs
    ├── nuget
    │   └── HolisticWare.HolisticWare_Core_Math_Intervals.nuspec
    ├── readme.md
    ├── samples
    │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinAndroid
    │   │   ├── Assets
    │   │   │   └── AboutAssets.txt
    │   │   ├── MainActivity.cs
    │   │   ├── Properties
    │   │   │   ├── AndroidManifest.xml
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Resources
    │   │   │   ├── AboutResources.txt
    │   │   │   ├── Resource.designer.cs
    │   │   │   ├── drawable
    │   │   │   ├── layout
    │   │   │   │   └── Main.axml
    │   │   │   ├── mipmap-hdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-mdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xhdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xxhdpi
    │   │   │   │   └── Icon.png
    │   │   │   ├── mipmap-xxxhdpi
    │   │   │   │   └── Icon.png
    │   │   │   └── values
    │   │   │       └── Strings.xml
    │   │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinAndroid.csproj
    │   │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinAndroid.csproj.user
    │   │   └── packages.config
    │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinIOS
    │   │   ├── AppDelegate.cs
    │   │   ├── Assets.xcassets
    │   │   │   ├── AppIcon.appiconset
    │   │   │   │   └── Contents.json
    │   │   │   ├── Contents.json
    │   │   │   ├── First.imageset
    │   │   │   │   ├── Contents.json
    │   │   │   │   └── vector.pdf
    │   │   │   └── Second.imageset
    │   │   │       ├── Contents.json
    │   │   │       └── vector.pdf
    │   │   ├── Entitlements.plist
    │   │   ├── FirstViewController.cs
    │   │   ├── FirstViewController.designer.cs
    │   │   ├── Info.plist
    │   │   ├── LaunchScreen.storyboard
    │   │   ├── Main.cs
    │   │   ├── Main.storyboard
    │   │   ├── Resources
    │   │   ├── SecondViewController.cs
    │   │   ├── SecondViewController.designer.cs
    │   │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinIOS.csproj
    │   │   └── packages.config
    │   └── HolisticWare_Core_Math_Intervals.Samples.sln
    ├── source
    │   ├── HolisticWare_Core_Math_Intervals.Bindings.NetStandard10
    │   │   └── HolisticWare_Core_Math_Intervals.Bindings.NetStandard10.csproj
    │   ├── HolisticWare_Core_Math_Intervals.Bindings.XamarinAndroid
    │   │   ├── Additions
    │   │   │   └── AboutAdditions.txt
    │   │   ├── Jars
    │   │   │   └── AboutJars.txt
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Transforms
    │   │   │   ├── EnumFields.xml
    │   │   │   ├── EnumMethods.xml
    │   │   │   └── Metadata.xml
    │   │   └── HolisticWare_Core_Math_Intervals.Bindings.XamarinAndroid.csproj
    │   ├── HolisticWare_Core_Math_Intervals.Bindings.XamarinIOS
    │   │   ├── ApiDefinition.cs
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Structs.cs
    │   │   └── HolisticWare_Core_Math_Intervals.Bindings.XamarinIOS.csproj
    │   ├── HolisticWare_Core_Math_Intervals.NetStandard10
    │   │   └── HolisticWare_Core_Math_Intervals.NetStandard10.csproj
    │   ├── HolisticWare_Core_Math_Intervals.Source.sln
    │   ├── HolisticWare_Core_Math_Intervals.XamarinAndroid
    │   │   ├── Properties
    │   │   │   └── AssemblyInfo.cs
    │   │   ├── Resources
    │   │   │   ├── AboutResources.txt
    │   │   │   ├── Resource.designer.cs
    │   │   │   └── values
    │   │   │       └── Strings.xml
    │   │   └── HolisticWare_Core_Math_Intervals.XamarinAndroid.csproj
    │   └── HolisticWare_Core_Math_Intervals.XamarinIOS
    │       ├── Properties
    │       │   └── AssemblyInfo.cs
    │       ├── Resources
    │       └── HolisticWare_Core_Math_Intervals.XamarinIOS.csproj
    └── tests
        ├── ui-tests
        │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinAndroid.UITests
        │   │   ├── Tests.cs
        │   │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinAndroid.UITests.csproj
        │   │   └── packages.config
        │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinIOS.UITests
        │   │   ├── Tests.cs
        │   │   ├── HolisticWare_Core_Math_Intervals.Sample.XamarinIOS.UITests.csproj
        │   │   └── packages.config
        │   └── HolisticWare_Core_Math_Intervals.UITests.sln
        └── unit-tests
            └── HolisticWare_Core_Math_Intervals.UnitTests.sln
