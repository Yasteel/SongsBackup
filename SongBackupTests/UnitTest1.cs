using NSubstitute;
using SongsBackup.Interfaces;

namespace SongBackupTests
{
    public class UnitTest1
    {
        private readonly IFileService fileService;

        public UnitTest1()
        {
            this.fileService = Substitute.For<IFileService>();

            this.fileService.GetSongs(Arg.Any<string>()).Returns(FileHelper.GetFiles());
        }
        
        [Fact]
        public void Read_Files_Should_Succeed_Given_Files_Exist_In_Directory()
        {
            // Arrange
            var directory = "C:/Yasteel";
            
            // Act
            var files = this.fileService.GetSongs(directory);
            
            // Assert
            Assert.True(files.Count() > 0);
        }
        
        [Fact]
        public void Extract_Metadata_Should_Succeed_Given_File_Contains_Metadata()
        {
            // Arrange
            
            // Act
            
            // Assert
        }
        
        [Fact]
        public void Get_PlayList_From_Spotify_Should_Succeed_Given_Valid_UserThingyFromSpotify() // will rename when I find out what that thingy is
        {
            // Arrange
            
            // Act
            
            // Assert
        }
        
        [Theory]
        [InlineData("#", "test")]
        public void Append_To_Playlist_Should_Succeed_Given_Valid_Parameters(string songUri, string playlistName)
        {
            // Arrange
            
            // Act
            
            // Assert
        }
    }

    public static class FileHelper
    {
        public static List<string> GetFiles()
        {
            return new ()
            {
                "File 1",
                "File 2"
            };
        }
    }
}

