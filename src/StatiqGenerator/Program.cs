using Statiq.Markdown;
using Statiq.Razor;

await Bootstrapper
    .Factory
    .CreateDefault(args)
    .SetOutputPath("../../docs")
    .BuildPipeline("Render Markdown", builder => builder
        .WithInputReadFiles("*.md")
        .WithProcessModules(
            new RenderMarkdown(),
            new RenderRazor().WithLayout("/_layout.cshtml"))
        .WithOutputWriteFiles(".html"))
    .RunAsync();
