using AutoMapper;
using FluentValidation;
using SchoolDataSyncMigrate.Bl.Dto;
using SchoolDataSyncMigrate.Model.Entities;
using SchoolDataSyncMigrate.Model.Repositories;

namespace SchoolDataSyncMigrate.Services.Services
{
    public interface IUserService : IBaseService<NewUsers, NewUsersDto> { }
    public class UserService : BaseService<NewUsers, NewUsersDto>, IUserService
    {
        public UserService(
            IUserRepository repository,
            IMapper mapper,
            IValidator<NewUsersDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
