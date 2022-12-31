﻿namespace ScottPlot.Style;

/// <summary>
/// Customization state for a piece of text.
/// This configuration object (reference type) permanently lives inside objects which require styling.
/// It is recommended to use this object as an init-only property.
/// </summary>
public class FontStyle
{
    public string Name { get; set; } = FontService.SerifFontName;
    public float Size { get; set; } = 12;
    public Color Color { get; set; } = Colors.Black;
    public bool Bold { get; set; } = false;
    public bool Italic { get; set; } = false;
}