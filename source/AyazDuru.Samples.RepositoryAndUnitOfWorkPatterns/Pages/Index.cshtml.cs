using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Entities;
using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task OnGetAsync()
        {
            Products = await _unitOfWork.Products.GetAllAsync();
        }
    }
}
