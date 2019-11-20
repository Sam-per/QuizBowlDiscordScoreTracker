﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

// Irrelevant for .Net Core: https://www.skylinetechnologies.com/Blog/Skyline-Blog/December_2018/async-await-configureawait
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2007:Consider calling ConfigureAwait on the awaited task", Justification = "Irrelevant to .Net Core")]