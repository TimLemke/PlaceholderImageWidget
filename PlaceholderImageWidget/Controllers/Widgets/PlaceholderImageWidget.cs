using Kentico.PageBuilder.Web.Mvc;
using SeventyeightDigital.PlaceholderImageWidget;

[assembly: RegisterWidget("Kentico.PlaceholderImageWidget", "Placeholder Image Widget", propertiesType: typeof(PlaceholderImageWidgetProperties), customViewName: "Widgets/_PlaceholderImageWidget", Description = "Provides a placeholder image to be used within page content.", IconClass = "icon-placeholder")]
