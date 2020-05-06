mkdir omopcdm-dot-net
cd omopcdm-dot-net/

dotnet new sln
dotnet new classlib -o omopcdmlib

dotnet sln add omopcdmlib/omopcdmlib.csproj

dotnet new xunit -o omopcdmlib.testing

dotnet add omopcdmlib.testing/omopcdmlib.testing.csproj reference omopcdmlib/omopcdmlib.csproj


dotnet test omopcdmlib.testing/omopcdmlib.testing.csproj

cd omopcdmlib
dotnet pack
cd ..

dotnet new console -o app
dotnet sln add app/app.csproj 


<RestoreSources>$(RestoreSources);/home/beapen/scratch/omopcdm-dot-net/omopcdmlib/bin/Debug;https://api.nuget.org/v3/index.json</RestoreSources>


dotnet add app package omopcdmlib

dotnet build app
