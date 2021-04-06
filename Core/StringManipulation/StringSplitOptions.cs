namespace Core.StringManipulation
{
    public class StringSplitOptions
    {
        public int Count { get; set; }
        public bool Reverse { get; set; }

        public static readonly StringSplitOptions Default = new StringSplitOptions { Count = 0, Reverse = false };
    }

    
}
