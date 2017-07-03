Louvre Binding for Xamarin
=============================

Xamarin bindings library for the Android [Louvre library](https://github.com/andremion/Louvre).

Plugin is available on [Nuget](https://www.nuget.org/packages/Xamarin.Bindings.Louvre/).

Installation
------------
    Install-Package Xamarin.Bindings.Louvre

Usage
-----
For details, please see the [original Louvre documentation](https://github.com/andremion/Louvre#usage).

Declare the Louvre activities in AndroidManifest.xml file using your new app themes.
```xml
<activity
    android:name="com.andremion.louvre.home.GalleryActivity"
    android:theme="@style/AppTheme.Louvre.Light.DarkActionBar" />
<activity
    android:name="com.andremion.louvre.preview.PreviewActivity"
    android:theme="@style/AppTheme.Louvre.Preview" />
```
Add READ_EXTERNAL_STORAGE permission in your AndroidManifest.xml file.
```xml
<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
```
In your Activity you just need the below lines of code to open the Louvre.
```csharp
List<Uri> selection = ...;

Louvre.init(myActivity)
      .SetRequestCode(myRequestCode)
      .SetMaxSelection(10)
      .SetSelection(selection)
      .SetMediaTypeFilter(Louvre.ImageTypeJpeg, Louvre.ImageTypePng)
      .Open();
```
Build
-----
To automatically download the latest AAR, update the version information in AssemlyInfo.cs and the nuspec file and then build and package the binding assembly, just run `build.bat` in the Visual Studio Developer Command Prompt.

License
--------

    Copyright 2017 Munir Husseini

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
