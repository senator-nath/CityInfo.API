using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/Files")]
    [ApiController]
    public class FilesController : ControllerBase
    {

        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw new System.ArgumentException(nameof(fileExtensionContentTypeProvider));
        }


        [HttpGet("{fileId}")]
        public ActionResult GetFiles(string fileId)
        {
            var pathToFile = "nathaniel cv word-1.pdf";

            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            if (_fileExtensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }
        //public async Task<ActionResult> CreateFiles(IFormFile file)
        //{
        //    if (file.Length == 0 || file.Length > 20971520 || file.ContentType != "applicatio/pdf")
        //    {
        //        return BadRequest("No File or an Invalid one have been inputted.");
        //    }
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), $"uploaded_file_{Guid.NewGuid()}.pdf");

        //    using (var strem = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(strem);
        //    }
        //    return Ok("file have been uploaded succesfully.");
        //}
    }
}
