internal static class ConsoleHelper
{
	/// <summary>
	/// Afficher une ligne de texte dans une certaine couleur.
	/// </summary>
	/// <param name="color">Enum de la couleur du texte</param>
	/// <param name="message">Le texte</param>
	public static void ColorTextLine(ConsoleColor color, string message)
	{
		Console.ForegroundColor = color;
		Console.WriteLine(message);
		Console.ResetColor();
	}

	/// <summary>
	/// Afficher une ligne de texte dans une couleur et un fond dans une autre couleur.
	/// </summary>
	/// <param name="color">Enum de la couleur du texte</param>
	/// <param name="backgroundColor">Enum de la couleur du fond</param>
	/// <param name="message">Le texte</param>
	public static void BackgroundcolorTextLine(ConsoleColor color, ConsoleColor backgroundColor, string message)
	{
		Console.BackgroundColor = backgroundColor;
		Console.ForegroundColor = color;
		Console.WriteLine(message);
		Console.ResetColor();
	}

	/// <summary>
	/// Afficher un texte dans une certaine couleur.
	/// </summary>
	/// <param name="color">Enum de la couleur du texte</param>
	/// <param name="message">Le texte</param>
	public static void ColorText(ConsoleColor color, string message)
	{
		Console.ForegroundColor = color;
		Console.Write(message);
		Console.ResetColor();
	}

	/// <summary>
	/// Afficher un texte dans une couleur et un fond dans une autre couleur.
	/// </summary>
	/// <param name="color">Enum de la couleur du texte</param>
	/// <param name="backgroundColor">Enum de la couleur du fond</param>
	/// <param name="message">Le texte</param>
	public static void BackgroundcolorText(ConsoleColor color, ConsoleColor backgroundColor, string message)
	{
		Console.BackgroundColor = backgroundColor;
		Console.ForegroundColor = color;
		Console.Write(message);
		Console.ResetColor();
	}

	/// <summary>
	/// Afficher une ligne de texte en noir.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineBlack(string message) => ColorTextLine(ConsoleColor.Black, message);
	/// <summary>
	/// Afficher une ligne de texte en bleu.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineBlue(string message) => ColorTextLine(ConsoleColor.Blue, message);
	/// <summary>
	/// Afficher une ligne de texte en cyan.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineCyan(string message) => ColorTextLine(ConsoleColor.Cyan, message);
	/// <summary>
	/// Afficher une ligne de texte en gris.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineGray(string message) => ColorTextLine(ConsoleColor.Gray, message);
	/// <summary>
	/// Afficher une ligne de texte en vert.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineGreen(string message) => ColorTextLine(ConsoleColor.Green, message);
	/// <summary>
	/// Afficher une ligne de texte en magenta.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineMagenta(string message) => ColorTextLine(ConsoleColor.Magenta, message);
	/// <summary>
	/// Afficher une ligne de texte en rouge.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineRed(string message) => ColorTextLine(ConsoleColor.Red, message);
	/// <summary>
	/// Afficher une ligne de texte en blanc.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineWhite(string message) => ColorTextLine(ConsoleColor.White, message);
	/// <summary>
	/// Afficher une ligne de texte en jaune.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineYellow(string message) => ColorTextLine(ConsoleColor.Yellow, message);
	/// <summary>
	/// Afficher une ligne de texte en bleu sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkBlue(string message) => ColorTextLine(ConsoleColor.DarkBlue, message);
	/// <summary>
	/// Afficher une ligne de texte en cyan sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkCyan(string message) => ColorTextLine(ConsoleColor.DarkCyan, message);
	/// <summary>
	/// Afficher une ligne de texte en gris sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkGray(string message) => ColorTextLine(ConsoleColor.DarkGray, message);
	/// <summary>
	/// Afficher une ligne de texte en vert sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkGreen(string message) => ColorTextLine(ConsoleColor.DarkGreen, message);
	/// <summary>
	/// Afficher une ligne de texte en magenta sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkMagenta(string message) => ColorTextLine(ConsoleColor.DarkMagenta, message);
	/// <summary>
	/// Afficher une ligne de texte en rouge sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkRed(string message) => ColorTextLine(ConsoleColor.DarkRed, message);
	/// <summary>
	/// Afficher une ligne de texte en jaune sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteLineDarkYellow(string message) => ColorTextLine(ConsoleColor.DarkYellow, message);

	/// <summary>
	/// Afficher une ligne de texte blanc sur fond noir.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineBlack(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.Black, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond bleu.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineBlue(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Blue, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond cyan.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineCyan(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Cyan, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond gris.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineGray(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Gray, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond vert.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineGreen(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Green, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur noir magenta.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineMagenta(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Magenta, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond rouge.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineRed(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Red, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond blanc.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineWhite(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.White, message);
	/// <summary>
	/// Afficher une ligne de texte noir sur fond jaune.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineYellow(string message) => BackgroundcolorTextLine(ConsoleColor.Black, ConsoleColor.Yellow, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond bleu sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkBlue(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkBlue, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond cyan sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkCyan(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkCyan, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond gris sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkGray(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkGray, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond vert sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkGreen(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkGreen, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond magenta sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkMagenta(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkMagenta, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond rouge sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkRed(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkRed, message);
	/// <summary>
	/// Afficher une ligne de texte blanc sur fond jaune sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundLineDarkYellow(string message) => BackgroundcolorTextLine(ConsoleColor.White, ConsoleColor.DarkYellow, message);

	/// <summary>
	/// Afficher une texte en noir.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextBlack(string message) => ColorText(ConsoleColor.Black, message);
	/// <summary>
	/// Afficher un texte en bleu.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextBlue(string message) => ColorText(ConsoleColor.Blue, message);
	/// <summary>
	/// Afficher un texte en cyan.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextCyan(string message) => ColorText(ConsoleColor.Cyan, message);
	/// <summary>
	/// Afficher un texte en gris.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextGray(string message) => ColorText(ConsoleColor.Gray, message);
	/// <summary>
	/// Afficher un texte en vert.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextGreen(string message) => ColorText(ConsoleColor.Green, message);
	/// <summary>
	/// Afficher un texte en magenta.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextMagenta(string message) => ColorText(ConsoleColor.Magenta, message);
	/// <summary>
	/// Afficher un texte en rouge.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextRed(string message) => ColorText(ConsoleColor.Red, message);
	/// <summary>
	/// Afficher un texte en blanc.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextWhite(string message) => ColorText(ConsoleColor.White, message);
	/// <summary>
	/// Afficher un texte en jaune.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextYellow(string message) => ColorText(ConsoleColor.Yellow, message);
	/// <summary>
	/// Afficher un texte en bleu sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkBlue(string message) => ColorText(ConsoleColor.DarkBlue, message);
	/// <summary>
	/// Afficher un texte en cyan sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkCyan(string message) => ColorText(ConsoleColor.DarkCyan, message);
	/// <summary>
	/// Afficher un texte en gris sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkGray(string message) => ColorText(ConsoleColor.DarkGray, message);
	/// <summary>
	/// Afficher un texte en vert sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkGreen(string message) => ColorText(ConsoleColor.DarkGreen, message);
	/// <summary>
	/// Afficher un texte en magenta sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkMagenta(string message) => ColorText(ConsoleColor.DarkMagenta, message);
	/// <summary>
	/// Afficher un texte en rouge sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkRed(string message) => ColorText(ConsoleColor.DarkRed, message);
	/// <summary>
	/// Afficher un texte en jaune sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteTextDarkYellow(string message) => ColorText(ConsoleColor.DarkYellow, message);

	/// <summary>
	/// Afficher un texte blanc sur fond noir.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextBlack(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.Black, message);
	/// <summary>
	/// Afficher un texte noir sur fond bleu.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextBlue(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Blue, message);
	/// <summary>
	/// Afficher un texte noir sur fond cyan.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextCyan(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Cyan, message);
	/// <summary>
	/// Afficher une texte noir sur fond gris.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextGray(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Gray, message);
	/// <summary>
	/// Afficher un texte noir sur fond vert.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextGreen(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Green, message);
	/// <summary>
	/// Afficher un texte blanc sur noir magenta.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextMagenta(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Magenta, message);
	/// <summary>
	/// Afficher un texte noir sur fond rouge.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextRed(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Red, message);
	/// <summary>
	/// Afficher un texte noir sur fond blanc.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextWhite(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.White, message);
	/// <summary>
	/// Afficher une texte noir sur fond jaune.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextYellow(string message) => BackgroundcolorText(ConsoleColor.Black, ConsoleColor.Yellow, message);
	/// <summary>
	/// Afficher un texte blanc sur fond bleu sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkBlue(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkBlue, message);
	/// <summary>
	/// Afficher un texte blanc sur fond cyan sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkCyan(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkCyan, message);
	/// <summary>
	/// Afficher un texte blanc sur fond gris sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkGray(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkGray, message);
	/// <summary>
	/// Afficher un texte blanc sur fond vert sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkGreen(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkGreen, message);
	/// <summary>
	/// Afficher un texte blanc sur fond magenta sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkMagenta(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkMagenta, message);
	/// <summary>
	/// Afficher un texte blanc sur fond rouge sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkRed(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkRed, message);
	/// <summary>
	/// Afficher un texte blanc sur fond jaune sombre.
	/// </summary>
	/// <param name="message">Le texte</param>
	public static void WriteBackgroundTextDarkYellow(string message) => BackgroundcolorText(ConsoleColor.White, ConsoleColor.DarkYellow, message);

	/// <summary>
	/// Nombre par défaut de caractères par défaut pour une ligne.
	/// </summary>
	private static int dashLengthDefault = 100;

	/// <summary>
	/// Nombre de caractère pour une ligne.
	/// </summary>
	public static int dashLength = 100;

	/// <summary>
	/// Réinitialiser la longeur de caractères au nombre par défaut.
	/// </summary>
	public static void ResetLength() => dashLength = dashLengthDefault;

	/// <summary>
	/// Enum permettant de définir le type de caractère utilisé pour une ligne.
	/// </summary>
	public enum DashType
	{
		Dash,
		SuperDash,
		Star,
		Equals,
		SuperEquals
	}

	/// <summary>
	/// Enum du type de caractère utilisé pour une ligne.
	/// </summary>
	public static DashType dashType = DashType.Dash;

	/// <summary>
	/// Dictionnaire des paires clé-valeur :<br/>
	/// - clé : enum du type de caractère,<br/>
	/// - valeur : le char correspondant.
	/// </summary>
	private static Dictionary<DashType, char> _dashChars = new Dictionary<DashType, char>()
	{
		{ DashType.Dash, '-' },
		{ DashType.SuperDash, '─' },
		{ DashType.Star, '*' },
		{ DashType.Equals, '=' },
		{ DashType.SuperEquals, '═' },
	};

	/// <summary>
	/// Afficher une ligne du caractère en cours dans une certaine couleur.
	/// </summary>
	/// <param name="color">La couleur de la ligne</param>
	public static void DashLine(ConsoleColor color)
	{
		ColorTextLine(color, new string(_dashChars[dashType], dashLength));
	}

	/// <summary>
	/// Afficher une ligne en noir.
	/// </summary>
	public static void DashLineBlack() => DashLine(ConsoleColor.Black);
	/// <summary>
	/// Afficher une ligne en bleu.
	/// </summary>
	public static void DashLineBlue() => DashLine(ConsoleColor.Blue);
	/// <summary>
	/// Afficher une ligne en cyan.
	/// </summary>
	public static void DashLineCyan() => DashLine(ConsoleColor.Cyan);
	/// <summary>
	/// Afficher une ligne en gris.
	/// </summary>
	public static void DashLineGray() => DashLine(ConsoleColor.Gray);
	/// <summary>
	/// Afficher une ligne en vert.
	/// </summary>
	public static void DashLineGreen() => DashLine(ConsoleColor.Green);
	/// <summary>
	/// Afficher une ligne en magenta.
	/// </summary>
	public static void DashLineMagenta() => DashLine(ConsoleColor.Magenta);
	/// <summary>
	/// Afficher une ligne en rouge.
	/// </summary>
	public static void DashLineRed() => DashLine(ConsoleColor.Red);
	/// <summary>
	/// Afficher une ligne en blanc.
	/// </summary>
	public static void DashLineWhite() => DashLine(ConsoleColor.White);
	/// <summary>
	/// Afficher une ligne en jaune.
	/// </summary>
	public static void DashLineYellow() => DashLine(ConsoleColor.Yellow);
	/// <summary>
	/// Afficher une ligne en bleu sombre.
	/// </summary>
	public static void DashLineDarkBlue() => DashLine(ConsoleColor.DarkBlue);
	/// <summary>
	/// Afficher une ligne en cyan sombre.
	/// </summary>
	public static void DashLineDarkCyan() => DashLine(ConsoleColor.DarkCyan);
	/// <summary>
	/// Afficher une ligne en gris sombre.
	/// </summary>
	public static void DashLineDarkGray() => DashLine(ConsoleColor.DarkGray);
	/// <summary>
	/// Afficher une ligne en vert sombre.
	/// </summary>
	public static void DashLineDarkGreen() => DashLine(ConsoleColor.DarkGreen);
	/// <summary>
	/// Afficher une ligne en magenta sombre.
	/// </summary>
	public static void DashLineDarkMagenta() => DashLine(ConsoleColor.DarkMagenta);
	/// <summary>
	/// Afficher une ligne en rouge sombre.
	/// </summary>
	public static void DashLineDarkRed() => DashLine(ConsoleColor.DarkRed);
	/// <summary>
	/// Afficher une ligne en jaune sombre.
	/// </summary>
	public static void DashLineDarkYellow() => DashLine(ConsoleColor.DarkYellow);


}

