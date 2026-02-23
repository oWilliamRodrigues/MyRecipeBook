using CommonTestUtilities.BlobStorage;
using CommonTestUtilities.Entities;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using MyRecipeBook.Application.UseCases.Recipe.Image;
using MyRecipeBook.Exceptions;
using MyRecipeBook.Exceptions.ExceptionsBase;
using UseCases.Test.LoggedUser;
using UseCases.Test.Recipe.InlineData;

namespace UseCases.Test.Recipe.Image
{
    public class AddUpdateImageCoverUseCaseTest
    {
        [Theory]
        [ClassData(typeof(ImageTypesInlineData))]
        public async Task Success(IFormFile file)
        {
            (var user, _) = UserBuilder.Build();
            var recipe = RecipeBuilder.Build(user);

            var useCase = CreateUseCase(user, recipe);

            Func<Task> act = async () => await useCase.Execute(recipe.Id, file);

            await act.Should().NotThrowAsync();
        }

        [Theory]
        [ClassData(typeof(ImageTypesInlineData))]
        public async Task Error_Recipe_NotFound(IFormFile file)
        {
            (var user, _) = UserBuilder.Build();

            var useCase = CreateUseCase(user);

            var act = async () => await useCase.Execute(1, file);

            (await act.Should().ThrowAsync<NotFoundException>())
                .Where(e => e.Message.Equals(ResourceMessagesException.RECIPE_NOT_FOUND));
        }

        [Theory]
        [ClassData(typeof(ImageTypesInlineData))]
        public async Task Error_File_IsTxt()
        {
            (var user, _) = UserBuilder.Build();
            var recipe = RecipeBuilder.Build(user);

            var useCase = CreateUseCase(user, recipe);

            var file = FormFileBuilder.Txt();

            var act = async () => await useCase.Execute(recipe.Id, file);

            (await act.Should().ThrowAsync<ErrorOnValidationException>())
               .Where(e => e._errorMessages.Count == 1 &&
               e.Message.Equals(ResourceMessagesException.ONLY_IMAGES_ACCEPTED));
        }

        public static AddUpdateImageCoverUseCase CreateUseCase(
            MyRecipeBook.Domain.Entities.User user,
            MyRecipeBook.Domain.Entities.Recipe? recipe = null)
        {
            var loggedUser = LoggedUserBuilder.Build(user);
            var repository = new RecipeUpdateOnlyRepositoryBuilder().GetById(user, recipe).Build();
            var blobStorage = new BlobStorageServiceBuilder().Build();
            var unitOfWork = UnitOfWorkBuilder.Build();

            return new AddUpdateImageCoverUseCase(loggedUser, repository, unitOfWork, blobStorage);
        }
    }
}
