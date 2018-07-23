using System.Threading.Tasks;
using DevPP.Configuration.Dto;

namespace DevPP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
