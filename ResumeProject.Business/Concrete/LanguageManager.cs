using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using ResumeProject.Business.Abstract;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Concrete
{
    public sealed class LanguageManager : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageManager(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public async Task<IDataResult<Language>> AddAsync(Language entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Language>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Language>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Language>>> GetLanguagesGreaterLevelAsync(byte level)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Language entity)
        {
            throw new NotImplementedException();
        }
    }
}
