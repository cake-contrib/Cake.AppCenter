# Cake.AppCenter

A Cake AddIn that extends Cake with [AppCenter](https://github.com/Microsoft/appcenter-cli/) command tools. Based on older addin version for MobileCenter.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.AppCenter.svg)](https://www.nuget.org/packages/Cake.AppCenter)

## Important

Supports Cake 0.26 and .NET Standard 2.0.

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.AppCenter"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.AppCenter"

...

// How to login using a token
Task("Login")
	.Does(() => {
		// or more containers at once
		AppCenterLogin(new AppCenterLoginSettings{ Token = "YOUR_TOKEN_HERE" });
	)};
```
Other commands follow same convention.

This version is built against AppCenter CLI tools version 1.0.16.

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors.