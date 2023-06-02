using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SuperShop.Helper
{
	public interface IImageHelper
	{
		Task<string> UploadImageAsync(IFormFile imageFile, string folder);
	}
}
