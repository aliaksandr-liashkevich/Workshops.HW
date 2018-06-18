using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Rocket.BL.Common.Models.PersonalArea;
using Rocket.BL.Common.Services.PersonalArea;
using Rocket.BL.Properties;
using Rocket.DAL.Common.UoW;

namespace Rocket.BL.Services.PersonalArea
{
    public class ChangeTvGenreManagerService : BaseService, IChangeTvGenreManagerService
    {
        public ChangeTvGenreManagerService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// Получение всех TV жанров из базы.
        /// </summary>
        /// <returns>Коллекцию жанров.</returns>
        public IEnumerable GetAllGenres()
        {
            return AutoMapper.Mapper.Map<IEnumerable<Genre>>(_unitOfWork.GenreRepository.Get());
        }

        /// <summary>
        /// Добавляет ТV жанр пользователю
        /// </summary>
        /// <param name="id">Id пользователя</param>
        /// <param name="genre">Имя жанра для добавления</param>
        public void AddGenre(string id, string genre)
        {
            var modelUser = _unitOfWork.UserAuthorisedRepository.Get(f => f.DbUser_Id == id).FirstOrDefault()
                            ?? throw new ValidationException(Resources.EmptyModel);
            if (_unitOfWork.GenreRepository.Get(f => f.Name.ToUpper() == genre.ToUpper()).FirstOrDefault() == null)
            {
                throw new ValidationException(Resources.GenreWrongName);
            }

            if (modelUser.Genres.Where(f => f.Name.ToUpper() == genre.ToUpper()).FirstOrDefault() != null)
            {
                throw new ValidationException(Resources.GenreDuplicate);
            }

            modelUser.Genres.Add(_unitOfWork.GenreRepository.Get(f => f.Name.ToUpper() == genre.ToUpper()).FirstOrDefault());
            _unitOfWork.UserAuthorisedRepository.Update(modelUser);
            _unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Удаляет музыкальный жанр у пользователя
        /// </summary>
        /// <param name="id">Id пользователя</param>
        /// <param name="genre">Имя жанра для удаления</param>
        public void DeleteGenre(string id, string genre)
        {
            var modelUser = _unitOfWork.UserAuthorisedRepository.Get(f => f.DbUser_Id == id).FirstOrDefault()
                            ?? throw new ValidationException(Resources.EmptyModel);
            if (modelUser.Genres.Where(f => f.Name.ToUpper() == genre.ToUpper()).FirstOrDefault() != null)
            {
                modelUser.Genres.Remove(_unitOfWork.GenreRepository.Get(f => f.Name.ToUpper() == genre.ToUpper()).FirstOrDefault());
            }
            else
            {
                throw new ValidationException(Resources.GenreWrongName);
            }

            _unitOfWork.UserAuthorisedRepository.Update(modelUser);
            _unitOfWork.SaveChanges();
        }
    }
}
