using System.ComponentModel;

namespace ARI.Commands.Settings;

public class InventorySettings : CommandSettings
{
    [CommandArgument(0, "<tenantId>")]
    [ValidateString]
    [Description("Azure Tenant Id")]
    public string TenantId { get; set; } = string.Empty;

    [CommandArgument(1, "<outputpath>")]
    [ValidatePath]
    [Description("Output path")]
    public DirectoryPath OutputPath { get; set; } = System.Environment.CurrentDirectory;

    [CommandOption("--skip-tenant-overview")]
    [Description("Skip tenant information in overview")]
    public bool SkipTenantOverview { get; set; }

    [CommandOption("--run-in-parallel")]
    [Description("Flag for if generation should be parallized.")]
    public bool RunInParallel { get; set; }

    [CommandOption("--markdown-name")]
    [Description("Markdown file prefix (default \"index\")")]
    public string MarkdownName { get; set; } = "index";

    [CommandOption("--skip-frontmatter")]
    [Description("Skip frontmatter generation")]
    public bool SkipFrontmatter { get; set; }

    [CommandOption("--skip-frontmatter-summary")]
    [Description("Exclude summary from frontmatter")]
    public bool SkipFrontmatterSummary { get; set; }

    [CommandOption("--skip-frontmatter-modifed")]
    [Description("Exclude modfied from frontmatter")]
    public bool SkipFrontmatterModified { get; set; }

    [CommandOption("--skip-frontmatter-order")]
    [Description("Exclude order from frontmatter")]
    public bool SkipFrontmatterOrder { get; set; }
}