# react-native-windows-google-analytics
Library for react-native-windows-google-analytics

## Steps:

### For using this library you will have to follow the points :

From Visual Studio Nuget Package Manager

1.) Right click on your project and choose 'Manage NuGet Packages'
2.) Search for "GoogleAnalyticsSDK"
3.) Click 'Install'.

> Refer this Link : https://googleanalyticssdk.codeplex.com/wikipage?title=Getting%20Started&referringTitle=Documentation

After added the sdk download the both C# file and paste into your project and then open you MainClass.cs and add new GoogleAnalyticsLibrary() in List function.


Now in js file follow are the procedure to call function:

### import header file:

const GoogleAnalytics = require('NativeModules').GoogleAnalyticsClass;

### For track Screen:

GoogleAnalytics.trackScreen(<screen_name>)


### For track Event:

GoogleAnalytics.trackEvent('App - stateChange', 'active')



> Github URL: https://github.com/jaypratapsingh/react-native-windows-google-analytics
