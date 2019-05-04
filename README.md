# MacOSで動くように変更する方法
参考：https://docs.microsoft.com/ja-jp/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.2&tabs=visual-studio-code

## SqlServerからSqliteに変更する
詳しくはコミットを参照

## コマンドでマイグレーションを実行する
```
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```
