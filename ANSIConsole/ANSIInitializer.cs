namespace ANSIConsole
{
	public static class ANSIInitializer
	{
		/// <summary>
		/// Run once before using the console.
		/// You may not need to initialize the ANSI console mode.
		/// </summary>
		/// <returns>true if initialization was successful</returns>
		public static bool Init(bool _ = true) => true;

		public static bool Enabled => true;
	}
}
