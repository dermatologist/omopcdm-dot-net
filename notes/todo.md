```
Unhandled exception. CsvHelper.HeaderValidationException: Header with name 'Id' was not found. If you are expecting some headers to be missing and want to ignore this validation, set the configuration HeaderValidated to null. You can also change the functionality to do something else, like logging the issue.
   at CsvHelper.Configuration.ConfigurationFunctions.HeaderValidated(Boolean isValid, String[] headerNames, Int32 headerNameIndex, ReadingContext context)
   at CsvHelper.CsvReader.ValidateHeader(ClassMap map)
   at CsvHelper.CsvReader.ValidateHeader(Type type)
   at CsvHelper.CsvReader.ValidateHeader[T]()
   at CsvHelper.CsvReader.GetRecords[T]()+MoveNext()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at omopcdmlib.Utils.CreateVocab.create()
   at app.Program.Main(String[] args) in /scratch/beapen/omopcdm-dot-net/app/Program.cs:line 62

```