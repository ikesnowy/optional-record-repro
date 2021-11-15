using System.ComponentModel.DataAnnotations;

namespace OptionalRecordTest;

public record PagingParams([Range(1, int.MaxValue)] int PageIndex, [Range(1, int.MaxValue)] int PageSize);