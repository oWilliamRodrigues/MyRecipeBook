using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBook.Application.UseCases.Recipe.Register
{
    public interface IRegisterRecipeUseCase
    {
        public Task<ResponseRegisteredRecipeJson> Execute(RequestRecipeJson request);
    }
}
