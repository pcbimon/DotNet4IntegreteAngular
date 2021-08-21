# DotNet4IntegreteAngular
1. Create .Net MVC API Project

2. Create Angular Project Inside .Net Project

3. Set up Angular Output Folder To Bundle
`"outputPath": "../Bundles/AngularOutput"`

4. Add Bundle Angular to .Net Project from `BundleConfig.cs`

```
bundles.Add(new Bundle("~/bundles/Angular").Include(
"~/Bundles/AngularOutput/polyfills.*",
"~/Bundles/AngularOutput/runtime.*",
"~/Bundles/AngularOutput/main.*"));
bundles.Add(new StyleBundle("~/Content/Angular").Include(
"~/Bundles/AngularOutput/styles.*"));
```

5. Change .Net Route Config File

```
routes.MapRoute(
   name: "Default",
   url: "{*url}",
   defaults: new { controller = "Home", action = "Index" }
);
```
6. Remove content in `Home/Index.cshtml` file
7. Change content in `Shared/_Layout.cshtml`

```
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    <base href="/">
    @Styles.Render("~/Content/Angular")
</head>
<body>
    @RenderBody()
    <app-root></app-root>
    @Scripts.Render("~/bundles/Angular")
</body>
</html>
```

***:hugs:Completed:hugs:***
