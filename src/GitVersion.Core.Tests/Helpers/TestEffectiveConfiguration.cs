using GitVersion.Extensions;
using GitVersion.Model.Configuration;
using GitVersion.VersionCalculation;

namespace GitVersion.Core.Tests.Helpers;

public class TestEffectiveConfiguration : EffectiveConfiguration
{
    public TestEffectiveConfiguration(
        AssemblyVersioningScheme assemblyVersioningScheme = AssemblyVersioningScheme.MajorMinorPatch,
        AssemblyFileVersioningScheme assemblyFileVersioningScheme = AssemblyFileVersioningScheme.MajorMinorPatch,
        string? assemblyVersioningFormat = null,
        string? assemblyFileVersioningFormat = null,
        string? assemblyInformationalFormat = null,
        VersioningMode versioningMode = VersioningMode.ContinuousDelivery,
        string gitTagPrefix = "v",
        string tag = "",
        string? nextVersion = null,
        string branchPrefixToTrim = "",
        bool preventIncrementForMergedBranchVersion = false,
        string? tagNumberPattern = null,
        string continuousDeploymentFallbackTag = "ci",
        bool trackMergeTarget = false,
        string? majorMessage = null,
        string? minorMessage = null,
        string? patchMessage = null,
        string? noBumpMessage = null,
        CommitMessageIncrementMode commitMessageMode = CommitMessageIncrementMode.Enabled,
        IEnumerable<IVersionFilter>? versionFilters = null,
        bool tracksReleaseBranches = false,
        bool isRelease = false,
        string commitDateFormat = "yyyy-MM-dd",
        bool updateBuildNumber = false) :
        base(assemblyVersioningScheme,
            assemblyFileVersioningScheme,
            assemblyInformationalFormat,
            assemblyVersioningFormat,
            assemblyFileVersioningFormat,
            versioningMode,
            gitTagPrefix,
            tag,
            nextVersion,
            IncrementStrategy.Patch,
            branchPrefixToTrim,
            preventIncrementForMergedBranchVersion,
            tagNumberPattern,
            continuousDeploymentFallbackTag,
            trackMergeTarget,
            majorMessage,
            minorMessage,
            patchMessage,
            noBumpMessage,
            commitMessageMode,
            versionFilters ?? Enumerable.Empty<IVersionFilter>(),
            tracksReleaseBranches,
            isRelease,
            commitDateFormat,
            updateBuildNumber,
            SemanticVersionFormat.Strict,
            0,
            0)
    {
    }
}
