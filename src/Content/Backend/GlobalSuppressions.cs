﻿using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA0001:Enable Project documentation", Justification = "Project must decide.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Project must decide.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:The file header is missing or not located at the top of the file", Justification = "Project must decide.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1652:Enable XML documentation output", Justification = "Project must decide.")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names must not begin with an underscore", Justification = "Stylistic choice")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:Prefix local calls with this", Justification = "Stylistic choice")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1615:Element return value must be documented", Justification = "Most of the time it is straightforward")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:Element parameters must be documented", Justification = "Most of the time it is straightforward")]
[assembly: SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1005:Single line comments must begin with single space", Justification = "Prevents quick edits during development")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1515:Single-line comment must be preceded by blank line", Justification = "Prevents quick edits during development")]

[assembly: SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Triggers false positive for log messages.")]
[assembly: SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Collision with enumerable / collection rule.")]
[assembly: SuppressMessage("Performance", "CA1812:Avoid uninstantiated internal classes", Justification = "Instantiated via Dependency Injection.")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Conflicts with some standard patterns.")]
[assembly: SuppressMessage("Reliability", "CA2007:Do not directly await a Task", Justification = "Not needed systematically.")]
