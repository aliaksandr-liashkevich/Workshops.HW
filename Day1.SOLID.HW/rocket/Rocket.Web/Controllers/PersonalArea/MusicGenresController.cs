using System.Net;
using System.Web.Http;
using FluentValidation;
using Rocket.BL.Common.Models.PersonalArea;
using Rocket.BL.Common.Services.PersonalArea;
using Rocket.Web.Extensions;
using Rocket.Web.Properties;
using Swashbuckle.Swagger.Annotations;

namespace Rocket.Web.Controllers.PersonalArea
{
    [RoutePrefix("")]
    public class MusicGenresController : ApiController
    {
        private IGenreManagerService<MusicGenre> _musicGenreManagerService;

        public MusicGenresController(IGenreManagerService<MusicGenre> musicGenreManagerService)
        {
            _musicGenreManagerService = musicGenreManagerService;
        }

        [HttpGet]
        [Route("genres/all/music")]
        public IHttpActionResult GetAllMusicGenres()
        {
            var musicGenres = _musicGenreManagerService.GetAllGenres();
            return musicGenres == null ? (IHttpActionResult)NotFound() : Ok(musicGenres);
        }

        [HttpPut]
        [Route("personal/genres/music/add")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Genre is not valid", typeof(string))]
        public IHttpActionResult SaveMusicGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return BadRequest(Resources.EmptyGenre);
            }

            try
            {
                _musicGenreManagerService.AddGenre(User.GetUserId(), genre);
            }
            catch (ValidationException exception)
            {
                return BadRequest(exception.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPut]
        [Route("personal/genres/music/delete")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Genre is not valid", typeof(string))]
        public IHttpActionResult DeleteMusicGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return BadRequest(Resources.EmptyGenre);
            }

            try
            {
                _musicGenreManagerService.DeleteGenre(User.GetUserId(), genre);
            }
            catch (ValidationException exception)
            {
                return BadRequest(exception.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
