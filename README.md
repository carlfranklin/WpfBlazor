# WpfBlazor

A WPF project that hosts Blazor components. 

WpfBlazor was originally built for [BlazorTrain](https://blazortrain.com) episode 71 using Visual Studio 2022 Version 17.2.0 Preview 1.0 against .NET 6 with Microsoft.AspNetCore.Components.WebView.Wpf version 6.0.200-preview.13.2865

I started with the online documentation and tutorials, which didn't work. After scraping around a bit I discovered that referencing a Razor Component was the problem. If you add your Razor components directly to the WPF app they work. I also found that you always have to have a code-behind C# class for each component, and components have to have a @namespace directive at the top of the markdown.

Once I got it all working, I expanded it by including the following features:

- Calling JavaScript from C#
- Calling C# from JavaScript
- Calling Razor components from WPF
- Calling Wpf Windows from Razor components
- Including third party Blazor components
- Handling Cascading Parameters
- Adding an _Imports.razor file
- Adding global using statements to App.xaml.cs

Feel free to add pull requests to make this demo bigger and keep it current!



