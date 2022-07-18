# ColoredConsoleShortcuts

*Helper Class* pour des projets .NET Console permettant d'afficher du texte ou des lignes en couleur, grâce à des fonctions servant de raccourcis.

Exemple d'utilisation :
```csharp
// Valeurs par défaut
ConsoleHelper.LineDarkMagenta();
ConsoleHelper.TextColorMagenta("Test Helper, valeurs par défaut");
ConsoleHelper.LineDarkMagenta();

ConsoleHelper.dashType = ConsoleHelper.DashType.Star; // changer le type de caractère
ConsoleHelper.dashLength = 20; // changer le nombre de caractères

ConsoleHelper.LineDarkRed();
ConsoleHelper.TextColorRed("Test Helper");
ConsoleHelper.LineDarkRed();

ConsoleHelper.TextBackgroundBlack("Text Helper, background");
ConsoleHelper.TextBackgroundBlue("Text Helper, background");
ConsoleHelper.TextBackgroundCyan("Text Helper, background");
ConsoleHelper.TextBackgroundGray("Text Helper, background");
ConsoleHelper.TextBackgroundGreen("Text Helper, background");
ConsoleHelper.TextBackgroundMagenta("Text Helper, background");
ConsoleHelper.TextBackgroundRed("Text Helper, background");
ConsoleHelper.TextBackgroundWhite("Text Helper, background");
ConsoleHelper.TextBackgroundYellow("Text Helper, background");
ConsoleHelper.TextBackgroundDarkBlue("Text Helper, background");
ConsoleHelper.TextBackgroundDarkCyan("Text Helper, background");
ConsoleHelper.TextBackgroundDarkGray("Text Helper, background");
ConsoleHelper.TextBackgroundDarkGreen("Text Helper, background");
ConsoleHelper.TextBackgroundDarkMagenta("Text Helper, background");
ConsoleHelper.TextBackgroundDarkRed("Text Helper, background");
ConsoleHelper.TextBackgroundDarkYellow("Text Helper, background");

ConsoleHelper.ResetLength(); // réinit à la valeur par défaut
```

Rendu :
![Rendu des instructions précédentes](Rendu.png)