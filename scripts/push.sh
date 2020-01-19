dotnet nuget push ./bin/Release/*.nupkg -k $NUGET_API_KEY -s "https://nuget.org" 
dotnet nuget push ./bin/Release/*.nupkg -k $GITHUB_API_KEY -s "https://nuget.pkg.github.com/Dramarr/index.json" 