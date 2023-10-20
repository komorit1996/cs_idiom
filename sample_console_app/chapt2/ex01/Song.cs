namespace sample_console_app.chapt2.ex01
{
    internal class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; } // 演奏時間

        public Song(string Title, string ArtistName, int Length)
        {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;

        }

    }

}
