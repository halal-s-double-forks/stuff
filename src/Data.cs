﻿namespace Dottik.MemeDownloader
{
    internal struct InternalProgramData
    {
        public static readonly char[] illegalFileChars = Path.GetInvalidFileNameChars();
        public static readonly char[] illegalPathChars = Path.GetInvalidPathChars();

        public static ulong MaxRepeatTimes = 0;
        public static ulong TimesRepeated = 0;
        
        public static int BotCount = 32;

        public static readonly string ProgramName = "Meme Downloader 2016";
        public static readonly string DataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @$"\Dottik\{ProgramName}\";
        public static readonly string CurrentDate = DateTime.Today.ToString().Split(' ')[0].Replace('/', '-');
        public static string TargetFolder = Environment.CurrentDirectory + @"\Shitposs\";
        public static string TargetSubReddit0 = "";
        public static string TargetSubReddit1 = ""; 
        public static string TargetSubReddit2 = "";
        public static string TargetSubReddit3 = "";
        public static string TargetSubReddit4 = "";
        public static string TargetSubReddit5 = "";

        public static bool SimultaneousDownload = false;
        public static bool STOPPROGRAM = false;
        public static bool WaitToKill = false;
        public static bool RestartBot = false;
        public static bool runningCi = false;


        //public static CookieContainer CookieContainer = new();

        public static readonly HttpClientHandler handler = new()
        {
            SslProtocols = System.Security.Authentication.SslProtocols.Tls12,
            UseCookies = true,
            AutomaticDecompression = DecompressionMethods.All
        };
        public static readonly HttpClient client = new(handler);
    }
    internal struct BotInformation
    {
        public static List<string> BlackListed = new();
        public static long aliveBots0 = 0;
        public static long aliveBots1 = 0;
    }
    internal struct Configurations 
    {
        public string TargetSubReddit0 = "balkans_irl";
        public string TargetSubReddit1 = "balkans_irl";
        public string TargetSubReddit2 = "balkans_irl";
        public string TargetSubReddit3 = "balkans_irl";
        public string TargetSubReddit4 = "balkans_irl";
        public string TargetSubReddit5 = "balkans_irl";
        public ulong MaxRepeatTimes = 10000;
        public bool SimultaneousDownload = true;
        public int ThreadCount = 32;
    }
}
