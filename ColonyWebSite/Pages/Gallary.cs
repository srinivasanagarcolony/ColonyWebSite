using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyWebSite.Pages
{
    public class GallaryModel : PageModel
    {
        private readonly ILogger<GallaryModel> _logger;
        public List<ImageDetails> ListOfImages;

        private string[] ListIfFolders;
        public GallaryModel(ILogger<GallaryModel> logger)
        {
            _logger = logger;
            this.ListOfImages = new List<ImageDetails>();
            //string imageFolderPath = "wwwroot/Images/Images1/";
            this.ListIfFolders = Directory.GetDirectories("wwwroot/Images/");
            foreach (string directory in this.ListIfFolders)
            {
                this.ListOfImages.Add(new ImageDetails() { DirectoryName = directory, ImageNames = Directory.GetFiles(directory).ToList() });
            }
        }

        public void OnGet()
        {

        }
    }

    public class ImageDetails
    {
        private string directoryName;
        private List<string> imageNames;

        public ImageDetails()
        {
            ImageNames = new List<string>();
        }
        public string DirectoryName { get => directoryName; set => directoryName = value; }
        public List<string> ImageNames { get => imageNames; set => imageNames = value; }
    }
}
