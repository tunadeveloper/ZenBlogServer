using ZenBlog.Application.Base;

namespace ZenBlog.Application.Features.Categories.Results;

public class GetCategoryQueryResult:BaseDTO
{
    public string CategoryName { get; set; }
    //public IList<GetBlogQueryResult> Blogs { get; set; }
}