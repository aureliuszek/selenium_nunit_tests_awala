using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NUnit.Framework;

// Ogólne informacje o zestawie są kontrolowane poprzez następujący 
// zestaw atrybutów. Zmień wartości tych atrybutów, aby zmodyfikować informacje
// skojarzone z zestawem.
[assembly: AssemblyTitle("selenium_nunit_tests_awala.Properties")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("selenium_nunit_tests_awala.Properties")]
[assembly: AssemblyCopyright("Copyright ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//Ustawienie wartości false dla elementu ComVisible sprawia, że typy w tym zestawie nie będą widoczne
// dla składników COM. Jeśli potrzebny jest dostęp do typu w tym zestawie z 
// COM, ustaw wartość true dla atrybutu ComVisible tego typu.
[assembly: ComVisible(false)]

// Następujący identyfikator GUID jest identyfikatorem biblioteki typów w przypadku udostępnienia tego projektu w modelu COM
[assembly: Guid("cb70a0d1-7079-4496-9634-de4b96c5fdd9")]

// Informacje o wersji zestawu zawierają następujące cztery wartości:
//
//      Wersja główna
//      Wersja pomocnicza 
//      Numer kompilacji
//      Poprawka
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Aby zdefiniować atrybuty [Test]
[assembly: Parallelizable(ParallelScope.Children)]

// Ilość przeglądarek
[assembly: LevelOfParallelism(20)]