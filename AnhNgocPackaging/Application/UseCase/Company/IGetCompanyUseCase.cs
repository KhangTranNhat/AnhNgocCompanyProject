namespace AnhNgocPackaging.Application.UseCase.Company
{
    public interface IGetCompanyUseCase
    {
        Task<CompanyResultDto> Execute();
    }
}
