namespace PZone.Tools
{
    public class ResizeProperties
    {
        [CommandLineProperty("s")]
        public string SourceFileName { get; set; }

        [CommandLineProperty("r")]
        public string ResultFileName { get; set; }

        [CommandLineProperty("w")]
        public int Width { get; set; }

        [CommandLineProperty("h")]
        public int Height { get; set; }
    }
}