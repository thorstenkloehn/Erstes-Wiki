sudo rm -rf docs/_site
dotnet build
docfx docs/docfx.json
npm run ver