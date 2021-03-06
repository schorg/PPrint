// Copyright (C) by Vesa Karvonen

namespace PPrint

open System.Reflection
open System.Runtime.InteropServices

[<AutoOpen>]
module AssemblyInfo =
  [<Literal>]
  let Version = "2.0.0"

[<assembly: AssemblyTitle "PPrint">]
[<assembly: AssemblyDescription "A pretty printing library for F# based on Wadler's and Leijen's work.">]
[<assembly: AssemblyConfiguration "">]
[<assembly: AssemblyCompany "">]
[<assembly: AssemblyProduct "PPrint">]
[<assembly: AssemblyCopyright "© Vesa Karvonen">]
[<assembly: AssemblyTrademark "">]
[<assembly: AssemblyCulture "">]

[<assembly: AssemblyVersion(Version)>]
[<assembly: AssemblyFileVersion(Version)>]

()
