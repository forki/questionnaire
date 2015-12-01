namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Questionnaire")>]
[<assembly: AssemblyProductAttribute("Questionnaire")>]
[<assembly: AssemblyDescriptionAttribute("Build and publish questionnaires for research")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
