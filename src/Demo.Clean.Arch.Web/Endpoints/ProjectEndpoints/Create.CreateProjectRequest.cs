using System.ComponentModel.DataAnnotations;

namespace Demo.Clean.Arch.Web.Endpoints.ProjectEndpoints;

public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
