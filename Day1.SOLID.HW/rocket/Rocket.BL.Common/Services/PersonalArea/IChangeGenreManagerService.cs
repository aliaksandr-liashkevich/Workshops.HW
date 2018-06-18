using System.Collections;

namespace Rocket.BL.Common.Services.PersonalArea
{
    /// <summary>
    /// Интерфейс для работы с жанрами.
    /// </summary>
    public interface IChangeGenreManagerService
    {
        /// <summary>
        /// Получение всех жанров из базы.
        /// </summary>
        /// <returns>Коллекцию жанров.</returns>
        IEnumerable GetAllGenres();

        /// <summary>
        /// Добавление жанра в персональный список ожидания релизов.
        /// </summary>
        /// <param name="id">id идентификатор пользователя.</param>
        /// <param name="genre">Жанр продукта, который пользователь хочет добавить в список.</param>
        void AddGenre(string id, string genre);

        /// <summary>
        /// Удаление жанра TV из персонального списка ожидания релизов.
        /// </summary>
        /// <param name="id">id идентификатор пользователя.</param>
        /// <param name="genre">Жанр продукта, который пользователь хочет удалить из списка.</param>
        void DeleteGenre(string id, string genre);
    }
}
