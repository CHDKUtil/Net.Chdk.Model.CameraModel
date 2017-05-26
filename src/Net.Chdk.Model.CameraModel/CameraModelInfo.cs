namespace Net.Chdk.Model.CameraModel
{
    public sealed class CameraModelInfo
    {
#if METADATA
        public System.Version Version { get; set; }
#endif
        public string[] Names { get; set; }
    }
}
