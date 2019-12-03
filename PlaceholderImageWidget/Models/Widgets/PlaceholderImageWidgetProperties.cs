using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace SeventyeightDigital.PlaceholderImageWidget
{
    /// <summary>
    /// Properties for Placeholder Image widget.
    /// </summary>
    public class PlaceholderImageWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Width of placeholder image in pixels.
        /// </summary>
        [EditingComponent(IntInputComponent.IDENTIFIER, ExplanationText = "Width of placeholder Image in pixels.", Label = "Image Width", Order = 1)]
        public int Width { get; set; } = 100;

        /// <summary>
        /// Height of placeholder image in pixels.
        /// </summary>
        [EditingComponent(IntInputComponent.IDENTIFIER, ExplanationText = "Height of placeholder Image in pixels.", Label = "Image Height", Order = 2)]
        public int Height { get; set; } = 100;

        /// <summary>
        /// Text of placeholder image in pixels.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, ExplanationText = "Text of placeholder Image in pixels.", Label = "Image Text", Order = 3)]
        public string Text { get; set; } = "";

        /// <summary>
        /// CSS Class(es) of placeholder image.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, ExplanationText = "ID of placeholder Image.", Label = "ID of Placeholder Image", Order = 4)]
        public string PlaceholderImageID { get; set; } = "";

        /// <summary>
        /// CSS Class(es) of placeholder image.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, ExplanationText = "CSS Classes of placeholder Image.", Label = "CSS Classes of Placeholder Image", Order = 5)]
        public string PlaceholderImageCSSClasses { get; set; } = "";
    }
}